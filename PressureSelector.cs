using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    class PressureSelector
    {
        public void SelectPressure()
        {
            Console.WriteLine("select pressure type");
            string PressureType = Console.ReadLine();
            if (PressureType == "defined")
            {
                var GetDefinedPressure = new Pressure.Defined();
                Console.WriteLine("select var");
                string PressureVar = Console.ReadLine();
                if (PressureVar == "p")
                {
                    Console.WriteLine("enter force");
                    GetDefinedPressure.F = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter area");
                    GetDefinedPressure.A = Convert.ToDouble(Console.ReadLine());
                    
                    GetDefinedPressure.Tryck();
                }

                else if (PressureVar == "F")
                {
                    Console.WriteLine("enter pressure");
                    GetDefinedPressure.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter area");
                    GetDefinedPressure.A = Convert.ToDouble(Console.ReadLine());

                    GetDefinedPressure.DefinedPressureForce();
                }

                else if (PressureVar == "A")
                {
                    Console.WriteLine("enter pressure");
                    GetDefinedPressure.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter force");
                    GetDefinedPressure.F = Convert.ToDouble(Console.ReadLine());

                    GetDefinedPressure.DefinedPressureArea();
                }
            }

            else if (PressureType == "fluid")
            {
                var GetFluidPressure = new Pressure.Fluid();
                Console.WriteLine("select var");
                string FluidVar = Console.ReadLine();
                if (FluidVar == "p")
                {
                    Console.WriteLine("enter external pressure");
                    GetFluidPressure.x = double.TryParse(Console.ReadLine(), out double x) ? x : 0;

                    Console.WriteLine("enter density");
                    GetFluidPressure.d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter aceleration");
                    GetFluidPressure.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter fluid deep");
                    GetFluidPressure.h = Convert.ToDouble(Console.ReadLine());

                    GetFluidPressure.FluidPressure();
                }

                else if (FluidVar == "x")
                {
                    Console.WriteLine("enter fluid pressure");
                    GetFluidPressure.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter density");
                    GetFluidPressure.d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter aceleration");
                    GetFluidPressure.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter fluid deep");
                    GetFluidPressure.h = Convert.ToDouble(Console.ReadLine());

                    GetFluidPressure.ExternalPressure();
                }

                else if (FluidVar == "d")
                {
                    Console.WriteLine("enter fluid pressure");
                    GetFluidPressure.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter external pressure");
                    GetFluidPressure.x = double.TryParse(Console.ReadLine(), out double x) ? x : 0;

                    Console.WriteLine("enter aceleration");
                    GetFluidPressure.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter fluid deep");
                    GetFluidPressure.h = Convert.ToDouble(Console.ReadLine());

                    GetFluidPressure.FluidDensity();
                }

                else if (FluidVar == "g")
                {
                    Console.WriteLine("enter fluid pressure");
                    GetFluidPressure.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter external pressure");
                    GetFluidPressure.x = double.TryParse(Console.ReadLine(), out double x) ? x : 0;

                    Console.WriteLine("enter density");
                    GetFluidPressure.d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter fluid deep");
                    GetFluidPressure.h = Convert.ToDouble(Console.ReadLine());

                    GetFluidPressure.FluidAcelerationForce();
                }

                else if (FluidVar == "h")
                {
                    Console.WriteLine("enter fluid pressure");
                    GetFluidPressure.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter external pressure");
                    GetFluidPressure.x = double.TryParse(Console.ReadLine(), out double x) ? x : 0;

                    Console.WriteLine("enter density");
                    GetFluidPressure.d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter aceleration");
                    GetFluidPressure.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    GetFluidPressure.FluidDeep();
                }
            }

            else if (PressureType == "Arkimedes")
            {
                var GetArkimedes = new Pressure.Arkimedes();
                Console.WriteLine("select var");
                string ArkimedesVar = Console.ReadLine();
                if (ArkimedesVar == "FL")
                {
                    Console.WriteLine("enter density");
                    GetArkimedes.d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter aceleration");
                    GetArkimedes.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter volume");
                    GetArkimedes.V = Convert.ToDouble(Console.ReadLine());

                    GetArkimedes.ArkimedesLiftForce();
                }

                else if (ArkimedesVar == "d")
                {
                    Console.WriteLine("enter lift force");
                    GetArkimedes.FL = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter aceleration");
                    GetArkimedes.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    Console.WriteLine("enter volume");
                    GetArkimedes.V = Convert.ToDouble(Console.ReadLine());

                    GetArkimedes.ArkimedesDensity();
                }

                else if (ArkimedesVar == "g")
                {
                    Console.WriteLine("enter lift force");
                    GetArkimedes.FL = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter density");
                    GetArkimedes.d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter volume");
                    GetArkimedes.V = Convert.ToDouble(Console.ReadLine());

                    GetArkimedes.ArkimedesGravity();
                }

                else if (ArkimedesVar == "V")
                {
                    Console.WriteLine("enter lift force");
                    GetArkimedes.FL = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter density");
                    GetArkimedes.d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter aceleration");
                    GetArkimedes.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                    GetArkimedes.ArkimedesVolme();
                }
            }

            else if (PressureType == "gaslaw")
            {
                var GetGaslaw = new Pressure.Gaslaw();
                Console.WriteLine("select var");
                string GaslawVar = Console.ReadLine();
                if (GaslawVar == "p")
                {
                    Console.WriteLine("enter volume");
                    GetGaslaw.V = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter absolute temperature");
                    GetGaslaw.T = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter constant");
                    GetGaslaw.k = double.TryParse(Console.ReadLine(), out double k) ? k : 0;

                    GetGaslaw.GasPressure();
                }

                else if (GaslawVar == "V")
                {
                    Console.WriteLine("enter pressure");
                    GetGaslaw.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter absolute temperature");
                    GetGaslaw.T = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter constant");
                    GetGaslaw.k = double.TryParse(Console.ReadLine(), out double k) ? k : 0;

                    GetGaslaw.GasVolume();
                }

                else if (GaslawVar == "T")
                {
                    Console.WriteLine("enter pressure");
                    GetGaslaw.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter volume");
                    GetGaslaw.V = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter constant");
                    GetGaslaw.k = double.TryParse(Console.ReadLine(), out double k) ? k : 0;

                    GetGaslaw.GasTemprature();
                }

                else if (GaslawVar == "k")
                {
                    Console.WriteLine("enter pressure");
                    GetGaslaw.p = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter volume");
                    GetGaslaw.V = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter temperature");
                    GetGaslaw.T = double.TryParse(Console.ReadLine(), out double T) ? T : 0;

                    GetGaslaw.GasConst();
                }
            }
        }
    }
}
