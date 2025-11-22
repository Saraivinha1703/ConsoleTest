
using ConsoleTest.Entities;

List<Vehicle> vehicles = [
    new("Mercedes", 250, 5, 30, 17),
    new("Fiat", 200, 5, 50, 15),
    new("BMW", 230, 5, 0, 18),
    new("GM", 240, 2, 4, 17),
    new("Honda", 250, 2, 25, 14),
    new("Lexus", 210, 5, 40, 18),
];

int maxRaceDistance = 100;

bool canRace = true;

do
{
    Console.WriteLine($"Insert the distance the vehicles are going to race in kilometers (max of {maxRaceDistance} km)");
    int raceDistance = int.Parse(Console.ReadLine()!);

    if (raceDistance > maxRaceDistance)
    {
        Console.WriteLine($"Invalid distance, the race distance must be under {maxRaceDistance}km\n");
        return;
    }

    foreach (Vehicle vehicle in vehicles)
    {
        int distanceToRun = raceDistance;
        Console.WriteLine(vehicle.Brand);

        while (vehicle.Fuel > 0 && distanceToRun > 0)
        {
            distanceToRun -= vehicle.KilometersPerLiter;
            vehicle.Fuel--;
        }

        if (distanceToRun > 0)
        {
            Console.WriteLine($"Missed {distanceToRun}km to finish the race.");
        }
        else
        {
            Console.WriteLine($"Finished the race with {vehicle.Fuel} liters in the tank.");
        }

        Console.WriteLine("\n-------------------------\n");
    }

    int count = 0;

    for (int i = 0; i < vehicles.Count; i++)
    {
        if (vehicles[i].Fuel > 0)
        {
            count++;
        }
    }

    if (count <= 1)
    {
        canRace = false;
    }

} while (canRace);