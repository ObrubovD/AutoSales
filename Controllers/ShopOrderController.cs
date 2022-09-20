using AutoSales.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoSales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopOrderController : ControllerBase
    {
        private static List<ShopOrderDto> shopCarts = new List<ShopOrderDto>();

        private int NextCarItemId => shopCarts.Count == 0 ? 1 : shopCarts.Max(x => x.Id) + 1;

        [HttpPost]
        public IActionResult Post([FromBody] ShopOrderDto shopOrder)
        {
            shopCarts.Add(new ShopOrderDto {Id=NextCarItemId,Name= shopOrder.Name,SurName= shopOrder.SurName,Phone= shopOrder.Phone, Email= shopOrder.Email });
            return Ok();
        }

    }
}
