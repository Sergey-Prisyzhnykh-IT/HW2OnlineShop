using HW2OnlineShop;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Product product = new Product();

Dictionary<string, decimal> _product = new Dictionary<string, decimal>();
_product.Add("Куртка", 200);
_product.Add("Мяч", 150.20m);
_product.Add("Палатка", 1500);

var dataTime = DateTime.Now;




app.MapGet("/", () => "Hello World!");
app.MapGet("/catalog", () => product.ShowProduct(_product, dataTime).ToString());

app.Run();
