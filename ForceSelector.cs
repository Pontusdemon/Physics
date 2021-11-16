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
                    GetInertia.F1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter F2");
                    GetInertia.F2 = Convert.ToDouble(Console.ReadLine());

                    GetInertia.InertiaNet();
                }
                else if (InertiaVar == "F1")
                {
                    Console.WriteLine("enter Net");
                    GetInertia.Net = double.TryParse(Console.ReadLine(), out var Net) ? Net : 0;

                    Console.WriteLine("enter F2");
                    GetInertia.F2 = Convert.ToDouble(Console.ReadLine());

                    GetInertia.InertiaF1();
                }
                else if (InertiaVar == "F2")
                {
                    Console.WriteLine("enter Net");
                    GetInertia.Net = double.TryParse(Console.ReadLine(), out var Net) ? Net : 0;

                    Console.WriteLine("enter F1");
                    GetInertia.F1 = Convert.ToDouble(Console.ReadLine());

                    GetInertia.InertiaF2();
                }
            }
        }
    }
}
