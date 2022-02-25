using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanKata
{
    public interface IPlanetList
    {
        /// <summary>
        /// Access an individual planet in an array style syntax
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public IPlanet this[int idx] { get; }

        /// <summary>
        /// Number of planets in the list
        /// </summary>
        /// <returns></returns>
        int Count();

        /// <summary>
        /// return how many planets that has a specifik material
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        int Count(string material);

        /// <summary>
        /// Number of rings in total of all planets
        /// </summary>
        /// <returns></returns>
        int AmountOfRings();

        /// <summary>
        /// Number of moons in total of all planets
        /// </summary>
        /// <returns></returns>
        int TotalAmountOfMoons();

        /// <summary>
        /// Sorts the list by Mass, Materials, AmountOfMoons, HasRings and lastly Name
        /// </summary>
        void Sort();
    }
}
