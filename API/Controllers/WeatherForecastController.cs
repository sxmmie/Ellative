using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        /*private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };*/

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly DataContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> Get()
        {
            var weathers = await _context.WeatherForecasts.ToListAsync();

            return Ok(weathers);
        }

        [HttpGet]
        public async Task<ActionResult<WeatherForecast>> Get(int id)
        {
            var weather = await _context.WeatherForecasts.FindAsync(id);

            return Ok(weather);
        }

        /*
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
                }*/
    }
}
