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

// ✅ CORS：明確允許來源
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
        // 若需要 cookie/身分驗證才加：
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

// ✅ 先掛 CORS（讓它能處理 preflight、也能讓後面 4xx/5xx 盡量帶到 CORS header）
app.UseCors("corsapp");

// ✅ 例外統一處理成 JSON 500（避免 IIS/Kestrel 預設 500 沒帶 CORS）
app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        context.Response.StatusCode = 500;
        context.Response.ContentType = "application/json; charset=utf-8";
        await context.Response.WriteAsync("{\"ok\":false,\"message\":\"Internal Server Error\"}");
    });
});

// ✅ PNA header：保留即可
app.Use(async (context, next) =>
{
    context.Response.Headers["Access-Control-Allow-Private-Network"] = "true";
    await next();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
