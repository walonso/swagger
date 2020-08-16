using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webApiSwagger.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get WeatherForecast.
        /// </summary>
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    
        /// <summary>
        /// Delete WeatherForecast by Id.
        /// </summary>        
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            return NoContent();
        }

        /// <summary>
        /// Creates a WeatherForecast.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /WeatherForecast
        ///     {
        ///        "id": 1,
        ///        "Summary": "Item1",
        ///        "TemperatureC": 5
        ///     }
        ///
        /// </remarks>
        /// <param name="weatherForecast"></param>
        /// <returns>A newly created weatherForecast</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>     
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(WeatherForecast weatherForecast)
        {
            return NoContent();
        }
    }
}
