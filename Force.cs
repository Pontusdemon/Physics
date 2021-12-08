using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    public class Force
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

        public void ArkimedesForce()
        // FL = pgV
        {
            Console.WriteLine("FL = pgV");

            FL = p * g * V;
            Console.WriteLine("lift force = " + FL);
        }
    }
}
