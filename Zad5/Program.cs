using Zad5.Application;
using Zad5.Core;
using Zad5.Infrastructure;

namespace Zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var appContainer = AppContainer.GetInstance()
                .LoadRepositories()
                .AddApplicationLayer();
            var streets = appContainer.Streets();
            var vehicleLocations = appContainer.VehicleLocationService;
        }
    }
}