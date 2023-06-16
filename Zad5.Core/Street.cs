using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5.Core
{
    public class Street
    {
        public string Name { get; private set; }
        public District District { get; private set; }

        public IEnumerable<Intersection> Intersections => _intersection;

        private readonly HashSet<Intersection> _intersection = new(); // The intersection can form N streets

        public Street(string name, District district)
        {
            Name = name;
            District = district;
        }

        public void AddIntersection(Intersection intersection)
        {
            _intersection.Add(intersection);
        }
    }
}
