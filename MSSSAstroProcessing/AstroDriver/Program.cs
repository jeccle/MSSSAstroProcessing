using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

namespace AstroDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AstroCalculations library = new AstroCalculations();
            Console.WriteLine(library.StarVelocity(500.1, 500.0));
            Console.WriteLine(library.StarDistance(0.547));
            Console.WriteLine(library.TempKelvin(27));
            Console.WriteLine(library.EventHorizon(8.2 * Math.Pow(10, 36)));
        }
    }
}
