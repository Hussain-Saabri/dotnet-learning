var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//middleware will run for every request for checking such as authentication 
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Welcome to the ASP.net Core 6");

//}
//);
// we can create as many as custom middleware and it runs on the order and it strcitly execute it 


//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Second Middleware");

//}
//);

// we use an Use and next to call the next middleware 
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Welcome to the ASP.net Core 6 \n");
    await next();
});
app.Run(async (context) =>
{
    await context.Response.WriteAsync("Second Middleware");

}
);
app.Run();
