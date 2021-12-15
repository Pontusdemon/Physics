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
            Console.WriteLine("select thermophysice subject");
            string ThermoPhysicsSubject = Console.ReadLine();

            if (ThermoPhysicsSubject == "density")
            {
                Console.WriteLine("select density type");
                string DensityType = Console.ReadLine();

                if (DensityType == "general")
                // d = m / V
                {
                    var GeneralDensity = new ThermoPhysics.Density.General();
                    Console.WriteLine("d = m / V");

                    Console.WriteLine("enter mass");
                    GeneralDensity.m = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter volume");
                    GeneralDensity.V = Convert.ToDouble(Console.ReadLine());

                    GeneralDensity.MasterDensity();
                }

                else if (ThermoPhysicsSubject == "fluid")
                // d = p / (g * h)
                {
                    var FluidDensity = new ThermoPhysics.Density.Fluid();
                    Console.WriteLine("d = p / (g * h)");

                    Console.WriteLine("enter fluid pressure");
                    FluidDensity.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter gravity");
                    FluidDensity.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter fluid deaph");
                    FluidDensity.h = Convert.ToDouble(Console.ReadLine());

                    FluidDensity.MasterDensity();
                }

                else if (ThermoPhysicsSubject == "Arkimedes")
                // d = FL / (g * V)
                {
                    var Arkimedes = new ThermoPhysics.Density.ArkimedesDensity();
                    Console.WriteLine("d = FL / (g * V)");

                    Console.WriteLine("enter liftforce");
                    Arkimedes.FL = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter gravity");
                    Arkimedes.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter volume");
                    Arkimedes.V = Convert.ToDouble(Console.ReadLine());

                    Arkimedes.MasterDensity();
                }
            }

            else if (ThermoPhysicsSubject == "pressure")
            {
                Console.WriteLine("select pressure type");
                string PressureType = Console.ReadLine();

                if (PressureType == "defined")
                // p = F / A
                {
                    var GeneralPressure = new ThermoPhysics.Pressure.Defined();
                    Console.WriteLine("p = F / A");

                    Console.WriteLine("enter force");
                    GeneralPressure.F = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter area");
                    GeneralPressure.A = Convert.ToDouble(Console.ReadLine());

                    GeneralPressure.MasterPressure();
                }

                else if (PressureType == "fluid")
                {
                    var FluidPressure = new ThermoPhysics.Pressure.Fluid();

                    Console.WriteLine("external pressure ? ");
                    string ExternalPressure = Console.ReadLine();

                    if (ExternalPressure == "yes")
                    // x = p - dgh
                    {
                        Console.WriteLine("x = p - dgh");

                        Console.WriteLine("enter pressure");
                        FluidPressure.p = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter density");
                        FluidPressure.d = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter gravity");
                        FluidPressure.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                        Console.WriteLine("enter fluid deaph");
                        FluidPressure.h = Convert.ToDouble(Console.ReadLine());

                        FluidPressure.ExternalPressure();
                    }

                    else
                    // p = x + dgh
                    {
                        Console.WriteLine("p = x + dgh");

                        Console.WriteLine("enter external pressure");
                        FluidPressure.x = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter density");
                        FluidPressure.d = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter gravity");
                        FluidPressure.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                        Console.WriteLine("enter fluid deaph");
                        FluidPressure.h = Convert.ToDouble(Console.ReadLine());

                        FluidPressure.MasterPressure();
                    }
                }

                else if (PressureType == "Gaslaw")
                    // p = (k * T) / V
                {
                    var GeneralGaslawPressure = new ThermoPhysics.Pressure.Gaslaw();
                    Console.WriteLine("p = (k * T) / V");

                    Console.WriteLine("enter konstant");
                    GeneralGaslawPressure.k = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter temperature");
                    GeneralGaslawPressure.T = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter volume");
                    GeneralGaslawPressure.V = Convert.ToDouble(Console.ReadLine());

                    GeneralGaslawPressure.MasterPressure();
                }
            }
        }
        /*
        public void ThermoSetup()
        {
            

          

                else if (PressureType == "arkimedes")
                // p = FL / (gV)
                {
                    Console.WriteLine("enter lift force");
                    Pressure.FL = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter gravity");
                    Pressure.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter volume");
                    Pressure.V = Convert.ToDouble(Console.ReadLine());

                    Pressure.PressureByArkimedes();
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

                    Pressure.PressureByGeneralGaslaw();
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

                    GetForce.LiftForceByArkimedes();
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
                Console.WriteLine("select area type");
                string AreaType = Console.ReadLine();
                var GetArea = new ThermoPhysics.Area();

                if (AreaType == "defined pressure area")
                // A = F / p
                {
                    Console.WriteLine("enter force");
                    GetArea.F = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter pressure");
                    GetArea.p = Convert.ToDouble(Console.ReadLine());
                }
            }
        }*/
    }
}
