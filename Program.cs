using lr1.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/company", () =>
{
    var company = new Company("IT-FAQ", "Sadowa 21", 26);
    return Results.Json(company);
});


app.MapGet("/random", () =>
{
    var rand = new Random();
    int randNumber = rand.Next(0, 101); 
    return Results.Text($"Random number: {randNumber}");
});

app.Run();