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
                Console.WriteLine("select calculation for average velocity");
                string AverageVelocityCalculation = Console.ReadLine();
                var AverageVelocity = new Movement.Velocity.Average();

                if (AverageVelocityCalculation == "general")
                // Vm = s / t
                {
                    Console.WriteLine("enter distance");
                    AverageVelocity.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    AverageVelocity.t = Convert.ToDouble(Console.ReadLine());

                    AverageVelocity.GeneralAverageVelocity();
                }

                else if (AverageVelocityCalculation == "acceleration")
                // Vm = at
                {
                    Console.WriteLine("enter acceleration");
                    AverageVelocity.a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    AverageVelocity.t = Convert.ToDouble(Console.ReadLine());

                    AverageVelocity.AccelerationAverageVelocity();
                }

                else if (AverageVelocityCalculation == "conditional velocity")
                // Vm = (x + v) / 2
                {
                    Console.WriteLine("enter initial velocity");
                    AverageVelocity.x = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine("enter final velocity");
                    AverageVelocity.v = Convert.ToDouble(Console.ReadLine());

                    AverageVelocity.ConditionalAverageVelocity();
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
                    Console.WriteLine("enter initial velocity");
                    FinalVelocity.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter distance");
                    FinalVelocity.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    FinalVelocity.t = Convert.ToDouble(Console.ReadLine());

                    FinalVelocity.svtFinalVelocity();
                }

                else if (FinalVelocityCalculation == "general")
                // v = x + at
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


                else if (FinalVelocityCalculation == "distance")
                // s = ut + (at^2)/2
                {
                    var FInalVelocityDistance = new Movement.Velocity.Final();

                    Console.WriteLine("enter initial velocity");
                    FinalVelocity.u = double.TryParse(Console.ReadLine(), out double u) ? u : 0;

                    Console.WriteLine("enter time");
                    FinalVelocity.t = double.TryParse(Console.ReadLine(), out double t) ? t : 0;

                    Console.WriteLine("enter acceleration");
                    FinalVelocity.a = double.TryParse(Console.ReadLine(), out double a) ? a : 0;

                    ((Movement.Velocity.Final)FInalVelocityDistance).s = (u * t) + (a * Math.Pow(t, 2) / 2);

                    Console.WriteLine("calculation for velocity by distance");

                    FinalVelocity.TimelessFinalVelocity();
                }


                else if (FinalVelocityCalculation == "velocity condition")
                // v = Vm - 2x
                {
                    Console.WriteLine("enter average velocity");
                    FinalVelocity.Vm = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    FinalVelocity.x = Convert.ToDouble(Console.ReadLine());

                    FinalVelocity.FinalVelocityCondition();
                }
            }



            else if (MovementType == "initial velocity")
            {
                Console.WriteLine("select calculation for initial velocity");
                string InitialVelocityCalculation = Console.ReadLine();
                var InitialVelocity = new Movement.Velocity.Initial();

                if (InitialVelocityCalculation == "svt")
                // x = v - s / t
                {
                    Console.WriteLine("enter final velocity");
                    InitialVelocity.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter distance");
                    InitialVelocity.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    InitialVelocity.t = Convert.ToDouble(Console.ReadLine());

                    
                }
            }


            else if (MovementType == "aceleration")
            {

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
