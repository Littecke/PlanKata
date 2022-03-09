using PlanKata;

/*
var planet1 = Planet.Factory.CreateRandomPlanets();
Console.WriteLine(planet1.ToString());

var planet2 = Planet.Factory.CreateRandomPlanets();
Console.WriteLine(planet2.ToString());

var planet3 = Planet.Factory.CreateRandomPlanets();
Console.WriteLine(planet3.ToString());

Console.WriteLine("\nAn unsorted list of 10 planets:\n");
var planets = PlanetList.Factory.CreatePlanetsList(10);
Console.WriteLine(planets);
Console.WriteLine("-------------------------");
*/
var planets = PlanetList.Factory.CreatePlanetsList(5, PlanetDelegate);

planets.Sort();
Console.WriteLine("A sorted list of 5 planets, sorted by Mass:\n");
Console.WriteLine(planets);

Console.WriteLine("----------------------------------------");
Console.WriteLine("The total amount of moons from the list of 5 planets is:");
Console.WriteLine(planets.TotalAmountOfMoons());

Console.WriteLine("--------------------------------------");
Console.WriteLine("The total amount of planets that has rings from the list of 5 planets is:");
Console.WriteLine(planets.AmountOfRings());

Console.WriteLine("--------------------------------------");
Console.WriteLine("The planets that is made of gas is:");
Console.WriteLine(planets.Count("Gas"));

Console.WriteLine($"\nFrist planet: {planets[0]}");
Console.WriteLine($"\nLast planet: {planets[4]}");

void PlanetDelegate(IPlanet planetDelegate)
{
    Console.WriteLine("!");
}