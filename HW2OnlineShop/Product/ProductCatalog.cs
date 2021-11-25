namespace HW2OnlineShop
{
    public class ProductCatalog : IProductCatalog
    {
        private readonly IReadOnlyCollection<Product> _products = new Product[]
        {
            new ("Куртка", 1000m),
            new ("Палатка", 25000m),
            new ("Футболка", 100m),
        };

        public IReadOnlyCollection<Product> GetProductCatalog()
        {
            if (DateTime.UtcNow.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
                return _products.Select(it => it with { Price = it.Price * 1.5m }).ToList();
            else
                return _products;

        }
    }
}
