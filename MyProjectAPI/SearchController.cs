using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project4_1.Items;
using System.Collections.ObjectModel;

namespace Project4API
{
    [ApiController]
    [Route("Search")]
    public class SearchController : ControllerBase
    {

        [HttpPost("SearchQuantityItems")]       //returning items matching user search that are measured by quantity
        public ActionResult<ObservableCollection<ProductByQuantity>> SearchQuantityItems([FromBody] string UserSearch)
        {
            ObservableCollection<ProductByQuantity> pbq = new ObservableCollection<ProductByQuantity>();
            String UpperSearchName = UserSearch.ToUpper();
            String LowerSearchDesc = UserSearch.ToLower();

            for (int i = 0; i < ProductByQuantityContext.TheInventory.Count; i++)
            {
                if (ProductByQuantityContext.TheInventory[i].Name == UpperSearchName || ProductByQuantityContext.TheInventory[i].Description == LowerSearchDesc)
                {
                    pbq.Add(ProductByQuantityContext.TheInventory[i]);
                }

            }

            return Ok(pbq);

        }

        [HttpPost("SearchWeightedItems")]   //returning items matching user search that are measured by weight
        public ActionResult<ObservableCollection<ProductByWeight>> SearchWeightedItems([FromBody] string UserSearch)
        {
            ObservableCollection<ProductByWeight> pbw = new ObservableCollection<ProductByWeight>();
            String UpperSearch = UserSearch.ToUpper();

            for (int i = 0; i < ProductByWeightContext.TheInventory.Count; i++)
            {
                if (ProductByWeightContext.TheInventory[i].Name == UpperSearch || ProductByWeightContext.TheInventory[i].Description == UserSearch)
                {
                    pbw.Add(ProductByWeightContext.TheInventory[i]);
                }

            }

            return Ok(pbw);

        }

    }
}
