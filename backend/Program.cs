using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

//// Добавление контекста базы данных
//builder.Services.AddDbContext<MarketplaceDbContext>(options =>
//    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//// Добавление контроллеров
//builder.Services.AddControllers();

//// Настройка CORS
//builder.Services.AddCors(options =>
//{
//  options.AddPolicy("AllowAll", builder =>
//  {
//    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
//  });
//});

var app = builder.Build();

//// Использование CORS
//app.UseRouting();
//app.UseCors("AllowAll");

//// Конфигурация конечных точек
//app.MapControllers();

app.Run();