using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanKata
{
    public enum PlanetsName { Mercury = 0, Venus, Tellus, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto }
    public interface IPlanet : IEquatable<IPlanet>, IComparable<IPlanet>
    {
        public PlanetsName Name { get; set; }
        public double Mass { get; set; }
        public string Material { get; set; }
        public int AmountOfMoons { get; set; }
        public bool HasRings { get; set; }

        public void RandomInit();
    }
}
