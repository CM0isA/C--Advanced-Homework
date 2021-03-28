using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            SolarSystem solarSystem = new SolarSystem();

            solarSystem.AddNewPlanet("Earth1");
            solarSystem.AddNewPlanet("Earth2");
            solarSystem.AddNewPlanet("Earth3");
            solarSystem.AddNewPlanet("Earth4");

            solarSystem.Print();
            Console.WriteLine();
            solarSystem.SwapPlanets(2, 3);

            solarSystem.Print();
            Console.WriteLine();
            solarSystem.ReversePlanets();

            solarSystem.Print();
            Console.WriteLine();
        }
    }
}
