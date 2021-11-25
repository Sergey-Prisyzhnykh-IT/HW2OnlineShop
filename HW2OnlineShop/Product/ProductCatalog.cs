namespace HW2OnlineShop
{
    public class ProductCatalog
    {
        public Dictionary<string, decimal> GetProductCatalog()
        {
            return productCatalocg;
        }

        Dictionary<string, decimal> productCatalocg = new Dictionary<string, decimal>
        {
            ["Куртка = "] = 1500m,
            ["Мяч = "] = 500.55m,
            ["Палатка = "] = 3500m
        };
    }
}
