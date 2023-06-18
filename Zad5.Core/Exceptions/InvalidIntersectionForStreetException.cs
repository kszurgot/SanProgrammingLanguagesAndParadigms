using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad5.Core.Shared.Exceptions;

namespace Zad5.Core.Exceptions
{
    internal class InvalidIntersectionForStreetException : CustomException
    {
        public string Intersection { get; }
        public string Street { get; }

        public InvalidIntersectionForStreetException(string intersection, string street)
            : base($"Skrzyżowanie {intersection} jest nieprawidłowe dla ulicy {street}.")
        {
            Intersection = intersection;
            Street = street;
        }
    }
}
