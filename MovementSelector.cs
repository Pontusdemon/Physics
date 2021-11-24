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
                // v = s / t
                {
                    Console.WriteLine("enter distance");
                    AverageVelocity.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    AverageVelocity.t = Convert.ToDouble(Console.ReadLine());

                    AverageVelocity.svtAverageVelocity();
                }
                
                else if (AverageVelocityCalculation == "aceleration")
                // v = a * t
                {
                    Console.WriteLine("enter aceleration");
                    AverageVelocity.a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    AverageVelocity.t = Convert.ToDouble(Console.ReadLine());

                    AverageVelocity.AverageVelcoityAceleration();
                }
                
                else if (AverageVelocityCalculation == "vm")
                // vm = (x + v)
                {
                    Console.WriteLine("enter initial velocity");
                    AverageVelocity.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter final velocity");
                    AverageVelocity.v = Convert.ToDouble(Console.ReadLine());

                    AverageVelocity.AverageVelocity_m();
                }
            }

            else if (MovementType == "final velocity")
            {
                Console.WriteLine("select calculation for final velocity");
                string FinalVelocityCalculation = Console.ReadLine();
                var FinalVelocity = new Movement.Velocity.Final();

                if (FinalVelocityCalculation == "svt")
                // v = x + s / t
                {
                    
                }

                else if (FinalVelocityCalculation == "general")
                // v = x + at
                {

                }

                else if (FinalVelocityCalculation == "2as")
                // v^2 = x^2 + 2as
                {

                }
            }

            else if (MovementType == "initial velocity")
            {
                Console.WriteLine("select calculation for initial velocity");
                string InitialVelocityCalculation = Console.ReadLine();
            }

            else if (MovementType == "aceleration")
            {
                Console.WriteLine("select how to calculate aceleration");
                string AcelerationCalculation = Console.ReadLine();
                // a = (v - x) / t
                // a = (v^2 - x^2) / 2s
                // a = 2(s - ut) / t^2
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
