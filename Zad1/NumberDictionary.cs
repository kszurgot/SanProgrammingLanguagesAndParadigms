using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    internal static class NumberDictionary
    {
        public static Dictionary<int, string> Units { get; private set; } = new()
        {
            { 1, "jeden" },
            { 2, "dwa" },
            { 3, "trzy" },
            { 4, "cztery" },
            { 5, "pięć" },
            { 6, "sześć" },
            { 7, "siedem" },
            { 8, "osiem" },
            { 9, "dziewięć" }
        };

        public static Dictionary<int, string> Teen { get; private set; } = new ()
        {
            { 1, "jedenaście" },
            { 2, "dwanaście" },
            { 3, "trzynaście" },
            { 4, "czternaście" },
            { 5, "piętnaście" },
            { 6, "szesnaście" },
            { 7, "siedemnaście" },
            { 8, "osiemnaście" },
            { 9, "dziewietnaście" }
        };

        public static Dictionary<int, string> Tens { get; private set; } = new()
        {
            { 1, "dziesięć" },
            { 2, "dwadzieścia" },
            { 3, "trzydzieści" },
            { 4, "czterdzieści" },
            { 5, "pięćdziesiąt" },
            { 6, "sześćdziesiąt" },
            { 7, "siedemdziesiąt" },
            { 8, "osiemdziesiąt" },
            { 9, "dziewięćdziesiąt" }
        };

        public static Dictionary<int, string> Hundred { get; private set; } = new()
        {
            { 1, "sto" },
            { 2, "dwieście" },
            { 3, "trzysta" },
            { 4, "czterysta" },
            { 5, "pięćset" },
            { 6, "sześćset" },
            { 7, "siedemset" },
            { 8, "osiemset" },
            { 9, "dziewięćset" }
        };

        public static Dictionary<int, string> Thousands { get; private set; } = new()
        {
            {1, "tysiąc" },
            {2, "tysiące" },
            {3, "tysiące" },
            {4, "tysiące" },
            {5, "tysiący" },
            {6, "tysiący" },
            {7, "tysiący" },
            {8, "tysiący" },
            {9, "tysiący" }
        };
    }
}
