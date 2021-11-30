using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    class MovementSelector
    {

        public void MovementSetup()
        {
            Console.WriteLine("select movement type");
            string MovementType = Console.ReadLine();


            if (MovementType == "average velocity")
            {
                Console.WriteLine("select calculation");
                string AverageVelocityCalculation = Console.ReadLine();
                var AverageVelocity = new Movement.Velocity.Average();

                if (AverageVelocityCalculation == "general")
                // Vm = s / t
                {
                    Console.WriteLine("enter distance");
                    AverageVelocity.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    AverageVelocity.t = Convert.ToDouble(Console.ReadLine());

                    AverageVelocity.AverageVelocity_svt();
                }

                else
                // Vm = (x + v) / 2
                {
                    Console.WriteLine("enter initial velocity");
                    // enter unit
                    AverageVelocity.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter final velocity");
                    // enter unit
                    AverageVelocity.v = Convert.ToDouble(Console.ReadLine());

                    AverageVelocity.AverageVelocity_Vm();
                }
            }


            else if (MovementType == "final velocity")
            {
                Console.WriteLine("select calculation for final velocity");
                string FinalVelocityCalculation = Console.ReadLine();
                var FinalVelocity = new Movement.Velocity.Final();

                if (FinalVelocityCalculation == "general")
                // v = x + a * t
                {
                    Console.WriteLine("enter initial velocity");
                    FinalVelocity.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter acceleration");
                    FinalVelocity.a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    FinalVelocity.t = Convert.ToDouble(Console.ReadLine());

                    FinalVelocity.GeneralFinalVelocity();
                }

                else if (FinalVelocityCalculation == "timeless")
                // v = (x^2 + 2as)^0.5
                {
                    Console.WriteLine("enter initial velocity");
                    FinalVelocity.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter acceleration");
                    FinalVelocity.a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter distance");
                    FinalVelocity.s = Convert.ToDouble(Console.ReadLine());

                    FinalVelocity.TimelessFinalVelocity();
                }

                else if (FinalVelocityCalculation == "alternate")
                // v = u + at
                // v = (u^2 + 2as)^0.5
                {

                }
            }


            else if (MovementType == "initial velocity")
            {
                Console.WriteLine("select calculation for initial velocity");
                string InitialVelocityCalculation = Console.ReadLine();
                var InitialVelocity = new Movement.Velocity.Initial();


            }


            else if (MovementType == "aceleration")
            {
                Console.WriteLine("select how to calculate aceleration");
                string AcelerationCalculation = Console.ReadLine();
                var GetAcceleration = new Movement.Acceleration();

                if (AcelerationCalculation == "general")
                // a = (v - x) / t
                {
                    Console.WriteLine("enter final velocity");
                    GetAcceleration.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    GetAcceleration.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    GetAcceleration.t = Convert.ToDouble(Console.ReadLine());

                    GetAcceleration.GeneralAceleration();
                }

                else if (AcelerationCalculation == "timeless")
                // a = (v^2 - x^2) / 2s
                {
                    Console.WriteLine("enter final velocity");
                    GetAcceleration.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    GetAcceleration.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter distance");
                    GetAcceleration.s = Convert.ToDouble(Console.ReadLine());

                    GetAcceleration.Acceleration2as();
                }

                else if (AcelerationCalculation == "at2")
                // a = 2(s - ut) / t^2
                {
                    Console.WriteLine("enter distance");
                    GetAcceleration.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    GetAcceleration.u = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    GetAcceleration.t = Convert.ToDouble(Console.ReadLine());


                }
            }


            else if (MovementType == "distance")
            {
                Console.WriteLine("select distance calculation");
                string DistanceCalculation = Console.ReadLine();
                // s = vt
                // s = (v^2 - x^2) / 2a
                // s = ut + (at^2) / 2s
            }


            else if (MovementType == "time")
            {
                Console.WriteLine("select hoe to calculate movement time");
                string TimeCalculation = Console.ReadLine();
                // t = s / v
                // t = v / a
                // t = (-u + (2as + u^2)^0.5) / a
            }
        }
    }
}
