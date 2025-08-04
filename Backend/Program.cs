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

//Cors
builder.Services.AddCors(options =>
    {
        /*
        //politica de Cors con nombre Unico
        options.AddPolicy("OrigenEspecifico",
            policy =>
                {
                    //Especifica origenes permitidos.
                    policy.WithOrigins(
                        "http://localhost:63336",   // Para Flutter en navegador web o emulador iOS
                        "http://10.0.2.2:63336",    // Para Flutter en emulador Android
                        "http://localhost:5215"     // El puerto de tu propia API
                    ).
                    AllowAnyHeader()
                    .AllowAnyMethod();
                });
        */

        // Define una política que permite CUALQUIER ORIGEN
        // ¡ESTO ES SOLO PARA DESARROLLO!
        options.AddPolicy("DevelopmentCorsPolicy",
            policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyHeader()
                      .AllowAnyMethod();
            });
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("OrigenEspecifico"); // Aplicar la política de CORS

app.UseAuthorization();

app.MapControllers();

app.Run();
