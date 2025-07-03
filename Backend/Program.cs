using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Pakuayb.AutoMapper;
using Pakuayb.Dtos;
using Pakuayb.Models;
using Pakuayb.Repository;
using Pakuayb.Services;
using Pakuayb.Validator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyeccion de dependencias
//Conexion a la DB
builder.Services.AddDbContext<SchoolContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolConnection"));
});

//AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

//Repository
builder.Services.AddScoped<IRepository<Alumno>, AlumnosRepository>();
//Servicio
builder.Services.AddKeyedScoped<IBaseServices<AlumnoDto, AlumnoInsertDto, AlumnoUpdateDto>, AlumnosService>("AlumnosService");

//Validaciones
builder.Services.AddScoped<IValidator<AlumnoInsertDto>, AlumnoInsertValidator>();
builder.Services.AddScoped<IValidator<AlumnoUpdateDto>, AlumnoUpdateValidator>();

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
