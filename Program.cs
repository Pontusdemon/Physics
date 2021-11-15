using System;

namespace Physics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select subject");
            string Subject = Console.ReadLine();
            if (Subject == "movement")
            {
                var GetMovementSelector = new MovementSelector();
                GetMovementSelector.MovementSetup();
            }
            else if (Subject == "density")
            {
                var GetDensity = new Density();
                GetDensity.DensitySelector();
            }
            else if (Subject == "pressure")
            {
                var GetPressureSelector = new PressureSelector();
                GetPressureSelector.SelectPressure();
            }
            else if (Subject == "force")
            {

            }
        }
    }
}
