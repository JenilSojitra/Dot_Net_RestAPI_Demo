using DotNetRestAPIDemo.Interface;
using DotNetRestAPIDemo.Service;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddScoped<IProductService, ProductService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Add Swagger services And Update Docs Details
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Product API Demo",
        Version = "v1",
        Description = "This API provides a demonstration of basic product management functionalities,\n\n including creating, retrieving, updating, and deleting product records.\n\n The purpose of this demo is to showcase the structure and functionality\n\n of a RESTful API for managing product data.",
        Contact = new OpenApiContact
        {
            Name = "Jenil Sojitra",
            Email = "jenilsojitra19@gmail.com",
            Url = new Uri("https://jenilsojitra.github.io/portfolio")
        }
    });

});

var app = builder.Build();

app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Product API Demo");
        c.InjectStylesheet("/swagger-custom.css");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
