using AutoSales.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoSales.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private static List<CarDto> cars = new List<CarDto>{
                    new CarDto {
                        Id=1,
                        Name = "Mitsubishi Lancer X",
                        Img = "https://driveboom.ru/gallery/mitsubishi/photo/mitsubishi-lancer-4-door-2007-2010-18538sm.jpeg",
                        Price = 25000,
                    },
                    new CarDto
                    {
                        Id=2,
                        Name = "Toyota Corolla",
                        Img = "https://sun9-85.userapi.com/s/v1/if1/S-xsGP6g4OeL2clZHNjBxTWaLCtkhW7Ut23THkqgjq1c7ltKDpkV0M4tfSFBD7HE4N1feLwy.jpg?size=604x453&quality=96&type=album",
                        Price = 24000,
                    },
                    new CarDto
                    {
                        Id =3,
                        Name = "Nissan Teana",
                        Img = "https://kuznitsaspb.ru/wp-content/uploads/e/a/8/ea8ffb837c8241b3f8042fb40b2c3927.jpeg",
                        Price = 32000,
                    },
                     new CarDto
                    {
                        Id=4,
                        Name = "Ford Fiesta",
                        Img = "https://imarka.ru/user/catalog/models/52581.jpg",
                        Price = 28000,
                    },
                      new CarDto
                    {
                        Id=5,
                        Name = "Chevrolet Cruze ",
                        Img = "https://a.d-cd.net/xIAAAgCAJ-A-960.jpg",
                        Price = 30000,
                    },
                       new CarDto
                    {
                        Id=6,
                        Name = "Mazda 3",
                        Img = "https://www.autooptica.ru/uploads/20210105/mazda-3-(1)_crop.jpg",
                        Price = 22000,
                    },
                };
        [HttpGet]
        public IEnumerable<CarDto> GetCars() => cars;
    }
}


