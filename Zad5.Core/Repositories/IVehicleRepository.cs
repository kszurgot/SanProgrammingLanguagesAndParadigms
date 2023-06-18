using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5.Core.Repositories
{
    public interface IVehicleRepository
    {
        IEnumerable<IVehicle> GetAll();
    }
}
