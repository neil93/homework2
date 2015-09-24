using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        public double CalcuatePrice(List<CartDetail> details)
        {
            //todo 
            Dictionary<string, int> groupbyName = details.GroupBy(n => n.ProductName)
                .ToDictionary(o => o.Key, o => o.Sum(s => s.Amount));
                

            
            return 0;
        }
    }
}
