using Microsoft.AspNetCore.Mvc;
using WebCar.Common.Models;
using WebCar.WebApp._2_Services.ServiceInterfaces;

namespace WebCar.WebApp._1_WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/SearchMovies")]
    public class CarController : Controller
    {
        private ICar iCar;
        public CarController(ICar _iCar)
        {
            iCar = _iCar;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<CarModel>))]
        public async Task<IActionResult> Get(CarSearchingParameters carSearchingParameters)
        {
            var movies = await iCar.SearchCarAsync(carSearchingParameters);

            if (movies == null || !movies.Any())
            {
                return NotFound();
            }

            return Json(movies);
        }

    }
}