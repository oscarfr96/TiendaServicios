using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TiendaServicios.Api.Libro.Aplicacion;
using TiendaServicios.Api.Libro.Persistencia;

var builder = WebApplication.CreateBuilder(args);

// -- Add services to the container. --

//FLUENT VALIDATION
builder.Services.AddControllers().AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssemblyContaining<Nuevo>());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//CONEXIÓN CON BBDD
builder.Services.AddDbContext<ContextoLibreria>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionDB"));
});

//MEDIATR
builder.Services.AddMediatR(typeof(Nuevo.Manejador).Assembly);

//AUTOMAPPER
builder.Services.AddAutoMapper(typeof(Consulta.Manejador));

// -- ----------------------------- --

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
