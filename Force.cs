using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    public class Force
    {
        public class Inertia : Force
        {
            public double F1;
            public double F2;
            public double Net;

            public double dv;
            public double dt;
            public double ds;

            public void InertiaNet()
            {
                Net = F1 + F2;
                if (Net == 0)
                {
                    Console.WriteLine("ther is no changes in the inertia");

                }
                else
                {
                    Console.WriteLine("inertia = " + Net);
                }
            }
            public void InertiaF1()
            {
                Console.WriteLine("F1 = " + F1);
            }
            public void InertiaF2()
            {
                Console.WriteLine("F2 = " + F2);
            }
            public void InertiaMovement()
            {

            }
        }
    }
}
