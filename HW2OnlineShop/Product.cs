using System.Text;

namespace HW2OnlineShop
{
    public class Product : IProduct
    {


        public StringBuilder ShowProduct (Dictionary<string, decimal> product, DateTime dateTime)
        {
            StringBuilder showProduct = new StringBuilder();

            if (dateTime.DayOfWeek == DayOfWeek.Sunday || dateTime.DayOfWeek == DayOfWeek.Saturday)
                foreach (var pr in product)
                    showProduct.Append(pr.Key + pr.Value * 1.5m + "\n");
            else
                foreach (var pr in product)
                    showProduct.Append(pr.Key + pr.Value + "\n");

            return showProduct;



        }
    }
}
