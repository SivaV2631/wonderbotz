using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemosController : ControllerBase
    {
        private static readonly string[] Summaries 
            = new[] {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", 
                "Balmy", "Hot", "Sweltering", "Scorching"
            };

        private readonly ILogger<DemosController> _logger;

        public DemosController(ILogger<DemosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route(template: "GetValues")]
        public IEnumerable<string> GetValues()
        {
            return new[] { "value1", "value2" };
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

    }
}
