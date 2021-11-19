using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    public abstract class Pressure
    {
        public abstract void Tryck();
        public class Defined : Pressure
        {
            public double p;
            public double F;
            public double A;

            public override void Tryck()
            {
                Console.WriteLine("p = F / A");
                p = F / A;
                Console.WriteLine("pressure = " + p);
            }

            public void DefinedPressureForce()
            {
                Console.WriteLine("F = pA");
                F = p * A;
                Console.WriteLine("pressure force = " + F);
            }

            public void DefinedPressureArea()
            {
                Console.WriteLine("A = F / p");
                A = F / p;
                Console.WriteLine("pressure area = " + A);
            }
        }
        public class Fluid : Pressure
        {
            public double p;
            public double x;
            public double d;
            public double g;
            public double h;

            public override void Tryck()
            {
                
            }

            public void FluidPressure()
            {
                p = x + (d * g * h);
                Console.WriteLine("fluid pressure = " + p);
            }

            public void ExternalPressure()
            {
                x = p - (d * g * h);
                Console.WriteLine("external pressure = " + x);
            }

            public void FluidDensity()
            {
                d = (p - x) / (g * h);
                Console.WriteLine("fluid density = " + d);
            }

            public void FluidAcelerationForce()
            {
                g = (p - x) / (d * h);
                Console.WriteLine("aceleration g = " + g);
            }

            public void FluidDeep()
            {
                h = (p - x) / (d * g);
                Console.WriteLine("fluid deaph =" + h);
            }
        }
        public class Arkimedes : Pressure
        {
            public double FL;
            public double d;
            public double g;
            public double V;
            public override void Tryck()
            {
                
            }
            public void ArkimedesLiftForce()
            {
                FL = d * g * V;
                Console.WriteLine("the liftforce = " + FL);
            }

            public void ArkimedesDensity()
            {
                d = FL - (g * V);
                Console.WriteLine("density = " + d);
            }

            public void ArkimedesGravity()
            {
                g = FL - (d * V);
                Console.WriteLine("g = " + g);
            }

            public void ArkimedesVolme()
            {
                V = FL - (d * g);
                Console.WriteLine("volume = " + V);
            }
        }
        public class Gaslaw : Pressure
        {
            public double k;
            public double V;
            public double T;
            public double p;

            public override void Tryck()
            {
                throw new NotImplementedException();
            }

            public void GasPressure()
            {
                p = (k * T) / V;
                Console.WriteLine("gas pressure = " + p);
            }

            public void GasVolume()
            {
                V = (k * T) / p;
                Console.WriteLine("gas volume = " + V);
            }

            public void GasTemprature()
            {
                T = (p * V) / k;
                Console.WriteLine("temperature = " + T);
            }

            public void GasConst()
            {
                k = (p * V) / T;
                Console.WriteLine("gas const = " + k);
            }
        }
    }
}
