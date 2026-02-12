using hochi_food.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler =
        System.Text.Json.Serialization.ReferenceHandler.Preserve;
});

// DbContexts
builder.Services.AddDbContext<HochiSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HochiSystem")));

builder.Services.AddDbContext<HochiReportsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HochiReports")));

builder.Services.AddDbContext<foodContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase")));
builder.Services.AddDbContext<attendanceContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase3")));
builder.Services.AddDbContext<hochi_configContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase4")));
builder.Services.AddDbContext<activityContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase5")));
builder.Services.AddDbContext<heipContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase6")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ CORS：請明確允許來源（不要用 WithOrigins("*")）
builder.Services.AddCors(options =>
{
    options.AddPolicy("corsapp", policy =>
    {
        policy
            .WithOrigins(
                "https://internal.hochi.org.tw:8083",
                "https://editor-bot.no8.io"
            // 若你還有其他前端來源，繼續加在這裡
            // "https://xxx.no8.io"
            )
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseWebSockets();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(c => c.SerializeAsV2 = true);
    app.UseSwaggerUI();
}

// ✅ PNA：必須加這個 header，否則瀏覽器會擋「local address space」
app.Use(async (context, next) =>
{
    context.Response.Headers["Access-Control-Allow-Private-Network"] = "true";

    // 讓 preflight OPTIONS 更穩（包含 PNA preflight）
    if (context.Request.Method == "OPTIONS")
    {
        // 讓 CORS preflight 能完整過
        var origin = context.Request.Headers["Origin"].ToString();
        if (!string.IsNullOrEmpty(origin))
            context.Response.Headers["Access-Control-Allow-Origin"] = origin;

        context.Response.Headers["Vary"] = "Origin";
        context.Response.Headers["Access-Control-Allow-Methods"] = "GET,POST,PUT,DELETE,OPTIONS";
        context.Response.Headers["Access-Control-Allow-Headers"] = context.Request.Headers["Access-Control-Request-Headers"].ToString();

        context.Response.StatusCode = StatusCodes.Status204NoContent;
        return;
    }

    await next();
});

app.UseHttpsRedirection();

app.UseRouting();

// ✅ CORS 要放在 MapControllers 前（或至少在 endpoints 前）
app.UseCors("corsapp");

app.UseAuthorization();

app.MapControllers();

app.Run();
