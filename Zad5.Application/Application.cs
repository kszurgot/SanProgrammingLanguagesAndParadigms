using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad5.Application.Services;
using Zad5.Core.Repositories;

namespace Zad5.Application
{
    public sealed class AppContainer
    {
        public IVehicleLocationRepository VehicleLocationRepository { get; set; }
        public IVehicleRepository VehicleRepository { get; set; }
        public VehicleLocationService VehicleLocationService { get; set; }
        private AppContainer() { }

        private static AppContainer? _instance;

        public static AppContainer GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AppContainer();
            }

            return _instance;
        }
    }
}
