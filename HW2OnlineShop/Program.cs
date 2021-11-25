using HW2OnlineShop;
using HW2OnlineShop.Time;
using Microsoft.AspNetCore.Http.Json;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IRealTime, RealTime>();
builder.Services.AddSingleton<IProductCatalog, ProductCatalog>();

builder.Services.Configure<JsonOptions>(options => 
{ 
    options.SerializerOptions.WriteIndented = true; 
});


var app = builder.Build();





//app.MapGet("/", () => "Hello World!");

app.MapGet("/", (IProductCatalog product) => product.GetProductCatalog() );


app.Run();
