var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IGreeting, MyGreeting>();

var app = builder.Build();

app.MapGet("/", (IGreeting g) => g.Hello());

app.Run();



interface IGreeting
{
    string Hello();
}

class MyGreeting : IGreeting
{
    public string Hello()
    {
        return "Hello Hussain based on dependency injection ";
    }
}