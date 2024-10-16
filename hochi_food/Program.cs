using hochi_food.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<foodContext>(options =>options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase")));
builder.Services.AddDbContext<attendanceContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase3")));
builder.Services.AddDbContext<hochi_configContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase4")));
builder.Services.AddDbContext<activityContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("WebDatabase5")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//services cors
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
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
