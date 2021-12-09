using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    class ThermoPhysicSelector
    {
        public void ThermoSetup()
        {
            Console.WriteLine("select thermophysics type");
            string ThermoSubject = Console.ReadLine();

            if (ThermoSubject == "density")
            {
                Console.WriteLine("select density type");
                string DensityType = Console.ReadLine();
                var GetDensity = new ThermoPhysics.Density();

                if (DensityType == "general")
                // d = m / V
                {
                    Console.WriteLine("enter mass");
                    GetDensity.m = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter volume");
                    GetDensity.V = Convert.ToDouble(Console.ReadLine());

                    GetDensity.GeneralDensity();
                }
                
                else if (DensityType == "fluid")
                // d = p / gh
                {
                    Console.WriteLine("enter fluid pressure");
                    GetDensity.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter gravity");
                    GetDensity.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter fluid deaph");
                    GetDensity.h = Convert.ToDouble(Console.ReadLine());

                    GetDensity.FLuidDensity();
                }

                else if (DensityType == "arkimedes")
                // d = FL / (gV)
                {
                    Console.WriteLine("enter lift force");
                    GetDensity.FL = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter gravity");
                    GetDensity.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter volume");
                    GetDensity.V = Convert.ToDouble(Console.ReadLine());

                    GetDensity.ArkimedesDensity();
                }
            }

            else if (ThermoSubject == "pressure")
            {
                Console.WriteLine("select pressure type");
                string PressureType = Console.ReadLine();
                var Pressure = new ThermoPhysics.Pressure();

                if (PressureType == "defined")
                // p = F / A
                {
                    Console.WriteLine("enter pressure force");
                    Pressure.F = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter pressure area");
                    Pressure.A = Convert.ToDouble(Console.ReadLine());

                    Pressure.DefinedPressure();
                }

                else if (PressureType == "fluid pressure")
                // p = x + dgh
                {
                    Console.WriteLine("enter external pressure");
                    Pressure.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter fluid density");
                    Pressure.d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter gravity");
                    Pressure.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter fluid deaph");
                    Pressure.h = Convert.ToDouble(Console.ReadLine());

                    Pressure.FluidPressure();
                }

                else if (PressureType == "arkimedes")
                // p = FL / (gV)
                {
                    Console.WriteLine("enter lift force");
                    Pressure.FL = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter gravity");
                    Pressure.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter volume");
                    Pressure.V = Convert.ToDouble(Console.ReadLine());

                    Pressure.ArkimedesPressure();
                }

                else if (PressureType == "gaslaw")
                // p = (k * T) / V
                {
                    Console.WriteLine("enter konstant");
                    Pressure.k = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter temperature");
                    Pressure.T = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter volume");
                    Pressure.V = Convert.ToDouble(Console.ReadLine());

                    Pressure.GeneralGaslawPressure();
                }
            }

            else if (ThermoSubject == "force")
            {
                Console.WriteLine("select force type");
                string ForceType = Console.ReadLine();
                var GetForce = new ThermoPhysics.Force();

                if (ForceType == "pressure force")
                // F = pA
                {
                    Console.WriteLine("enter pressure");
                    GetForce.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter pressure area");
                    GetForce.A = Convert.ToDouble(Console.ReadLine());

                    GetForce.PressureForce();
                }

                else if (ForceType == "arkimedes")
                // FL = pgV
                {
                    Console.WriteLine("enter pressure");
                    GetForce.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter gravity");
                    GetForce.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter volume");
                    GetForce.V = Convert.ToDouble(Console.ReadLine());

                    GetForce.ArkimedesForce();
                }
            }

            else if (ThermoSubject == "volume")
            {
                Console.WriteLine("select volume type");
                string VolumeType = Console.ReadLine();
                var Volume = new ThermoPhysics.Volume();

                if (VolumeType == "density")
                // V = m / d
                {
                    Console.WriteLine("enter mass");
                    Volume.m = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter density");
                    Volume.d = Convert.ToDouble(Console.ReadLine());

                    Volume.VolumeByDensity();
                }

                else if (VolumeType == "arkimedes")
                // V = FL / (d * g)
                {
                    Console.WriteLine("enter lift force");
                    Volume.FL = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter density");
                    Volume.d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter gravity");
                    Volume.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Volume.volumeByArkimedes();
                }

                else if (VolumeType == "gaslaw")
                // V = (k * T) / p
                {
                    Console.WriteLine("enter konstant");
                    Volume.k = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter temperature");
                    Volume.T = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter gas pressure");
                    Volume.p = Convert.ToDouble(Console.ReadLine());
                }
            }

            else if (ThermoSubject == "mass")
            // m = d * V
            {
                var Mass = new ThermoPhysics.CalculationMass();
                Console.WriteLine("enter density");
                Mass.d = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter volume");
                Mass.V = Convert.ToDouble(Console.ReadLine());

                Mass.MassFunction();
            }

            else if (ThermoSubject == "gravity")
            {
                var NewVoid = new ThermoPhysics.Gravity();
                NewVoid.GravityExplainer();
            }

            else if (ThermoSubject == "area")
            {
                
            }
        }
    }
}
