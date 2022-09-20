using AutoSales.Data.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoSales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopCartController : ControllerBase
    {
        private static List<ShopCartItemDto> shopCarts = new List<ShopCartItemDto>();
       
        // GET: api/<ShopCartController>
        [HttpGet]
        public List<ShopCartItemDto> Get() => shopCarts;

        private int NextCarItemId => shopCarts.Count == 0 ? 1 : shopCarts.Max(x => x.Id) + 1;

        [HttpPost("AddCarItem")]
        public IActionResult Post(ShopCartItemDto car)
        {
            shopCarts.Add(new ShopCartItemDto { Id = NextCarItemId, Name = car.Name, Price = car.Price, Img = car.Img });
            return Ok();
        }

        //DELETE api/<ShopCartController>/5
        [HttpDelete]
        public IActionResult Delete([FromQuery] int id)
        {
            var shopCart = shopCarts.FirstOrDefault((p => p.Id == id));
            if (shopCart == null)
                return BadRequest();
            shopCarts.Remove(shopCart);
            return Ok();
        }
        
        [HttpDelete("AllDelete")]
        public IActionResult AllDelete()
        {          
            if (shopCarts == null)
                return BadRequest();
            shopCarts.Clear();
            return Ok();
        }
    }
}
