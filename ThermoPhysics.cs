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
        // F = force
        // FL = liftforce
        // V = volume
        // m  = mass
        // g = gravity
        // A = area

        public abstract class Density : ThermoPhysics
        {
            public abstract void MasterDensity();

            public class General : Density
            {
                public double d;

                public double m;
                public double V;

                public override void MasterDensity()
                // d = m / V
                {
                    d = m / V;
                    Console.WriteLine("density = " + d);
                }
            }

            public class Fluid : Density
            {
                public double d;

                public double p;
                public double g;
                public double h;

                public override void MasterDensity()
                // d = p / (g * h)
                {
                    d = p / (g * h);
                    Console.WriteLine("density = " + d);
                }
            }

            public class ArkimedesDensity : Density 
            {
                public double d;

                public double FL;
                public double g;
                public double V;

                public override void MasterDensity()
                // d = FL / (g * V)
                {
                    d = FL / (g * V);
                    Console.WriteLine("density = " + d);
                }
            }
        }

        public abstract class Pressure : ThermoPhysics
        {
            public abstract void MasterPressure();

            public class Defined : Pressure
            {
                public double p;

                public double F;
                public double A;

                public override void MasterPressure()
                    // p = F / A
                {
                    p = F / A;
                    Console.WriteLine("pressure = " + p);
                }
            }

            public class Fluid : Pressure
            {
                public double p;

                public double x;
                public double d;
                public double g;
                public double h;

                public override void MasterPressure()
                    // p = x + dgh
                {
                    p = x + (d * g * h);
                    Console.WriteLine("fluid pressure = " + p);
                }

                public void ExternalPressure()
                {
                    x = p - (d * g * h);
                    Console.WriteLine("external pressure" + x);
                }
            }

            public class Gaslaw : Pressure
            // p = (k * T) / V
            {
                public double p;

                public double k;
                public double T;
                public double V;

                public override void MasterPressure()
                {
                    p = (k * T) / V;
                    Console.WriteLine("pressure = " + p);
                }
            }
        }







        /* 
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

             // p = F / A
             // P = x + dgh
             // p = FL / (g * V)
             // p = (k * T) / V

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

             public void ExternalPressureByFluidPressure()
             // x = p - dgh
             {
                 Console.WriteLine("x = p - dgh");

                 x = p - (d * g * h);
                 Console.WriteLine("external pressure = " + x);
             }

             public void PressureByArkimedes()
             // p = FL / (gV)
             {
                 Console.WriteLine("p = F / gV");

                 p = FL / (g * V);
                 Console.WriteLine("pressure = " + p);
             }

             public void PressureByGeneralGaslaw()
             // p = (k * T) / V;
             {
                 Console.WriteLine("p = kT / V");

                 p = (k * T) / V;
                 Console.WriteLine("gas pressure = " + p);
             }
         }

         public class Force : ThermoPhysics
         {
             // pressure force
             // lift force
             // inertia

             public double F;
             public double FL;

             public double p;
             public double A;
             public double g;
             public double V;

             public void PressureForce()
             // F = p * A
             {
                 Console.WriteLine("F = p * A");

                 F = p * A;
                 Console.WriteLine("pressure force = " + F);
             }

             public void LiftForceByArkimedes()
             // FL = pgV
             {
                 Console.WriteLine("FL = pgV");

                 FL = p * g * V;
                 Console.WriteLine("lift force = " + FL);
             }
         }

         public class Volume : ThermoPhysics
         {
             public double V;

             public double d;
             public double m;
             public double g;
             public double FL;
             public double k;
             public double T;
             public double p;

             public void VolumeByDensity()
             // V = m / d
             {
                 Console.WriteLine("V = m / d");

                 V = m / d;
                 Console.WriteLine("volume = " + V);
             }

             public void volumeByArkimedes()
             // V = FL / (dg)
             {
                 Console.WriteLine("V = FL / (d * g)");

                 V = FL / (d * g);
                 Console.WriteLine("volume  = " + V);
             }

             public void VolumeByGeneralGaslaw()
             // 
             {
                 Console.WriteLine("V = (k * T) / p");

                 V = (k * T) / p;
                 Console.WriteLine("volume = " + V);
             }
         }

         public class CalculationMass : ThermoPhysics
         {
             public double m;

             public double d;
             public double V;

             public void MassFunction()
             {
                 Console.WriteLine("m = d * V");

                 m = d * V;
                 Console.WriteLine("mass = " + m);
             }
         }

         public class Gravity : ThermoPhysics
         {
             public double g;

             public double d;
             public double p;
             public double h;
             public double FL;
             public double V;

             public void GravityExplainer()
             {
                 Console.WriteLine("please not that g = 9. 82 in most cases but the calculations for how to prove it will be what you find now");

                 Console.WriteLine("select calculation for g");
                 string GravityCalculation = Console.ReadLine();
                 var GetGravity = new ThermoPhysics.Gravity();

                 if (GravityCalculation == "fluid")
                 // g = p / (d * h)
                 {
                     Console.WriteLine("g = p / (d * h)");

                     Console.WriteLine("enter fluid pressure");
                     GetGravity.p = Convert.ToDouble(Console.ReadLine());

                     Console.WriteLine("enter fluid density");
                     GetGravity.d = Convert.ToDouble(Console.ReadLine());

                     Console.WriteLine("enter fluid height");
                     GetGravity.h = Convert.ToDouble(Console.ReadLine());

                     g = p / (d * h);
                     Console.WriteLine("g = " + g);
                 }

                 else if (GravityCalculation == "Arkimedes")
                 // g = FL / (d * V)
                 {
                     Console.WriteLine("g = FL / (d * V)");

                     Console.WriteLine("enter lift force");
                     GetGravity.FL = Convert.ToDouble(Console.ReadLine());

                     Console.WriteLine("enter density");
                     GetGravity.d = Convert.ToDouble(Console.ReadLine());

                     Console.WriteLine("enter volume");
                     GetGravity.V = Convert.ToDouble(Console.ReadLine());

                     g = FL / (d * V);
                     Console.WriteLine("g = " + g);
                 }
             }
         }

         public class Area : ThermoPhysics
         {
             public double A;

             public double F;
             public double p;

             public void AreaByDefinedPressure()
             // A = F / p
             {
                 Console.WriteLine("A = F / p");

                 A = F / p;
                 Console.WriteLine("defined pressure area = " + A);
             }
         }*/
    }
}
