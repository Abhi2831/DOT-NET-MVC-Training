using Microsoft.EntityFrameworkCore;
using WebCar.WebApp._2_Services.ServiceInterfaces;
using WebCar.WebApp._2_Services.ServiceLogic;
using WebCar.WebApp._3_BusinessLogic.BusinessLogic;
using WebCar.WebApp._3_BusinessLogic.BusinessLogicInterfaces;
using WebCar.WebApp._4_DataAcess;
using WebCar.WebApp._4_DataAcess.IRepository;
using WebCar.WebApp._4_DataAcess.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ICar, CarService>();
builder.Services.AddTransient<iCarBusiness, CarBusiness>();
builder.Services.AddTransient<ICarRepository, CarRepository>();



var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Context>(x => x.UseSqlServer(connectionString));




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
