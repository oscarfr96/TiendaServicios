using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TiendaServicios.Api.Autor.Persistencia;
using MediatR;
using TiendaServicios.Api.Autor.Aplicacion;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// -- Add services to the container. --

//FLUENT VALIDATION
builder.Services.AddControllers().AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssemblyContaining<Nuevo>());

// SWAGGER
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//CONEXIÓN CON BBDD
builder.Services.AddDbContext<ContextoAutor>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("ConexionDatabase"));
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
