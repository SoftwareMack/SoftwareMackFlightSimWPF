using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System.Collections.ObjectModel;
using SoftwareMackFlightSimWPF.Models;

namespace SoftwareMackFlightSimWPF.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<FlightParameter> FlightParameters { get; set; }

        public ObservableCollection<ISeries> WindSpeedSeries { get; set; }
        public ObservableCollection<ISeries> AltitudeSeries { get; set; }

        public MainViewModel()
        {
            FlightParameters = new ObservableCollection<FlightParameter>
            {
                new FlightParameter { Id = 1, Name = "Altitude", Value = 30000, Unit = "Feet" },
                new FlightParameter { Id = 2, Name = "Speed", Value = 550, Unit = "Knots" },
                new FlightParameter { Id = 3, Name = "Wind Speed", Value = 10, Unit = "MPH" }
            };

            WindSpeedSeries = new ObservableCollection<ISeries>
            {
                new LineSeries<double>
                {
                    Values = new ObservableCollection<double> { 10, 12, 14, 15, 20 },
                    Name = "Wind Speed"
                }
            };

            AltitudeSeries = new ObservableCollection<ISeries>
            {
                new LineSeries<double>
                {
                    Values = new ObservableCollection<double> { 30000, 31000, 32000, 33000, 34000 },
                    Name = "Altitude"
                }
            };
        }
    }
}
