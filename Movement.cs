using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics
{
    public abstract class Movement
    {

        public class Velocity : Movement
        {

            public class Average : Velocity
            {
                public double Vm;
                public double s;
                public double t;
                public double x;
                public double v;

                public void AverageVelocity_svt()
                {
                    Console.WriteLine("Vm = s / t");

                    Vm = s / t;
                    Console.WriteLine("average velocity = " + Vm);
                }

                public void AverageVelocity_Vm()
                {
                    Console.WriteLine("Vm = (x + v) / 2");

                    Vm = (x + v) / 2;
                    Console.WriteLine("average velocity = " + Vm);
                }
            }


            public class Final : Velocity
            {
                public double v;
                public double x;
                public double a;
                public double t;
                public double s;
                public double u;

                public void GeneralFinalVelocity()
                {
                    Console.WriteLine("v = x + at");

                    if (u > 0)
                    {
                        x = u;
                    }

                    v = x + (a * t);
                    Console.WriteLine("final velocity = " + v);
                }

                public void TimelessFinalVelocity()
                {
                    Console.WriteLine("v=(x^2 + 2as)^0.5");

                    if (u > 0)
                    {
                        x = u;
                    }

                    v = Math.Sqrt(Math.Pow(x, 2) + (2 * a * s));
                    Console.WriteLine("final velocity = " + v);
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

                public void InitialVelocityAcceleration()
                {
                    Console.WriteLine("x = v - a * t");

                    x = v - (a * t);
                    Console.WriteLine("initial velocity = " + x);
                }

                public void TimelessInitialVelocity()
                {
                    Console.WriteLine("x = (v^^2 - 2as)^0.5");

                    x = Math.Sqrt(Math.Pow(v, 2) - (2 * a * s));
                    Console.WriteLine("initial velocity = " + x);
                }

                public void InitialVelocity_at2()
                {
                    Console.WriteLine("u = s / t - at / 2");

                    u = (s / t) - ((a * t) / 2);
                    Console.WriteLine("initial velocity = " + u);
                }
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

        public class Acceleration : Movement
        {
            public double a;
            public double v;
            public double x;
            public double u;
            public double s;
            public double t;

            public void GeneralAceleration()
            {
                Console.WriteLine("a = (v - x) / t");

                a = (v - x) / t;
                Console.WriteLine("acceleration = " + a);
            }

            public void Acceleration2as()
            {
                Console.WriteLine("a = (v^2 - x^2) / 2s");

                a = (Math.Pow(v, 2) - Math.Pow(x, 2)) / (2 * s);
                Console.WriteLine("acceleration = " + a);
            }
        }

       
        
        
        
        
        
        
        
        
        
        public class Timeless : Movement
        {
            public double v;
            public double x;
            public double a;
            public double s;

            public void asFinal()
            {
                Console.WriteLine("v^2 = x^2 + 2as");
                Console.WriteLine("v = (x^2 +2as)^0.5");

                v = Math.Sqrt(Math.Pow(x, 2) + (2 * a * s));
                Console.WriteLine("timeless final velocity = " + v);
            }

            public void asInitial()
            {
                Console.WriteLine("x^2 = v^2 - 2as");
                Console.WriteLine("x = (v^2 - 2as)^0.5");

                x = Math.Sqrt(Math.Pow(v, 2) - (2 * a * s));
                Console.WriteLine("initial velocity = " + x);
            }

            public void asAceleration()
            {
                Console.WriteLine("a = (v^2 - x^2) / 2s");

                a = (Math.Pow(v, 2) - Math.Pow(x, 2)) / (2 * s);
                Console.WriteLine("timeless aceleration = " + a);
            }

            public void asDistance()
            {
                Console.WriteLine("s = (v^2 - x^2) / 2a");

                s = (Math.Pow(v, 2) - Math.Pow(x, 2)) / (2 * a);
                Console.WriteLine("timeless distance = " + s);
            }
        }
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

            public void at2Aceleration()
            {
                Console.WriteLine("a = 2(s - ut) / t^2");

                a = (2 * (s - (u * t))) / Math.Pow(t, 2);
                Console.WriteLine("aceleration = " + a);
            }
        }
    }
}
