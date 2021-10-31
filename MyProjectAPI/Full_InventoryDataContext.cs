using Project4_1.Items;         
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Project4API
{
    public class Full_InventoryDataContext
    {
       
        public static List<Product> TheInventory = new List<Product> {


           new ProductByQuantity("Frosted Flakes", "Breakfast Cereal", Guid.NewGuid(), 3.75, 0),
           new ProductByWeight ("Flour", "All purpose flour", Guid.NewGuid(),.15, 0 ),
           new ProductByQuantity("Bagels", "Whole Wheat", Guid.NewGuid(), 4.99, 0),
           new ProductByQuantity("Snickers Bar", "Candy", Guid.NewGuid(), 1.29, 0),
           new ProductByWeight("Walnuts", "Healthy Walnuts", Guid.NewGuid(), .30, 0),
           new ProductByWeight("Ground Beef", "USDA choice", Guid.NewGuid(), .35, 0),
           new ProductByQuantity("Sour Patch Kids", "Candy", Guid.NewGuid(), 1.78, 0),
           new ProductByQuantity("Altoids", "Mints", Guid.NewGuid(), 1.29, 0),
           new ProductByQuantity("Hershey Bar", "Chocolate Candy", Guid.NewGuid(), 5.48, 0),
           new ProductByWeight("Sugar", "Granulated Sugar", Guid.NewGuid(), .04, 0),
           new ProductByWeight("Coffee", "Ground Coffee", Guid.NewGuid(), .03, 0),
           new ProductByWeight("Frozen Yogurt", "A tasty treat", Guid.NewGuid(), .50, 0),
           new ProductByQuantity("Cheetos", "Cheesy Snack", Guid.NewGuid(), 4.17, 0),
           new ProductByQuantity("Sliced Bread", "Multigrain Bread", Guid.NewGuid(), 4.00, 0),
           new ProductByQuantity("Trail Mix", "Healthy Snack", Guid.NewGuid(), 6.48, 0),
           new ProductByQuantity("Bread Ice Cream", "Ice Cream", Guid.NewGuid(), 6.89, 0),
           new ProductByWeight("Crème Fraîche", "Pairs with fruit", Guid.NewGuid(), .27, 0),
           new ProductByWeight("Cultured Butter", "Made by hand", Guid.NewGuid(), .20, 0),
           new ProductByWeight("Kale", "organic kale", Guid.NewGuid(), .37, 0),
           new ProductByWeight("Asparagus", "organic asparagus ", Guid.NewGuid(), .12, 0),

    };

    }
}