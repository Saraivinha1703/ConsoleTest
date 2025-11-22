namespace ConsoleTest.Entities;

public class Vehicle(string brand)
{
    public Vehicle(string brand, float maxSpeed) : this(brand)
    {
        MaxSpeed = maxSpeed;
    }

    public Vehicle(string brand, float maxSpeed, int capacity) : this(brand, maxSpeed)
    {
        Capacity = capacity;
    }

    public Vehicle(string brand, float maxSpeed, int capacity, int fuel, int kilometersPerLiter) : this(brand, maxSpeed, capacity)
    {
        Fuel = fuel;
        KilometersPerLiter = kilometersPerLiter;
    }

    public string Brand { get; set; } = brand;
    public float MaxSpeed { get; set; }
    public int Capacity { get; set; }
    public int Fuel { get; set; }
    public int KilometersPerLiter { get; set; }
}
