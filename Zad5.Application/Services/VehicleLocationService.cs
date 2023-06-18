using Zad5.Application.Exceptions;
using Zad5.Core;
using Zad5.Core.Repositories;

namespace Zad5.Application.Services
{
    public class VehicleLocationService
    {
        public string Name { get; init; }
        private readonly IVehicleLocationRepository _vehicleLocationRepository;
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleLocationService(IVehicleLocationRepository vehicleLocationRepository, IVehicleRepository vehicleRepository)
        {
            _vehicleLocationRepository = vehicleLocationRepository;
            _vehicleRepository = vehicleRepository;
        }

        public VehicleLocation? GetVehicleLocation(string licensePlate)
        {
            var vehicle = _vehicleRepository.GetAll().FirstOrDefault(x => x.LicensePlate == licensePlate);

            if (vehicle == null) 
            {
                throw new VehicleNotFoundException(licensePlate);            
            }

            return _vehicleLocationRepository.FindByVehicle(vehicle);
        }
    }
}