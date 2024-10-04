using Microsoft.AspNetCore.Mvc;
using SoftwareMackFlightSimBackend.Models;
using SoftwareMackFlightSimBackend.Services;

namespace SoftwareMackFlightSimBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly SimulationService _simulationService;

        public WeatherController(SimulationService simulationService)
        {
            _simulationService = simulationService;
        }

        [HttpPost("wind")]
        public IActionResult UpdateWindSpeed([FromBody] WindSpeedUpdate windSpeedUpdate)
        {
            _simulationService.UpdateWindSpeed(windSpeedUpdate);
            return Ok();
        }

        [HttpGet("wind-updates")]
        public IActionResult GetWindUpdates()
        {
            var updates = _simulationService.GetWindSpeedUpdates();
            return Ok(updates);
        }

        [HttpGet("flight-parameters")]
        public IActionResult GetFlightParameters()
        {
            var parameters = _simulationService.GetFlightParameters();
            return Ok(parameters);
        }
    }
}
