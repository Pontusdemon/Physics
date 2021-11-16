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
            public double s;
            public double v;
            public double t;

            public void svtDistance()
            {
                Console.WriteLine("s = v * t");
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
        }

        public class Aceleration : Movement //
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
                Console.WriteLine("a = ( v - x ) / t");
                a = (v - x) / t;
                Console.WriteLine("acleration = " + a);
            }

            public void avtTime()
            {
                Console.WriteLine("t = ( v - x ) / a");
                t = (v - x) / a;
                Console.WriteLine("time = " + t);
            }
        }

        public class Timeless : Movement //
        {
            public double v;
            public double x;
            public double a;
            public double s;

            public void asFinal()
            {
                v = Math.Sqrt(Math.Pow(x, 2) + (2 * a * s));
                Console.WriteLine("final velocity = ");
            }

            public void asInitial()
            {
                x = Math.Sqrt(Math.Pow(v, 2) - (2 * a * s));
                Console.WriteLine("initial velocity = " + x);
            }

            public void asAceleration()
            {
                a = (Math.Pow(v, 2) - Math.Pow(x, 2) / (2 * s));
                Console.WriteLine("timeless aceleration = " + a);
            }

            public void asDistance()
            {
                s = (Math.Pow(v, 2) - Math.Pow(x, 2) / (2 * a));
                Console.WriteLine("timeless distance = " + s);
            }
        }
        public class Distance : Movement //redoo
        {
            public double s;
            public double u;
            public double t;
            public double a;

            public void at2Distance()
            {
                s = (u * t) + ((a * Math.Pow(t, 2)) / 2);
                Console.WriteLine("distance = " + s);
            }

            public void at2Velocity()
            {
                u = s / t - ((a * t) / 2);
                Console.WriteLine("initial velocity = " + u);
            }

            public void at2Time()
            {
                double t1 = (-u + Math.Sqrt(Math.Pow(u, 2) + 2 * a * s)) / a;
                Console.WriteLine("time 1 = " + t1);
                double t2 = (-u - Math.Sqrt(Math.Pow(u, 2) + 2 * a * s)) / a;
                Console.WriteLine("time 2 = " + t2);
            }

            public void at2Aceleration()
            {
                a = (2 * (s - (u * t))) / Math.Pow(t, 2);
                Console.WriteLine("aceleration = " + a);
            }
        }

        public class FreeFall : Movement
        {
            public double g;
            public double v;
            public double t;
            public double s;
            
            public void FallDistance() // option1
            {
                s = (v * t) + ((g * Math.Pow(t, 2)) / 2);
                Console.WriteLine("falldistance = " + s);
            }
            
            public void FallVelocity() //option1
            {
                v = s / t - ((g * t) / 2);
                Console.WriteLine("initial velocity = " + v);
            }

            public void FreeFallVelocity()
            {
                v = g * t;
                Console.WriteLine("velocity = " + v);
            }

            public void FallTime() // option1
            {
                double t1 = (-v + Math.Sqrt(Math.Pow(v, 2) + 2 * g * s)) / g;
                Console.WriteLine("time 1 = " + t1);
                double t2 = (-v - Math.Sqrt(Math.Pow(v, 2) + 2 * g * s)) / g;
                Console.WriteLine("time 2 = " + t2);
            }

            public void FreeFallTime()
            {
                t = v / g;
                Console.WriteLine("time = " + t);
            }

            public void FallAceleration() // option1
            {
                g = (2 * (s - (v * t))) / Math.Pow(t, 2);
                Console.WriteLine("fall aceleration = " + g);
            }

            public void FreeFallAceleration()
            {
                g = v / t;
                Console.WriteLine("aceleration = " + g);
            }
        }
    }
}
