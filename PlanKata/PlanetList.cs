using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanKata
{
    public class PlanetList : IPlanetList
    {
        List<IPlanet> _planets = new List<IPlanet>();

        public static class Factory
        {
            internal static IPlanetList CreatePlanetsList(int nrOfPlanets)
            {
                var planetList = new PlanetList();

                for (int i = 0; i < nrOfPlanets; i++)
                {
                    planetList._planets.Add(Planet.Factory.CreateRandomPlanets());
                }
                return planetList;
            }
        }

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _planets.Count; i++)
            {
                sRet += $"{_planets[i]}\n";
                if ((i +1 % 4 == 0))
                {
                    sRet += "\n";
                }
            }
            return sRet;
        }
        public IPlanet this[int idx]
        {
            get { return _planets[idx]; }
        } 

        public PlanetList() { }

        public int AmountOfRings()
        {
            int c = 0;
            foreach (var planet in _planets)
            {
                if (planet.HasRings == true)
                    c++;
            }
            return c;
        }

        public int Count() => _planets.Count;
        public void Sort() => _planets.Sort();

        public int Count(string material)
        {
            int c = 0;
            foreach (var planet in _planets)
            {
                if (planet.Material == material)
                    c++;
            }
            return 0;
        }

        public int TotalAmountOfMoons()
        {
            int moonCount = 0;
            for (int i = 0; i < _planets.Count; i++)
            {
                moonCount += _planets[i].AmountOfMoons;
            }
            return moonCount;
        }
    }
}
