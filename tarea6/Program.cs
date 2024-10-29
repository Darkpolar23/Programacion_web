using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();

// Configura Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Mi API",
        Version = "v1",
        Description = "Documentación de mi API con Swagger"
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API v1");
        c.RoutePrefix = string.Empty; 
    });
}

// Creación de un grupo de rutas para experimentos
var expGroup = app.MapGroup("/experimentos").WithTags("Experimentos").WithDescription("Rutas de pruebas y experimentos extraños");


expGroup.MapGet("/saludo", (string name) => $"Hello {name}!");

// Creación de un grupo de rutas para asignación verdadera
var trueGroup = app.MapGroup("/asignacion").WithTags("Asignación verdadera").WithDescription("Rutas de la asignación verdadera");

// Ruta para obtener noticias, delegando la ejecución a un método en la clase Paso1

trueGroup.MapGet("/noticias", () => Noticias.Ejecutar());

trueGroup.MapPost("/registro", (Usuario u)  => ManejadorUsuario.Registro(u));

trueGroup.MapPost("/iniciar_sesion", (DatosLogin dl) => ManejadorUsuario.IniciarSesion(dl));

trueGroup.MapPost("Registro_incidencias", (Incidencia i) => ManejadorUsuario.RegistroIncidencia(i));

trueGroup.MapGet("/clima", async (double lat, double lon) =>
{
    // URL del servicio de clima (ejemplo con OpenWeatherMap)
    string apiKey = "9dc0c378e76fd0d757ff86ac22036891"; 
    string url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={apiKey}&units=metric";

    using var client = new HttpClient();
    var climaResponse = await client.GetFromJsonAsync<ClimaResponse>(url);

    if (climaResponse == null)
    {
        return Results.NotFound(new { message = "No se encontró información de clima para las coordenadas dadas." });
    }

    return Results.Ok(climaResponse);
});

app.Run();




