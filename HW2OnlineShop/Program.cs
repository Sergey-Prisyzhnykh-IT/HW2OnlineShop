using HW2OnlineShop;
using HW2OnlineShop.Time;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<RealTime>();

var app = builder.Build();


Product product = new Product();

var productCatalog = new ProductCatalog().GetProductCatalog();

var dataTime = DateTime.Now;


app.MapGet("/", () => "Hello World!");

app.MapGet("/catalog", () => product.ShowProduct(productCatalog, dataTime).ToString());

app.MapGet("/lifetime", (RealTime realTime) => realTime.GetRealTime().ToShortTimeString());

app.Run();
