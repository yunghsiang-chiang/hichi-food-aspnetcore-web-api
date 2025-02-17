using hochi_food.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient; // 引入 MySql.Data 命名空間

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
}); ;

// 註冊 SQL Server 的 DbContext
builder.Services.AddDbContext<HochiSystemContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HochiSystem")));

builder.Services.AddDbContext<HochiReportsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HochiReports")));

// 註冊 MySQL 資料庫
builder.Services.AddDbContext<foodContext>(options =>options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase")));
builder.Services.AddDbContext<attendanceContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase3")));
builder.Services.AddDbContext<hochi_configContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase4")));
builder.Services.AddDbContext<activityContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase5")));
builder.Services.AddDbContext<heipContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase6")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//services cors
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

app.UseWebSockets(); 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(c =>
    {
        c.SerializeAsV2 = true;
    });
    app.UseSwaggerUI();
}



app.UseAuthorization();

app.MapControllers();

//app cors
app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("corsapp");
app.UseAuthorization();

app.Run();
