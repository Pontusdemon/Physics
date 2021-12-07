using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    public abstract class Pressure
    {
        public double g;
        public double h;
        public double FL;
        public double V;
        public double T;
        public class Defined : Pressure
        {
            public double p;

            public double F;
            public double A;
            public double d;

            public void DefinedPressure()
            // p = F / A
            {
                Console.WriteLine("p = F / A");

                p = F / A;
                Console.WriteLine("defined pressure = " + p);
            }
        }

        public class Fluid : Pressure
        {
            public double p;

        }
    }
/*
        public class Fluid : Pressure  ///
        {
            public double p;
            public double x;
            public double d;
            public double g;
            public double h;

            public override void Tryck()
            {
                Console.WriteLine("p = x + dgh");

                p = x + (d * g * h);
                Console.WriteLine("fluid pressure = " + p);
            }

            public void ExternalPressure()
            {
                Console.WriteLine("x = p - dgh");

                x = p - (d * g * g);
                Console.WriteLine("external pressure = " + x);
            }

            public void FluidDensity()
            {
                Console.WriteLine("d = (p - x) / gh");

                d = (p - x) / (g * h);
                Console.WriteLine("fluid density = " + d);
            }

            public void FluidAcelerationForce()
            {
                Console.WriteLine("g = (p - x) / dh");

                g = (p - x) / (d * h);
                Console.WriteLine("aceleration = " + g);
            }

            public void FluidDeep()
            {
                Console.WriteLine("h = (p - x) / dg");

                h = (p - x) / (d * g);
                Console.WriteLine("depth = " + h);
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
    }*/
}
