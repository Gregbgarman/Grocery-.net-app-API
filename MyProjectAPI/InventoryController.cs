using Microsoft.AspNetCore.Mvc;
using Project4_1.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Project4API
{
    
    [ApiController]
    [Route("Product")]
    public class InventoryController : ControllerBase
    {

        [HttpGet("GetAll")]         //only used for testing purposes-client doesn't call this
        public ActionResult<List<Product>> Get()
        {
            return Ok(Full_InventoryDataContext.TheInventory);
        }


        [HttpGet("GetProductsByQuantity")]      //returns all products measured by quantity
        public ActionResult<List<ProductByQuantity>> getproductsbyquantity()
        {
            return Ok(ProductByQuantityContext.TheInventory);
        }


        [HttpGet("GetProductsByWeight")]    //returns all products measured by weight
        public ActionResult<List<Product>> getproductsbyweight()
        {
            return Ok(ProductByWeightContext.TheInventory);
        }

        

    }
}

