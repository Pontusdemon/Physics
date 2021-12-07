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
            else if (Subject == "thermo")
            {
                var GetTHermoSelector = new ThermoPhysicSelector();
                GetTHermoSelector.ThermoSetup();
            }
            else if (Subject == "force")
            {
                var GetForceSelector = new ForceSelector();
                GetForceSelector.SelectForce();
            }
        }
    }
}
