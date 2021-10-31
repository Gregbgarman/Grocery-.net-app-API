using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project4_1.Items;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace Project4API
{

    [ApiController]
    [Route("shoppingcart")]
    public class ShoppingCartController : ControllerBase
    {

        [HttpGet("Testing")]
        public ActionResult<List<Product>> Get()
        {
            
            return Ok(ShoppingCartContext.TheShoppingCart);
        }

        [HttpGet("GetCartItemsByWeight")]
        public ActionResult<ObservableCollection<ProductByWeight>> GetCartItemsByWeight()
        {
            ObservableCollection<ProductByWeight> pbw = new ObservableCollection<ProductByWeight>();
            for (int i = 0; i < ShoppingCartContext.TheShoppingCart.Count; i++)
                if (ShoppingCartContext.TheShoppingCart[i].isByWeight())
                    pbw.Add((ProductByWeight)ShoppingCartContext.TheShoppingCart[i]);

            return Ok(pbw);
        }

        [HttpGet("GetCartItemsByQuantity")]
        public ActionResult<ObservableCollection<ProductByQuantity>> GetCartItemsByQuantity()
        {
            ObservableCollection<ProductByQuantity> pbq = new ObservableCollection<ProductByQuantity>();
            for (int i = 0; i < ShoppingCartContext.TheShoppingCart.Count; i++)
                if (!ShoppingCartContext.TheShoppingCart[i].isByWeight())
                    pbq.Add((ProductByQuantity)ShoppingCartContext.TheShoppingCart[i]);

            return Ok(pbq);

        }

        [HttpPost("ClearCart")]
        public ActionResult<int> ClearCart([FromBody] int placeholder)      //cart is cleared via clear() on client
        {
            ShoppingCartContext.TheShoppingCart.Clear();
            return Ok(placeholder);

        }
        

        [HttpPost("AddItemByWeight")]
        public ActionResult<ProductByWeight> AddItemByWeight([FromBody] ProductByWeight pbw)   
        {

            ShoppingCartContext.TheShoppingCart.Add(new ProductByWeight(pbw.Name,pbw.Description, pbw.ID, pbw.getUnitPrice(),0.1));
            pbw.Ounces = 0.1;       
            return Ok(pbw);

        }

        [HttpPost("AddItemByQuantity")]
        public ActionResult<ProductByQuantity> AddItemByQuantity([FromBody] ProductByQuantity pbq)
        {
            ShoppingCartContext.TheShoppingCart.Add(new ProductByQuantity(pbq.Name, pbq.Description, pbq.ID, pbq.getUnitPrice(), 1));
            pbq.Units = 1;      
            return Ok(pbq);

        }

        [HttpPost("IncrementItem")]     
        public ActionResult<Product> IncrementProduct([FromBody] int index)     
        {
            Product product;    
            if (ShoppingCartContext.TheShoppingCart[index].isByWeight())
            {
           
                ShoppingCartContext.TheShoppingCart[index].ModifyQuantity(0.1);
                product = ShoppingCartContext.TheShoppingCart[index];           
            }

            else {
                ShoppingCartContext.TheShoppingCart[index].ModifyQuantity((double)1);
                product = ShoppingCartContext.TheShoppingCart[index];       
            }

            
            return Ok(product);        //returning product to increment
        }

        [HttpPost("DecrementItem")]
        public ActionResult<Product> DecrementProduct([FromBody] int index)
        {
            Product p;

            if (ShoppingCartContext.TheShoppingCart[index].isByWeight())
            {
                ShoppingCartContext.TheShoppingCart[index].ModifyQuantity(-0.1);
                p = ShoppingCartContext.TheShoppingCart[index];     
            }

            else
            {
                ShoppingCartContext.TheShoppingCart[index].ModifyQuantity((double)-1);
                p = ShoppingCartContext.TheShoppingCart[index];     
            }

            return Ok(p);           //returning the product to decrement

        }

        [HttpPost("RemoveItem")]
        public ActionResult<Product> RemoveItem([FromBody] int index)               
        {
            Product p = ShoppingCartContext.TheShoppingCart[index];
            ShoppingCartContext.TheShoppingCart.RemoveAt(index);    

            
            return Ok(p);       //returning the product to delete

        }

        [HttpGet("GetReceipt")]
        public ActionResult<string> GetReceipt()        //returning receipt as one big string
        {
            string TheReceipt;
            if (ShoppingCartContext.TheShoppingCart.Count == 0)
            {
                TheReceipt="***No items purchased***";
                return Ok(TheReceipt);
            }

            double subtotal = 0;
            for (int i = 0; i < ShoppingCartContext.TheShoppingCart.Count; i++)
            {
                double price = ShoppingCartContext.TheShoppingCart[i].Price;

                if (ShoppingCartContext.TheShoppingCart[i].Price < 1)
                    price *= 10;

                subtotal = subtotal + price;
            }


            TheReceipt ="***Online Grocery Store Receipt***\n";
            TheReceipt+=(String.Format("{0,-32}{1,-10}", "\nItem", "Price\n"));

            for (int i = 0; i < ShoppingCartContext.TheShoppingCart.Count; i++)
            {
                if (ShoppingCartContext.TheShoppingCart[i].isByWeight())
                    TheReceipt+=(String.Format("\n{0,-30}{1,-1}{2,-10:0.00}", ShoppingCartContext.TheShoppingCart[i].Name, "$", ShoppingCartContext.TheShoppingCart[i].Price * 10));
                else
                    TheReceipt+=(String.Format("\n{0,-30}{1,-1}{2,-10:0.00}", ShoppingCartContext.TheShoppingCart[i].Name, "$", ShoppingCartContext.TheShoppingCart[i].Price));

            }

            TheReceipt+="\n---------------------------------------------------";
            TheReceipt += (String.Format("\n{0,-25}{1,-1}{2,-10:0.00}", "Subtotal(Before Taxes)", "$", subtotal));
            TheReceipt += (String.Format("\n{0,-25}{1,-1}{2,-10:0.00}", "Sales Tax", "$", (subtotal * .07)));
            TheReceipt += (String.Format("\n{0,-25}{1,-1}{2,-10:0.00}", "Final Amount", "$", (subtotal * 1.07)));

            return Ok(TheReceipt);
        }

    }
}
