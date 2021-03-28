using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class SolarSystem
    {
        private readonly List<string> Planets;

        public SolarSystem()
        {
            Planets = new List<string>();
        }

        public void AddNewPlanet(string planet)
        {
            Planets.Add(planet);
        }

        public void InsertPlanet(int index, string planet)
        {
            Planets.Insert(index, planet);
            Planets.Sort();
        }

        public void RemovePlanet(string planet)
        {
            Planets.Remove(planet);
        }
        public void ReplacePlanet(int index, string planet)
        {
            Planets[index] = planet;
        }

        public void SwapPlanets(int p1, int p2)
        {
            string aux = Planets[p1];
            Planets[p1] = Planets[p2];
            Planets[p2] = aux;
        }

        public void ReversePlanets()
        {
            Planets.Reverse();
        }

        public void Print()
        { 
            foreach(var a in Planets)
                Console.WriteLine(a);
        }


    }
}
