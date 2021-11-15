using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    class Density
    {
        public double d;
        public double m;
        public double V;

        public void DensitySelector()
        {
            Console.WriteLine("select variable");
            var SelectVar = Console.ReadLine();
            var GetCalculation = new Density();
            if (SelectVar=="d")
            {
                GetCalculation.CalculateDensity();
            }
            else if (SelectVar=="m")
            {
                GetCalculation.CalculateDensityMass();   
            }
            else if (SelectVar=="V")
            {
                GetCalculation.CalculateDensityVolume();
            }
        }

        //d = m / V
        public void CalculateDensity()
        {
            Console.WriteLine("enter mass");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter volume");
            V = Convert.ToDouble(Console.ReadLine());
            d = m / V;
            Console.WriteLine("density = " + d);
        }
        public void CalculateDensityMass()
        {
            Console.WriteLine("enter density");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter volume");
            V = Convert.ToDouble(Console.ReadLine());
            m = d * V;
            Console.WriteLine("mass = " + m);
        }
        public void CalculateDensityVolume()
        {
            Console.WriteLine("enter density");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter mass");
            m = Convert.ToDouble(Console.ReadLine());
            V = m / d;
            Console.WriteLine("volume = " + V);
        }
    }
}
