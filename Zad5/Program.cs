using Zad5.Application;
using Zad5.Core.Shared.Exceptions;
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

            var vehicleLocationsService = appContainer.VehicleLocationService;

            while (true)
            {
                Console.WriteLine("Podaj numer rejestracyjny pojazdu do wyszukania lokalizacji.");
                Console.WriteLine("Jeżeli chcesz zakończyć dzialanie programu wciśnij 'C'");
                var input = Console.ReadLine();

                if (input.ToUpper() == "C")
                {
                    break;
                }

                try
                {
                    var vehicleLocation = vehicleLocationsService.GetVehicleLocation(input);
                    Console.WriteLine("Pojazd znajduje sie na ulicy {0} przed skrzyżowaniem {1} na dzielnicy {2}",
                        vehicleLocation?.Street.Name,
                        vehicleLocation?.BeforeIntersection.Name,
                        vehicleLocation?.Street.District.Name);
                }
                catch (CustomException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}