using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad5.Core;
using Zad5.Core.Repositories;
using Zad5.Application;
using Zad5.Infrastructure.DAL.Repositories;

namespace Zad5.Infrastructure
{
    public static class Extensions
    {
        private static DatabaseInitializer _dbInitializer = new();

        // Should be another repo
        public static List<District> Districts(this AppContainer application)
        {
            return _dbInitializer.Districts;
        }

        public static List<Street> Streets(this AppContainer application)
        {
            return _dbInitializer.Streets;
        }

        public static List<Intersection> Intersection(this AppContainer application)
        {
            return _dbInitializer.Intersections;
        }

        public static List<IVehicle> Vehicles(this AppContainer application)
        {
            return _dbInitializer.Vehicles;
        }

        public static AppContainer LoadRepositories(this AppContainer application)
        {
            application.VehicleLocationRepository = new InMemoryVehicleLocationRepository(_dbInitializer.VehicleLocations);

            return application;
        }
    }
}
