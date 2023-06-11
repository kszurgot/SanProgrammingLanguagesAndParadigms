using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    internal class Bird : Animal
    {
        public override void Move()
        {
            Console.WriteLine("I'm flying.");
        }
    }
}
