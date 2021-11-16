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
            public double Net;
            public double F1;
            public double F2;

            public double dv;
            public double dt;
            public double ds;

            public double x = 0;

            public void InertiaNet()
            {
                Net = F1 + F2;
                Console.WriteLine("inertia = " + Net);
                if (Net == 0)
                {

                }
            }
        }
    }
}
