using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareMackFlightSimBackend.Controllers;
using SoftwareMackFlightSimBackend.Data;
using SoftwareMackFlightSimBackend.Models;
using SoftwareMackFlightSimBackend.Services;
using System.Collections.Generic;
using Xunit;

public class WeatherControllerTests
{
    private readonly WeatherController _controller;
    private readonly SimulationService _service;

    public WeatherControllerTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>();



        var context = new AppDbContext(options);
        _service = new

        SimulationService(context);
        _controller = new WeatherController(_service);
    }

    private object UseInMemoryDatabase(string databaseName)
    {
        throw new NotImplementedException();
    }

    [Fact]
    public void GetFlightParameters_ReturnsOkResult()
    {
        var result = _controller.GetFlightParameters();
        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public void UpdateWindSpeed_ValidObject_ReturnsOkResult()
    {
        var windSpeedUpdate = new WindSpeedUpdate { WindSpeed = 25 };
        var result = _controller.UpdateWindSpeed(windSpeedUpdate);
        Assert.IsType<OkResult>(result);
    }
}
