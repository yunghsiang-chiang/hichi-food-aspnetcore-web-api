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

// ✅ CORS：明確允許來源（包含 8083 與 editor-bot）
builder.Services.AddCors(options =>
{
    options.AddPolicy("corsapp", policy =>
    {
        policy
            .WithOrigins(
                "https://internal.hochi.org.tw:8083",
                "https://editor-bot.no8.io"
            )
            .AllowAnyHeader()
            .AllowAnyMethod();
        // 如果你有用 cookie/驗證，再加：
        // .AllowCredentials();
    });
});

var app = builder.Build();

app.UseWebSockets();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(c => c.SerializeAsV2 = true);
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

// ✅ 先 CORS（讓它能處理 preflight）
app.UseCors("corsapp");

// ✅ PNA header：保留即可，但不要攔截 OPTIONS
app.Use(async (context, next) =>
{
    context.Response.Headers["Access-Control-Allow-Private-Network"] = "true";
    await next();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
