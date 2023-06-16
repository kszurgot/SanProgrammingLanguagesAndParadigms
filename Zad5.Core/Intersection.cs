using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5.Core
{
    public class Intersection
    {
        public string Name
        {
            get => String.Join(" - ", _streets.Select(x => x.Name));
        }

        public IEnumerable<Street> Streets => _streets;

        private readonly HashSet<Street> _streets = new(); // The intersection can form N streets

        public Intersection(HashSet<Street> streets)
        {
            _streets = streets;

            foreach (var street in _streets)
            {
                street.AddIntersection(this);
            }
        }
        //public void AddStreet(Street addStreet)
        //{
        //    _streets.Add(addStreet);
        //}
    }
}
