using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    public abstract class Movement
    {
        // AVerage Velocity
        // Velocity
        // Acceleration
        // Distance
        // Time

        public abstract class Velocity : Movement
        {
            public abstract void VelocityMaster();
            public class Average : Velocity
            {
                public double v;

                public double s;
                public double t;

                public override void VelocityMaster()
                {
                    v = s / t;
                    Console.WriteLine("average velocity = " + v);
                }
            }

            public class Master : Velocity
            {
                public double v;

                public double x;
                public double a;
                public double t;

                public override void VelocityMaster()
                {
                    v = x + (a * t);
                    Console.WriteLine("velocity = " + v);
                    // x = v - at
                }
            }

            public class Timeless : Velocity
            {
                public double v;

                public double x;
                public double a;
                public double s;

                public double u; // Exeption rule 

                public override void VelocityMaster()
                {
                    v = Math.Sqrt(Math.Pow(x, 2) + (2 * a * s));

                    if (u > 0)
                    {
                        x = u;
                    }

                    //
                    Console.WriteLine("velocity = " + v);
                }
            }

                // OLD
                /*public double Vm;
                public double v;
                public double x;
                public double a;
                public double s;
                public double t;

                public double u;*/
/*
                public void svtInitialVelocity()
                // x = v - s / t
                {
                    Console.WriteLine("x = v - s / t");

                    x = v - (s / t);
                    Console.WriteLine("initial velocity = " + x);
                }

                public void InitialVelocityAcceleration()
                // x = v - at
                {
                    Console.WriteLine("x = v - at");

                    x = v - (a * t);
                    Console.WriteLine("initial velocity = " + x);
                }

                public void TimelessInitialVelocity()
                // x = (v^2 - 2as)^0.5
                {
                    Console.WriteLine("x = (v^2 - 2as)^0.5");

                    x = Math.Sqrt(Math.Pow(v, 2) - (2 * a * s));
                    Console.WriteLine("initial velocity = " + x);
                }

                public void InitialVelocityDIstance()
                // u = s/t - at/2
                {
                    Console.WriteLine("u = s / t - at / 2");

                    u = (s / t) - ((a * t) / 2);
                    Console.WriteLine("initial velocity = " + u);
                }

                public void ConditionalInitialVelocity()
                // x = Vm - 2v
                {
                    Console.WriteLine("x = Vm - 2v");

                    x = Vm - (2 * v);
                    Console.WriteLine("initial velocity = " + x);
                }
*/
            }
        }
        /*
        public class Acceleration : Movement
        {
            public double Vm;
            public double v;
            public double x;
            public double a;
            public double s;
            public double t;

            public double u;

            public void GeneralAcceleration()
            {
                Console.WriteLine("a = (v - x) / t");

                a = (v - x) / t;
                Console.WriteLine("acceleration = " + a);
            }

            public void TimelessAcceleration()
            {
                Console.WriteLine("a = (v^2 - x^2) / 2s");

                a = (Math.Pow(v, 2) - Math.Pow(x, 2)) / (2 * s);
                Console.WriteLine("acceleration = " + a);
            }

            public void Aceleration_byDistance()
            {
                Console.WriteLine("a = 2(s - ut) / t^2");

                a = (2 * (s - (u * t))) / Math.Pow(t, 2);
                Console.WriteLine("acceleration = " + a);
            }
        }

        public class Distance : Movement
        {
            public double Vm;
            public double v;
            public double x;
            public double a;
            public double s;
            public double t;

            public double u;

            public void svtDIstance()
            //
            {
                if (x > 0)
                {
                    Console.WriteLine("s = (v - x) / t");

                    s = (v - x) / t;
                }
                else
                {
                    Console.WriteLine("s = v / t");

                    s = v / t;
                }

                Console.WriteLine("movement distance = " + s);
            }

            public void TimelessDistance()
            // s = (v^2 - x^2) / 2a
            {
                Console.WriteLine("s = (v^2 - x^2) / 2a");

                s = (Math.Pow(v, 2) - Math.Pow(x, 2)) / (2 * a);
                Console.WriteLine("distance = " + s);
            }

            public void DistanceCondition()
            // s = ut + (at^2)/2
            {
                Console.WriteLine("s = ut + (at^2)/2");

                s = (u * t) + (a * Math.Pow(t, 2)) / 2;
            }
        }

        public class Time : Movement
        {

            public double Vm;
            public double v;
            public double x;
            public double a;
            public double s;
            public double t;

            public double u;

            public void svt_Time()
            // t = s / (v - x)
            {
                if (x > 0)
                {
                    Console.WriteLine("t = s / (v - x)");

                    t = s / (v - x);
                }
                else
                {
                    Console.WriteLine("t = s / v");

                    t = s / v;
                }
                Console.WriteLine("movement time = " + t);
            }

            public void AccelerationTime()
            // t = (v - x) / a
            {
                Console.WriteLine("t = (v - x) / a");

                t = (v - x) / a;
                Console.WriteLine("movement time = " + t);
            }

            public void DistanceTime()
            // t = (-u + (u^2 + 2as)^0.5) /a
            {
                Console.WriteLine("t = (-u + (u^2 + 2as)^0.5) / a");

                t = (-u + Math.Sqrt(Math.Pow(u, 2) + (2 * a * s))) / a;
                Console.WriteLine("movement time = " + t);
            }
        }*/


        /*public class Velocity : Movement
        {
            public double s;
            public double v;
            public double t;

            public void svtDistance()
            {
                Console.WriteLine("s = vt");

                s = v * t;
                Console.WriteLine("distance = " + s);
            }

            public void svtVelocity()
            {
                Console.WriteLine("v = s / t");

                v = s / t;
                Console.WriteLine("velocity = " + v);
            }

            public void svtTime()
            {
                Console.WriteLine("t = s / v");

                t = s / v;
                Console.WriteLine("time = " + t);
            }
        }*/
}
