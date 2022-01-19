using BenzoApp.Dtos;
using BenzoApp.Services;

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BenzoApp.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<FuelStationDto> FuelStations { get; set; }

        readonly IFuelStationService _fuelStationService;

        public event PropertyChangedEventHandler PropertyChanged;

        public HomeViewModel()
        {
        }

        public HomeViewModel(IFuelStationService fuelStationService) : this()
        {
            _fuelStationService = fuelStationService;
            InitData().Wait();
        }

        private async Task InitData()
        {
            var fuelStations = await _fuelStationService.GetAllFuelStations();
            FuelStations = new ObservableCollection<FuelStationDto>(fuelStations);
        }
    }
}
