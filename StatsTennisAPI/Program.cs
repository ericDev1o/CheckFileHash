//global using Xunit;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Builder;
global using System.Text.Json;
global using System.IO;
global using StatsTennisAPI.Controllers;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.DependencyInjection;
global using System.Diagnostics.CodeAnalysis;
namespace StatsTennisAPI;

public partial class Program
{
    public static void Main()
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder();
        // Add services to the container.
        builder.Services.AddControllers();
        //builder.Services.AddEndpointsApiExplorer();
        //builder.Services.AddSingleton<>();
        builder.Services.AddSwaggerGen();
        var app = builder.Build();
        // Configure the HTTP request pipeline.
        /*if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();*/
        app.Run();
        /*using (ILoggerFactory lf = new LoggerFactory())
        {
        }*/
        ILoggerFactory lf = new LoggerFactory();
        //ILoggerProvider lp = new LoggerProvider
        ILogger<StatsTennisAPIController> l = lf.CreateLogger<StatsTennisAPIController>();
        StatsTennisAPIController stac = new StatsTennisAPIController(l);
        Task<IEnumerable<TennisPlayer>> res = stac.Get(@"C:\Users\Public\Documents\LAtelierTestBackEnd\dataset.json");
    }
}