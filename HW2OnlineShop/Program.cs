using HW2OnlineShop;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Product product = new Product();

var productCatalog = new ProductCatalog().GetProductCatalog();

var dataTime = DateTime.Now;


app.MapGet("/", () => "Hello World!");

app.MapGet("/catalog", () => product.ShowProduct(productCatalog, dataTime).ToString());

app.Run();
