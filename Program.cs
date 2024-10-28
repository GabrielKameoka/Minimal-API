var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (Minimal_API.Dominio.DTOs.LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "adm@test.com" && loginDTO.Senha == "12345678")
    {
        return Results.Ok("Login com sucesso.");
    }
    else
    {
        return Results.Unauthorized();
    }
});


app.Run();