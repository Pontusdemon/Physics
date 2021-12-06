using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    class DensitySelector
    {
        public void DensitySetup()
        {
            Console.WriteLine("select calculation for density");
            string DensityCalculation = Console.ReadLine();
            var GetDensity = new Density();
            
            if (DensityCalculation == "general")
            // d = m / V
            {
                Console.WriteLine("enter mass");
                GetDensity.m = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter volume");
                GetDensity.V = Convert.ToDouble(Console.ReadLine());

                GetDensity.GeneralDensity();
            }

            else if (DensityCalculation == "fluid density")
            // d = p / gh
            {
                Console.WriteLine("enter fluid pressure");
                GetDensity.p = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter gravity");
                GetDensity.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                Console.WriteLine("enter deaph");
                GetDensity.h = Convert.ToDouble(Console.ReadLine());

                GetDensity.FLuidDensity();
            }

            else if (DensityCalculation == "arkimedes")
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
    }
}
