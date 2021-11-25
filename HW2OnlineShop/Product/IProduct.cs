using System.Collections.Generic;
using System.Text;

namespace HW2OnlineShop
{
    public interface IProduct
    {
        StringBuilder ShowProduct(Dictionary<string, decimal> product, DateTime dateTime);

    }
}
