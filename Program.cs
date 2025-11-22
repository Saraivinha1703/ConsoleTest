
using ConsoleTest.Entities;

Random random = new();

Vehicle vehicle1 = new("Fiat", 200, 5);
Vehicle vehicle2 = new("Kawasaki", 250, 2);

SpeedCamera speedCamera = new(50, 120);

double v1SpeedValue = Math.Round(random.NextDouble() * vehicle1.MaxSpeed, 2);
double? v1Speed = v1SpeedValue < speedCamera.MinSpeed ? null : v1SpeedValue;

double v2SpeedValue = Math.Round(random.NextDouble() * vehicle2.MaxSpeed, 2);
double? v2Speed = v2SpeedValue < speedCamera.MinSpeed ? null : v2SpeedValue;

Console.WriteLine($"v1: {v1Speed} km/h | v2: {v2Speed} km/h\n\n");

if (v1Speed > speedCamera.MaxSpeed || v1Speed == null)
{
    Console.WriteLine("v1 got a ticket! (you idiot)\n\n");

    switch (v1Speed)
    {
        case > 120:
            Console.WriteLine("You got a ticket for being too fast!");
            break;
        case null:
            Console.WriteLine("You got a ticket for being a snail!");
            break;
        default:
            Console.WriteLine("Something went wrong...");
            break;
    }
}
else
{
    Console.WriteLine("No money for the government :( from v1\n\n");
}

if (v2Speed > speedCamera.MaxSpeed || v2Speed == null)
{
    Console.WriteLine("v2 got a ticket! (you idiot)\n\n");

    switch (v2Speed)
    {
        case > 120:
            Console.WriteLine("You got a ticket for being too fast!");
            break;
        case null:
            Console.WriteLine("You got a ticket for being a snail!");
            break;
        default:
            Console.WriteLine("Something went wrong...");
            break;
    }
}
else
{
    Console.WriteLine("No money for the government :( from v2");
}