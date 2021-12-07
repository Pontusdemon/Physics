using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    public class ThermoPhysics
    {
        // d = density
        // p = pressure
        // m = mass


        public class Density : ThermoPhysics
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


        public class Pressure : ThermoPhysics
        {
            public double p;
            public double x;

            public double F;
            public double A;
            public double d;
            public double g;
            public double h;
            public double FL;
            public double V;
            public double k;
            public double T;

            public void DefinedPressure()
            // p = F / A
            {
                Console.WriteLine("p = F / A");

                p = F / A;
                Console.WriteLine("defined pressure = " + p);
            }

            public void FluidPressure()
            // p = x + dgh
            {
                Console.WriteLine("p = x + dgh");

                p = x + (d * g * h);
                Console.WriteLine("fluid pressure = " + p);
            }

            public void ExternalFluidPressure()
            // x = p - dgh
            {
                Console.WriteLine("x = p - dgh");

                x = p - (d * g * h);
                Console.WriteLine("external pressure = " + x);
            }

            public void ArkimedesPressure()
            // p = FL / (gV)
            {
                Console.WriteLine("p = F / gV");

                p = FL / (g * V);
                Console.WriteLine("pressure = " + p);
            }

            public void GeneralGaslawPressure()
            // p = (k * T) / V;
            {
                Console.WriteLine("p = kT / V");
                
                p = (k * T) / V;
                Console.WriteLine("gas pressure = " + p);
            }
        }
    }
}
