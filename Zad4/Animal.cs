using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    internal abstract class Animal
    {
        public virtual void Move()
        {
            Console.WriteLine("I'm moving.");
        }
    }
}
