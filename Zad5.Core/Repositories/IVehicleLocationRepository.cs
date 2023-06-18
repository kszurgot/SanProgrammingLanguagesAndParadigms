using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5.Core.Repositories
{
    public interface IVehicleLocationRepository
    {
        IEnumerable<VehicleLocation> GetAll();
        VehicleLocation? FindByVehicle(IVehicle vehicle); 
    }
}
