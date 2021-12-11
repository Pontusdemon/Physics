using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    class MovementSelector
    {

        public virtual void MovementSetup()
        {
            Console.WriteLine("select movement type");
            string MovementType = Console.ReadLine();

            if (MovementType == "velocity")
            {
                Console.WriteLine("select velocity type");
                string VelocityType = Console.ReadLine();

                if (VelocityType == "average velocity")
                    // v = s / t
                {
                    Console.WriteLine("v = s / t");

                    var AverageVelocity = new Movement.Velocity.Average();
                    Console.WriteLine("enter distance");
                    AverageVelocity.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    AverageVelocity.t = Convert.ToDouble(Console.ReadLine());

                    AverageVelocity.VelocityMaster();
                }

                else if (VelocityType == "velocity")
                    // v = x + at
                {
                    var Velocity = new Movement.Velocity.Master();

                    Console.WriteLine("v = x + at");
                    Console.WriteLine("initial velocity?");
                    string VelocityOption = Console.ReadLine();

                    if (VelocityOption == "yes")
                        // x = v - at
                    {
                        Console.WriteLine("x = v - at");

                        Console.WriteLine("enter velocity");
                        Velocity.v = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter acceleration");
                        Velocity.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter time");
                        Velocity.t = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        // v = x + at

                        Console.WriteLine("enter initial velocity");
                        Velocity.x = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter acceleration");
                        Velocity.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter time");
                        Velocity.t = Convert.ToDouble(Console.ReadLine());
                    }

                    Velocity.VelocityMaster();
                }

                else if (VelocityType == "timeless")
                    // v = (x^2 + 2as)^0.5
                {
                    var Timeless = new Movement.Velocity.Timeless();

                    Console.WriteLine("v = (x^2 + 2as)^0.5");

                    Console.WriteLine("initial velocity?");
                    string TimelessVelocityOption = Console.ReadLine();

                    if (TimelessVelocityOption == "yes")
                    {
                        // x = (v^2 - 2as)^0.5

                        Console.WriteLine("x = (v^2 - 2as)^0.5");

                        Console.WriteLine("enter velocity");
                        Timeless.v = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter acceleration");
                        Timeless.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter distance");
                        Timeless.s = Convert.ToDouble(Console.ReadLine());
                    }
                    else
                    {
                        // v = (x^2 + 2as)^0.5

                        Console.WriteLine("enter initial velocity");
                        Timeless.x = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter acceleration");
                        Timeless.a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter distance");
                        Timeless.s = Convert.ToDouble(Console.ReadLine());
                    }
                    Timeless.VelocityMaster();
                }

                else
                // u = s/t - at/2
                {
                    var ExtraVelocity = new Movement.Velocity.Initial();

                    Console.WriteLine("enter distance");
                    ExtraVelocity.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    ExtraVelocity.t = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter acceleration");
                    ExtraVelocity.a = Convert.ToDouble(Console.ReadLine());

                    ExtraVelocity.VelocityMaster();
                }
            }

            else if (MovementType == "acceleration")
            {
                var Acceleration = new Movement.Acceleration();

                Console.WriteLine("enter calculation for acceleration");
                string AccelerationCalculation = Console.ReadLine();

                if (AccelerationCalculation == "general")
                // a = (v - x) / t
                {
                    Console.WriteLine("enter velocity");
                    Acceleration.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    Acceleration.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    Acceleration.t = Convert.ToDouble(Console.ReadLine());

                    Acceleration.GeneralAcceleration();
                }

                else if (AccelerationCalculation == "timeless")
                // a = (v^2 - x^2) / 2s
                {
                    Console.WriteLine("enter velocity");
                    Acceleration.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    Acceleration.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter distance");
                    Acceleration.s = Convert.ToDouble(Console.ReadLine());

                    Acceleration.TimelessAcceleration();
                }

                else
                // a = 2(s - ut) / t^2
                {
                    Console.WriteLine("enter distance");
                    Acceleration.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    Acceleration.u = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    Acceleration.t = Convert.ToDouble(Console.ReadLine());

                    Acceleration.AccelerationByDistance();
                }
            }

            else if (MovementType == "distance")
            {

            }

            // return















            /*if (MovementType == "average velocity")  // old code 
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

                    AverageVelocity.AverageVelocity_byAcceleration();
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
                var FinalVelocity = new Movement.Velocity.Timeless();

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

                // Extra Calculation
                else if (FinalVelocityCalculation == "distance")
                // s = ut + (at^2)/2
                {
                    var FInalVelocityDistance = new Movement.Velocity.Timeless();

                    Console.WriteLine("enter initial velocity");
                    FinalVelocity.u = double.TryParse(Console.ReadLine(), out double u) ? u : 0;

                    Console.WriteLine("enter time");
                    FinalVelocity.t = double.TryParse(Console.ReadLine(), out double t) ? t : 0;

                    Console.WriteLine("enter acceleration");
                    FinalVelocity.a = double.TryParse(Console.ReadLine(), out double a) ? a : 0;

                    ((Movement.Velocity.Timeless)FInalVelocityDistance).s = (u * t) + (a * Math.Pow(t, 2) / 2);

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

                    InitialVelocity.svtInitialVelocity();
                }

                else if (InitialVelocityCalculation == "acceleration")
                // x = v - at
                {
                    Console.WriteLine("enter final velocity");
                    InitialVelocity.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter acceleration");
                    InitialVelocity.a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    InitialVelocity.t = Convert.ToDouble(Console.ReadLine());

                    InitialVelocity.InitialVelocityAcceleration();
                }

                else if (InitialVelocityCalculation == "timeless")
                // x = (v^2 - 2as)^0.5
                {
                    Console.WriteLine("enter final velocity");
                    InitialVelocity.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter acceleration");
                    InitialVelocity.a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter distance");
                    InitialVelocity.s = Convert.ToDouble(Console.ReadLine());

                    InitialVelocity.TimelessInitialVelocity();
                }

                else if (InitialVelocityCalculation == "distance")
                // u = s/t - at/2
                {
                    Console.WriteLine("enter distance");
                    InitialVelocity.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("wenter time");
                    InitialVelocity.t = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter acceleration");
                    InitialVelocity.a = Convert.ToDouble(Console.ReadLine());

                    InitialVelocity.InitialVelocityDIstance();
                }

                else if (InitialVelocityCalculation == "conditional")
                // x = Vm - 2v
                {
                    Console.WriteLine("enter average velocity");
                    InitialVelocity.Vm = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter final velocity");
                    InitialVelocity.v = Convert.ToDouble(Console.ReadLine());

                    InitialVelocity.ConditionalInitialVelocity();
                }
            }



            else if (MovementType == "aceleration")
            {
                Console.WriteLine("select calculation for acceleration");
                string AccelerationCalculation = Console.ReadLine();
                var GetAccleration = new Movement.Acceleration();

                if (AccelerationCalculation == "general")
                // a = (v - x) / t
                {
                    Console.WriteLine("enter final velocity");
                    GetAccleration.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    GetAccleration.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    GetAccleration.t = Convert.ToDouble(Console.ReadLine());

                    GetAccleration.GeneralAcceleration();
                }

                else if (AccelerationCalculation == "timeless")
                // a = (v^2 - x^2) / 2s
                {
                    Console.WriteLine("enter final velocity");
                    GetAccleration.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    GetAccleration.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter distance");
                    GetAccleration.s = Convert.ToDouble(Console.ReadLine());

                    GetAccleration.TimelessAcceleration();
                }

                else if (AccelerationCalculation == "distance")
                // a = 2(s - ut) / t^2
                {
                    Console.WriteLine("enter distance");
                    GetAccleration.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    GetAccleration.u = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    GetAccleration.t = Convert.ToDouble(Console.ReadLine());

                    GetAccleration.Aceleration_byDistance();
                }
            }



            else if (MovementType == "distance")
            {
                Console.WriteLine("select distance calculation");
                string DistanceCalculation = Console.ReadLine();
                var MovementDistance = new Movement.Distance();

                if (DistanceCalculation == "svt")
                // s = v / t
                {
                    Console.WriteLine("enter velocity");
                    MovementDistance.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    MovementDistance.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    MovementDistance.t = Convert.ToDouble(Console.ReadLine());

                    MovementDistance.svtDIstance();
                }

                else if (DistanceCalculation == "timeless")
                // s = (v^2 - x^2) / 2a
                {
                    Console.WriteLine("enter final velocity");
                    MovementDistance.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    MovementDistance.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter acceleration");
                    MovementDistance.a = Convert.ToDouble(Console.ReadLine());

                    MovementDistance.TimelessDistance();
                }

                else if (DistanceCalculation == "conditional")
                // s = ut + (at^2)/2
                {
                    Console.WriteLine("enter initial velocity");
                    MovementDistance.u = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    MovementDistance.t = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter acceleration");
                    MovementDistance.a = Convert.ToDouble(Console.ReadLine());

                    MovementDistance.DistanceCondition();
                }
            }



            else if (MovementType == "time")
            {
                Console.WriteLine("select hoe to calculate movement time");
                string TimeCalculation = Console.ReadLine();
                var MoveTime = new Movement.Time();

                if (TimeCalculation == "svt")
                // t = s / v
                {
                    Console.WriteLine("enter distance");
                    MoveTime.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter velocity");
                    MoveTime.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    MoveTime.x = Convert.ToDouble(Console.ReadLine());

                    MoveTime.svt_Time();
                }

                else if (TimeCalculation == "acceleration")
                // t = (v - x) / a
                {
                    Console.WriteLine("enter final velocity");
                    MoveTime.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    MoveTime.x = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter acceleration");
                    MoveTime.a = Convert.ToDouble(Console.ReadLine());

                    MoveTime.AccelerationTime();
                }

                else if (TimeCalculation == "distance")
                // t = (-u + (u^2 + 2as)^0.5) / a
                {
                    Console.WriteLine("enter initial velocity");
                    MoveTime.u = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter acceleration");
                    MoveTime.a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter distance");
                    MoveTime.s = Convert.ToDouble(Console.ReadLine());

                    MoveTime.DistanceTime();
                }
            }*/
        }
    }
}
