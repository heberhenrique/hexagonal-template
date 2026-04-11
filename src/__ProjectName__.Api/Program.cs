
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using __ProjectName__.Application.Ports.Input;
using __ProjectName__.Application.Ports.Output;
using __ProjectName__.Application.UseCases;
using __ProjectName__.Infrastructure.Adapters;


var builder = WebApplication.CreateBuilder(args);

// MVC
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Application
builder.Services.AddScoped<IGetExampleUseCase, GetExampleUseCase>();

// Infrastructure
builder.Services.AddScoped<IExampleRepository, ExampleRepository>();

var app = builder.Build();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
