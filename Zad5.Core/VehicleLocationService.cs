﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad5.Core.Repositories;

namespace Zad5.Core
{
    public class VehicleLocationService
    {
        private readonly HashSet<Street> _vehicleLocations = new();
        public VehicleLocationService(IVehicleLocationRepository vehicleLocations)
        {

        }
    }
}
