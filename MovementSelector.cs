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

            if (MovementType == "velocity")
            {
                var GetVelocity = new Movement.Velocity();
                Console.WriteLine("select var");
                string VelocityVar = Console.ReadLine();
                if (VelocityVar == "s")
                {
                    Console.WriteLine("enter velocity");
                    GetVelocity.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    GetVelocity.t = Convert.ToDouble(Console.ReadLine());

                    GetVelocity.svtDistance();
                }
                
                else if (VelocityVar == "v")
                {
                    Console.WriteLine("enter distance");
                    GetVelocity.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    GetVelocity.t = Convert.ToDouble(Console.ReadLine());

                    GetVelocity.svtVelocity();
                }

                else if (VelocityVar == "t")
                {
                    Console.WriteLine("enter distance");
                    GetVelocity.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter velocity");
                    GetVelocity.v = Convert.ToDouble(Console.ReadLine());

                    GetVelocity.svtTime();
                }

                else
                {
                    GetVelocity.Move();
                }
            }

            else if (MovementType == "aceleration")
            {
                var GetAceleration = new Movement.Aceleration();
                Console.WriteLine("select var");
                string AcelerationVar = Console.ReadLine();
                if (AcelerationVar == "v")
                {
                    Console.WriteLine("enter initial velocity");
                    GetAceleration.x = double.TryParse(Console.ReadLine(), out double x) ? x : 0;

                    Console.WriteLine("enter aceleration");
                    GetAceleration.a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    GetAceleration.t = Convert.ToDouble(Console.ReadLine());

                    GetAceleration.avtFinal();
                }

                else if (AcelerationVar == "x")
                {
                    Console.WriteLine("enter final velocity");
                    GetAceleration.v = double.TryParse(Console.ReadLine(), out double v) ? v : 0;

                    Console.WriteLine("enter aceleration");
                    GetAceleration.a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    GetAceleration.t = Convert.ToDouble(Console.ReadLine());

                    GetAceleration.avtInitial();
                }

                else if (AcelerationVar == "a")
                {
                    Console.WriteLine("enter final velocity");
                    GetAceleration.v = double.TryParse(Console.ReadLine(), out double v) ? v : 0;

                    Console.WriteLine("enter initial velocity");
                    GetAceleration.x = double.TryParse(Console.ReadLine(), out double x) ? x : 0;

                    Console.WriteLine("enter time");
                    GetAceleration.t = Convert.ToDouble(Console.ReadLine());

                    GetAceleration.avtAceleration();
                }

                else if (AcelerationVar == "t")
                {
                    Console.WriteLine("enter final velocity");
                    GetAceleration.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    GetAceleration.x = double.TryParse(Console.ReadLine(), out double x) ? x : 0;

                    Console.WriteLine("enter aceleration");
                    GetAceleration.a = Convert.ToDouble(Console.ReadLine());

                    GetAceleration.avtTime();
                }

                else
                {
                    GetAceleration.Move();
                }
            }

            else if (MovementType == "timeless")
            {
                var GetTimeless = new Movement.Timeless();
                Console.WriteLine("select var");
                string TimelessVar = Console.ReadLine();
                if (TimelessVar == "v")
                {
                    Console.WriteLine("enter initial velocity");
                    GetTimeless.x = double.TryParse(Console.ReadLine(), out double x) ? x : 0;

                    Console.WriteLine("enter aceleration");
                    GetTimeless.a=Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter distance");
                    GetTimeless.s = Convert.ToDouble(Console.ReadLine());

                    GetTimeless.asFinal();
                }

                else if (TimelessVar == "x")
                {
                    Console.WriteLine("enter final velocity");
                    GetTimeless.v = double.TryParse(Console.ReadLine(), out double v) ? v : 0;

                    Console.WriteLine("enter aceleration");
                    GetTimeless.a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter distance");
                    GetTimeless.s = Convert.ToDouble(Console.ReadLine());

                    GetTimeless.asInitial();
                }

                else if (TimelessVar == "a")
                {
                    Console.WriteLine("enter final velocity");
                    GetTimeless.v = double.TryParse(Console.ReadLine(), out double v) ? v : 0;

                    Console.WriteLine("enter initial velocity");
                    GetTimeless.x = double.TryParse(Console.ReadLine(), out double x) ? x : 0;

                    Console.WriteLine("enter distance");
                    GetTimeless.s = Convert.ToDouble(Console.ReadLine());

                    GetTimeless.asAceleration();
                }

                else if (TimelessVar == "s")
                {
                    Console.WriteLine("enter final velocity");
                    GetTimeless.v = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    GetTimeless.x = double.TryParse(Console.ReadLine(), out double x) ? x : 0;

                    Console.WriteLine("enter aceleration");
                    GetTimeless.a = Convert.ToDouble(Console.ReadLine());

                    GetTimeless.asDistance();
                }
                
                else
                {
                    GetTimeless.Move();
                }
            }

            else if (MovementType == "distance")
            {
                var GetDistance = new Movement.Distance();
                Console.WriteLine("select var");
                string DistanceVar = Console.ReadLine();

                if (DistanceVar == "s")
                {
                    Console.WriteLine("enter initial velocity");
                    GetDistance.u = double.TryParse(Console.ReadLine(), out double u) ? u : 0;

                    Console.WriteLine("enter time");
                    GetDistance.t = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter aceleration");
                    GetDistance.a = Convert.ToDouble(Console.ReadLine());

                    GetDistance.at2Distance();
                }

                else if (DistanceVar == "v")
                {
                    Console.WriteLine("enter distance");
                    GetDistance.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter time");
                    GetDistance.t = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter aceleration");
                    GetDistance.a = Convert.ToDouble(Console.ReadLine());

                    GetDistance.at2Velocity();
                }

                else if (DistanceVar == "t")
                {
                    Console.WriteLine("enter distance");
                    GetDistance.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    GetDistance.u = double.TryParse(Console.ReadLine(), out double u) ? u : 0;

                    Console.WriteLine("enter aceleration");
                    GetDistance.a = Convert.ToDouble(Console.ReadLine());

                    GetDistance.at2Time();
                }

                else if (DistanceVar == "aceleration") 
                {
                    Console.WriteLine("enter distance");
                    GetDistance.s = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("enter initial velocity");
                    GetDistance.u = double.TryParse(Console.ReadLine(), out double u) ? u : 0;

                    Console.WriteLine("enter time");
                    GetDistance.t = Convert.ToDouble(Console.ReadLine());

                    GetDistance.at2Aceleration();
                }

                else
                {
                    GetDistance.Move();
                }
            }

            else if (MovementType == "fall")
            {
                var GetFall = new Movement.FreeFall();
                Console.WriteLine("fall with or without distance");
                string FallDistance = Console.ReadLine();
                if (FallDistance == "yes")
                {
                    Console.WriteLine("select var");
                    string FallVar = Console.ReadLine();
                    if (FallVar == "s")
                    {
                        Console.WriteLine("enter velocity");
                        GetFall.v = double.TryParse(Console.ReadLine(), out double v) ? v : 0;

                        Console.WriteLine("enter time");
                        GetFall.t = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter aceleration");
                        GetFall.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                        GetFall.FallDistance();
                    }
                    
                    else if (FallVar == "v")
                    {
                        Console.WriteLine("enter distance");
                        GetFall.s = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter time");
                        GetFall.t = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter aceleration");
                        GetFall.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                        GetFall.FallVelocity();
                    }

                    else if (FallVar == "t")
                    {
                        Console.WriteLine("enter distance");
                        GetFall.s = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter velocity");
                        GetFall.v = double.TryParse(Console.ReadLine(), out double v) ? v : 0;

                        Console.WriteLine("enter aceleration");
                        GetFall.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                        GetFall.FallTime();
                    }

                    else if (FallVar == "g")
                    {
                        Console.WriteLine("enter distance");
                        GetFall.s = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter velocity");
                        GetFall.v = double.TryParse(Console.ReadLine(), out double v) ? v : 0;

                        Console.WriteLine("enter time");
                        GetFall.t = Convert.ToDouble(Console.ReadLine());

                        GetFall.FallAceleration();
                    }
                }

                else
                {
                    Console.WriteLine("select var");
                    string FreeFallVar = Console.ReadLine();
                    if (FreeFallVar == "v")
                    {
                        Console.WriteLine("enter aceleration");
                        GetFall.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                        Console.WriteLine("enter time");
                        GetFall.t = Convert.ToDouble(Console.ReadLine());

                        GetFall.FreeFallVelocity();
                    }

                    else if (FreeFallVar == "g")
                    {
                        Console.WriteLine("enter velocity");
                        GetFall.v = double.TryParse(Console.ReadLine(), out double v) ? v : 0;

                        Console.WriteLine("enter time");
                        GetFall.t = Convert.ToDouble(Console.ReadLine());

                        GetFall.FreeFallAceleration();
                    }

                    else if (FreeFallVar == "t")
                    {
                        Console.WriteLine("enter velocity");
                        GetFall.v = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("enter aceleration");
                        GetFall.g = double.TryParse(Console.ReadLine(), out double g) ? g : 9.82;

                        GetFall.FreeFallTime();
                    }
                }
            }
        }
    }
}
