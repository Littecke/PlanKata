namespace PlanKata
{
    public class Planet : IPlanet
    {
        public PlanetsName Name { get; set; } 
        public double Mass { get; set; }
        public string Material { get; set; }
        public int AmountOfMoons { get; set; }
        public bool HasRings { get; set; }

        public int CompareTo(IPlanet other)
        {
            if (this.Mass != other.Mass)
            {
                return Mass.CompareTo(other.Mass);
            }
            if (this.Material != other.Material)
            {
                return Material.CompareTo(other.Material);
            }
            if(this.AmountOfMoons != other.AmountOfMoons)
            {
                return AmountOfMoons.CompareTo(other.AmountOfMoons);    
            }
            if(this.HasRings != other.HasRings)
            {
                return HasRings.CompareTo(other.HasRings);
            }
            return Name.CompareTo(other.Name);
        }
        public bool Equals(IPlanet other) => (this.Name, this.Material, this.Mass, this.AmountOfMoons, this.HasRings) == (other.Name, other.Material, other.Mass, other.AmountOfMoons, other.HasRings);
        public override bool Equals(object obj) => Equals(obj as IPlanet);
        public override int GetHashCode() => (Name, Material, Mass, HasRings, AmountOfMoons).GetHashCode();

        public void RandomInit()
        {
            var rnd = new Random();
            bool allOk = false;
            while (!allOk)
            {
                try
                {
                    double[] _mass = { 0.06, 0.81, 1.00, 0.11, 317.83, 95.16, 14.54, 17.15, 0.0022 };
                    string[] _material = "Rock, Gas, Hydrogen, Water,".Split(' ');
                    int[] _moons = {0, 9, 1, 2, 14, 28, 80 };

                    this.Name = (PlanetsName)rnd.Next((int)PlanetsName.Mercury, (int)PlanetsName.Pluto);
                    this.HasRings = rnd.Next(2) == 0;
                    this.Mass = _mass[rnd.Next(0, _mass.Length)];
                    this.Material = _material[rnd.Next(0, _material.Length)];
                    this.AmountOfMoons = _moons[rnd.Next(0, _moons.Length)];

                    allOk = true; 
                }
                catch
                {
                    Console.WriteLine("Does not work");
                }   
            }
        }
        public static class Factory 
        { 
            internal static IPlanet CreateRandomPlanets()
            {
                var planet = new Planet();
                planet.RandomInit();
                return planet;
            }
        }
        public override string ToString()
        {
            string hasRings;
            string moons;

            if (HasRings == true)
            {
                hasRings = "This planet has rings";
            }
            else hasRings = "This planet does not have rings around itself";
            if (AmountOfMoons == 0)
            {
                moons = "and it does NOT have any moons";
            }
            else if (AmountOfMoons == 1)
            {
                moons = "and it has one moon";
            }
            else moons = $"and it has {AmountOfMoons} moons";

            return $"The planet named {Name} is made of {Material} and has the mass of {Mass} kg of the earth \n{hasRings} {moons}\n";
        }
    } 
}
