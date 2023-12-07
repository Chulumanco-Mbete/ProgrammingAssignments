using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class BeerSong
    {
        public static string Lyrics() 
        {
            for (int i = 99; i > 0; i--)
            {
                Console.WriteLine($"{i} bottle{(i == 1 ? "" : "s")} of beer on the wall, {i} bottle{(i == 1 ? "" : "s")} of beer.");
                Console.WriteLine($"Take one down, pass it around, {i - 1} bottle{(i == 2 ? "" : "s")} of beer on the wall.");
                Console.WriteLine();
            }
            return "";
        }
    }
}
