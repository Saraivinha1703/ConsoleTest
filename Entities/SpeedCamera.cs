namespace ConsoleTest.Entities;

public class SpeedCamera(float minSpeed, float maxSpeed)
{
    public float MinSpeed { get; set; } = minSpeed;
    public float MaxSpeed { get; set; } = maxSpeed;
}