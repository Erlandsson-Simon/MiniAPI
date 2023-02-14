WebApplication app = WebApplication.Create();

app.MapGet("/", Answer);
app.MapGet("/superhero/", () =>
{
return "Batman";
});

app.Run();

static string Answer()
{
    return "Hello";
}