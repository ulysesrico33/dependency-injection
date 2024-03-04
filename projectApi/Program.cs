using Service;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//Services injection
builder.Services.AddSingleton<IThing>();

app.Run();
