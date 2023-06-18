using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad5.Application.Services;
using Zad5.Core;

namespace Zad5.Application
{
    public static class Extensions
    {
        public static AppContainer AddApplicationLayer(this AppContainer application)
        {
            application.VehicleLocationService = new VehicleLocationService(
                application.VehicleLocationRepository,
                application.VehicleRepository);

            return application;
        }
    }
}
