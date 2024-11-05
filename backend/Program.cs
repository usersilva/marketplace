using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

//// ���������� ��������� ���� ������
//builder.Services.AddDbContext<MarketplaceDbContext>(options =>
//    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//// ���������� ������������
//builder.Services.AddControllers();

//// ��������� CORS
//builder.Services.AddCors(options =>
//{
//  options.AddPolicy("AllowAll", builder =>
//  {
//    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
//  });
//});

var app = builder.Build();

//// ������������� CORS
//app.UseRouting();
//app.UseCors("AllowAll");

//// ������������ �������� �����
//app.MapControllers();

app.Run();