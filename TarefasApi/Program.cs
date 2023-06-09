using TarefasApi.Extensions;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.AddPersistence();

var app = builder.Build();

//app.MapTarefasEndpoints();

app.Run();
