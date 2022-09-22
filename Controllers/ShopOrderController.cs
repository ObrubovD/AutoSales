using AutoSales.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoSales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopOrderController : BaseController
    {

        [HttpPost]
        public IActionResult Post([FromBody] ShopOrderDto shopOrder)
        {
            shopOrders.Add(new ShopOrderDto {Id= NextCarItemIdOrder, Name= shopOrder.Name,SurName= shopOrder.SurName,Phone= shopOrder.Phone, Email= shopOrder.Email });
            return Ok();
        }

    }
}
