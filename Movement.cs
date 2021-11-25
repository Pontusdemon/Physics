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
                public double v;
                public double s;
                public double t;
                public double a;
                public double vm;
                public double x;

                public void svtAverageVelocity()
                {
                    v = s / t;
                    Console.WriteLine("average velocity = " + v);
                }

                public void AverageVelcoityAceleration()
                {
                    v = a * t;
                    Console.WriteLine("average velocity");
                }

                public void AverageVelocity_m()
                {
                    Console.WriteLine("vm = (x + v) / 2");

                    vm = (x + v) / 2;
                    Console.WriteLine("average velocity = " + vm);
                }
            }

            public class Final : Velocity
            {
                public double v;
                public double x;
                public double a;
                public double t;
                public double s;
                public double vm;

                public void svtFinalVelocity()
                {
                    Console.WriteLine("v = x + s / t");

                    v = x + (s / t);
                    Console.WriteLine("final velocity = " + v);
                }

                public void GeneralFinalVelocity()
                {
                    Console.WriteLine("v = x + at");

                    v = x + (a * t);
                    Console.WriteLine("final velocity = " + v);
                }

                public void FinalVelocity2as()
                {
                    Console.WriteLine("v=(x^2 + 2as)^0.5");

                    v = Math.Sqrt(Math.Pow(x, 2) + (2 * a * s));
                    Console.WriteLine("final velocity = " + v);
                }

                public void FinalVelocityv_m()/////
                {
                    Console.WriteLine("v = vm - 2x");

                    v = vm - (2 * x);
                    Console.WriteLine("final velocity = " + v);
                }
            }

            public class Initial : Velocity
            {
                public double x;
                public double v;
                public double s;
                public double t;
                public double a;
                public double u;
                public double vm;

                public void svtInitialVelocity()
                {
                    Console.WriteLine("x = v - s / t");

                    x = v - (s / t);
                    Console.WriteLine("initial velocity = " + x);
                }

                public void AcelerationInitialVelocity()
                {

                }

                public void TimelessInitialVelocity()
                {

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

        public class Aceleration : Movement 
        {
            public double v;
            public double x;
            public double a;
            public double t;

            public void avtFinal()
            {
                Console.WriteLine("v = x + at");

                v = x + (a * t);
                Console.WriteLine("final velocity = " + v);
            }

            public void avtInitial()
            {
                Console.WriteLine("x = v - at");

                x = v - (a * t);
                Console.WriteLine("initial velocity = " + x);
            }

            public void avtAceleration()
            {
                Console.WriteLine("a = (v - x) / t");

                a = (v - x) / t;
                Console.WriteLine("aceleration = " + a);
            }

            public void avtTime()
            {
                Console.WriteLine("t = (v - x) / a");

                t = (v - x) / a;
                Console.WriteLine("time = " + t);
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

                var GetFinalVelocity = new Movement.Aceleration();
                GetFinalVelocity.v = u + (a * t);
                Console.WriteLine("final velocity = " + GetFinalVelocity.v);
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
