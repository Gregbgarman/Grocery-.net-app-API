using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project4_1.Items;

namespace Project4API
{
    public class ProductByWeightContext
    {
        public static List<ProductByWeight> TheInventory = new List<ProductByWeight>
        {

            
        new ProductByWeight ("FLOUR", "all purpose flour", Guid.NewGuid(),.15, 0 ),
        new ProductByWeight("WALNUTS", "snack", Guid.NewGuid(), .30, 0),
        new ProductByWeight("GROUND BEEF", "choice", Guid.NewGuid(), .35, 0),
        new ProductByWeight("SUGAR", "granulated sugar", Guid.NewGuid(), .04, 0),
        new ProductByWeight("COFFEE", "ground coffee", Guid.NewGuid(), .03, 0),
        new ProductByWeight("FROZEN YOGURT", "candy", Guid.NewGuid(), .50, 0),
        new ProductByWeight("CREME FRAICHE", "pairs with fruit", Guid.NewGuid(), .27, 0),
        new ProductByWeight("BUTTER", "low fat", Guid.NewGuid(), .20, 0),
        new ProductByWeight("KALE", "organic", Guid.NewGuid(), .37, 0),
        new ProductByWeight("ASPARAGUS", "organic", Guid.NewGuid(), .12, 0),


        };

    }
}
