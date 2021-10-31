using HWProject3.Items;         //added
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
                                    this should be red 
namespace Project4API
{
    public class DataContext
    {
        public static List<Product> TheInventory = new List<Product> {
           // new SupportTicket { Title = "First Ticket", Description = "First Description", Id = Guid.NewGuid()},
           // new SupportTicket { Title = "Second Ticket", Description = "Second Description" , Id = Guid.NewGuid()},
          //  new SupportTicket { Title = "Third Ticket", Description = "Third Description", Id = Guid.NewGuid()},
          //  new SupportTicket { Title = "Fourth Ticket", Description = "Fourth Description", Id = Guid.NewGuid()},

               new ProductByQuantity { name="Frosted Flakes", Description="Breakfast Cereal", ID=123, UnitPrice=3.75, Units=0,Id =Guid.NewGuid() },
               new ProductByWeight { name = "Flour", Description="All purpose flour", ID = 741,PricePerOunce= .15, Ounces = 0,Id =Guid.NewGuid() },

        /*
                Inventory.Add(new ProductByQuantity("Bagels", "Whole Wheat", 145, 4.99, 0));
                Inventory.Add(new ProductByQuantity("Snickers Bar", "Candy", 478, 1.29, 0));
               
                Inventory.Add(new ProductByWeight("Walnuts", "Healthy Walnuts", 756, .30, 0));
                Inventory.Add(new ProductByWeight("Ground Beef", "USDA choice", 834, .35, 0));
                Inventory.Add(new ProductByQuantity("Sour Patch Kids", "Candy", 497, 1.78, 0));
                Inventory.Add(new ProductByQuantity("Altoids", "Mints", 419, 1.29, 0));
                Inventory.Add(new ProductByQuantity("Hershey Bar", "Chocolate Candy", 456, 5.48, 0));
                Inventory.Add(new ProductByWeight("Sugar", "Granulated Sugar", 777, .04, 0));
                Inventory.Add(new ProductByWeight("Coffee", "Ground Coffee", 245, .03, 0));
                Inventory.Add(new ProductByWeight("Frozen Yogurt", "A tasty treat", 444, .50, 0));
                Inventory.Add(new ProductByQuantity("Cheetos", "Cheesy Snack", 189, 4.17, 0));
                Inventory.Add(new ProductByQuantity("Sliced Bread", "Multigrain Bread", 155, 4.00, 0));
                Inventory.Add(new ProductByQuantity("Trail Mix", "Healthy Snack", 177, 6.48, 0));
                Inventory.Add(new ProductByQuantity("Bread Ice Cream", "Ice Cream", 436, 6.89, 0));
                Inventory.Add(new ProductByWeight("Crème Fraîche", "Pairs with fruit", 479, .27, 0));
                Inventory.Add(new ProductByWeight("Cultured Butter", "Made by hand", 461, .20, 0));
                Inventory.Add(new ProductByWeight("Kale", "organic kale", 256, .37, 0));
                Inventory.Add(new ProductByWeight("Asparagus", "organic asparagus ", 207, .12, 0));
        */

    };
    }
}
