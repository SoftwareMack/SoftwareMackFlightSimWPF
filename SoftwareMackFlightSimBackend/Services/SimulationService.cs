using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SoftwareMackFlightSimBackend.Data;
using SoftwareMackFlightSimBackend.Models;

namespace SoftwareMackFlightSimBackend.Services
{
    public class SimulationService
    {
        private readonly AppDbContext _context;

        public SimulationService(AppDbContext context)
        {
            _context = context;
        }


        public void UpdateWindSpeed(WindSpeedUpdate windSpeedUpdate)
        {
            _context.WindSpeedUpdates.Add(windSpeedUpdate);
            var windParam = _context.FlightParameters.FirstOrDefault(p => p.Name == "Wind Speed");
            if (windParam != null)
            {
                windParam.Value = windSpeedUpdate.WindSpeed;
            }
            _context.SaveChanges();
        }

        public List<WindSpeedUpdate> GetWindSpeedUpdates()
        {
            return _context.WindSpeedUpdates.ToList();
        }

        public List<FlightParameter> GetFlightParameters()
        {
            return _context.FlightParameters.ToList();
        }

        public void UpdateFlightParameter(string parameterName, double newValue)
        {
            var flightParameter = _context.FlightParameters.FirstOrDefault(p => p.Name == parameterName);
            if (flightParameter != null)
            {
                flightParameter.Value = newValue;
                _context.SaveChanges();
            }
        }

internal class Context
    {
    }



    }
}
