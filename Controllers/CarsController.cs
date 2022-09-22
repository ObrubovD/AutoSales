using AutoSales.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoSales.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarsController : BaseController
    {
        [HttpGet]
        public List<CarDto> GetCars() => cars;
    }
}


