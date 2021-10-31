using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project4_1.Items;

namespace Project4API
{
    public class ProductByQuantityContext
    {
        public static List<ProductByQuantity> TheInventory = new List<ProductByQuantity>
        {
        new ProductByQuantity("FROSTED FLAKES", "cereal", Guid.NewGuid(), 3.75, 0),
        new ProductByQuantity("BAGELS", "whole wheat", Guid.NewGuid(), 4.99, 0),
        new ProductByQuantity("SNICKERS BAR", "candy", Guid.NewGuid(), 1.29, 0),
        new ProductByQuantity("SOUR PATCH KIDS", "candy", Guid.NewGuid(), 1.78, 0),
        new ProductByQuantity("SKITTLES", "candy", Guid.NewGuid(), 1.29, 0),
        new ProductByQuantity("HERSHEY BAR", "chocolate candy", Guid.NewGuid(), 5.48, 0),
        new ProductByQuantity("CHEETOS", "snack", Guid.NewGuid(), 4.17, 0),
        new ProductByQuantity("SLICED BREAD", "whole wheat", Guid.NewGuid(), 4.00, 0),
        new ProductByQuantity("TRAIL MIX", "snack", Guid.NewGuid(), 6.48, 0),
        new ProductByQuantity("OREO ICE CREAM", "candy", Guid.NewGuid(), 6.89, 0),

        };
    }
}
