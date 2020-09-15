using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MRE.Repo;

namespace MRE.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly Repo.Repo _repository;

        public WeatherForecastController(Repo.Repo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await _repository.GetWeatherForecast();
        }
    }
}
