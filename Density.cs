using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    public class Density
    {
        public double d;

        public double m;
        public double V;
        public double p;
        public double g;
        public double h;
        public double FL;


        public void GeneralDensity()
        // d = m / V
        {
            Console.WriteLine("d = m / V");

            d = m / V;
            Console.WriteLine("density = " + d);
        }

        public void FLuidDensity()
        // d = p / gh
        {
            Console.WriteLine("d = p / (gh)");

            d = p / (g * h);
            Console.WriteLine("fluid density = " + d);
        }

        public void ArkimedesDensity()
        // d = F / gV
        {
            Console.WriteLine("d = FL / (gV)");

            d = FL / (g * V);
            Console.WriteLine("density = " + d);
        }
    }
}
