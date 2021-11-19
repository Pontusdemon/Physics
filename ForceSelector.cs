using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    class ForceSelector
    {
        public void SelectForce()
        {
            Console.WriteLine("select force type");
            string ForceType = Console.ReadLine();

            if (ForceType == "inertia")
            {
                var GetInertia = new Force.Inertia();
                Console.WriteLine("select var");
                string InertiaVar = Console.ReadLine();

                if (InertiaVar == "Net")
                {
                    Console.WriteLine("enter F1");
                    GetInertia.F1 = double.TryParse(Console.ReadLine(), out double F1) ? F1 : 0;

                    Console.WriteLine("enter F2");
                    GetInertia.F2 = double.TryParse(Console.ReadLine(), out double F2) ? F2 : 0;

                    GetInertia.InertiaNet();
                }
            }
        }
    }
}
