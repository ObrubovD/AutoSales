using AutoSales.Data.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoSales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopCartController : BaseController
    {
        [HttpGet]
        public List<CarDto> Get() => shopCarts;

        [HttpPost("AddCarItem")]
        public IActionResult Post(CarDto car)
        {
            shopCarts.Add(new CarDto { Id = NextCarItemId, Name = car.Name, Price = car.Price, Img = car.Img });
            return Ok();
        }

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
