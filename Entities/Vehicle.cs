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

    public string Brand { get; set; } = brand;
    public float MaxSpeed { get; set; }
    public int Capacity { get; set; }
}
