using System.Windows;
using SoftwareMackFlightSimWPF.ViewModels;

namespace SoftwareMackFlightSimWPF.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
