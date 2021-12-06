using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    public abstract class Movement
    {
        // Vm = average velocity
        // v = final velocity
        // x = initial velocity
        // a = acceleration
        // s = distance
        // t = time

        public class Velocity : Movement
        {

            public class Average : Velocity
            {
                public double Vm;
                public double v;
                public double x;
                public double a;
                public double s;
                public double t;

                public void GeneralAverageVelocity()
                // Vm = s / t
                {
                    Console.WriteLine("Vm = s / t");

                    Vm = s / t;
                    Console.WriteLine("average velocity = " + Vm);
                }

                public void AccelerationAverageVelocity()
                // Vm = at
                {
                    Console.WriteLine("Vm = a * t");

                    Vm = a * t;
                    Console.WriteLine("average velocity = " + Vm);
                }

                public void ConditionalAverageVelocity()
                // Vm = (x + v) / 2
                {
                    Console.WriteLine("Vm = (x + v) / 2");

                    Vm = (x + v) / 2;
                    Console.WriteLine("average velocity = " + Vm);
                }
            }


            public class Final : Velocity
            {
                public double Vm;
                public double v;
                public double x;
                public double a;
                public double s;
                public double t;

                public double u;

                public void svtFinalVelocity()
                // v = x + s/t
                {
                    Console.WriteLine("v = x - s/t");

                    v = x - (s / t);
                    Console.WriteLine("final velocity = " + v);
                }

                public void GeneralFinalVelocity()
                // v = x + at
                {
                    Console.WriteLine("v = x + at");

                    v = x + (a * t);
                    Console.WriteLine("final velocity = " + v);
                }

                public void TimelessFinalVelocity()
                // v = (x^2 + 2as)^0.5
                {
                    Console.WriteLine("v=(x^2 + 2as)^0.5");

                    if (u > 0)
                    {
                        x = u;
                    }

                    v = Math.Sqrt(Math.Pow(x, 2) + (2 * a * s));
                    Console.WriteLine("final velocity = " + v);
                }

                public void FinalVelocityCondition()
                // v = Vm - 2x
                {

                }
            }


            public class Initial : Velocity
            {
                public double x;
                public double v;
                public double a;
                public double t;
                public double s;
                public double u;

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
                    Console.WriteLine("x = v - a * t");

                    x = v - (a * t);
                    Console.WriteLine("initial velocity = " + x);
                }

                public void TimelessInitialVelocity()
                // x = (v^2 - 2as)^0.5
                {
                    Console.WriteLine("x = (v^^2 - 2as)^0.5");

                    x = Math.Sqrt(Math.Pow(v, 2) - (2 * a * s));
                    Console.WriteLine("initial velocity = " + x);
                }

                public void InitialVelocityDIstance()
                // x = s/t - at/2
                {
                    Console.WriteLine("u = s / t - at / 2");

                    u = (s / t) - ((a * t) / 2);
                    Console.WriteLine("initial velocity = " + u);
                }

                // x = Vm - 2v
            }
        }

        public class Acceleration : Movement
        {
            public double a;
            public double v;
            public double x;
            public double u;
            public double s;
            public double t;

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

            public void Acceleration_at2()
            {
                Console.WriteLine("a = 2(s - ut) / t^2");

                a = (2 * (s - (u * t))) / Math.Pow(t, 2);
                Console.WriteLine("acceleration = " + a);
            }
        }


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












        public class Distance : Movement
        {
            public double s;
            public double u;
            public double t;
            public double a;

            public void at2Distance()
            {
                Console.WriteLine("s = ut + (at^2) /2");

                s = (u * t) + ((a * Math.Pow(t, 2)) / 2);
                Console.WriteLine("distance = " + s);
            }

            public void at2Velocity()
            {
                Console.WriteLine("u = s/t - at/2");

                u = (s / t) - ((a * t) / 2);
                Console.WriteLine("initial velocity = " + u);
            }

            public void at2Time()
            {
                Console.WriteLine("t = (-u + (2as + u^2)^0.5) /a");

                t = (-u + Math.Sqrt((2 * a * s) + Math.Pow(u, 2))) / a;
                Console.WriteLine("time = " + t);
            }
        }
    }
}
