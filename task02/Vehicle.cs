namespace task02;

public class Vehicle
{
    public int count;
    public int speed;
    public int year;

    public Vehicle(int count, int speed, int year)
    {
        this.count = count;
        this.speed = speed;
        this.year = year;
    }

    public virtual void print()
    {
        Console.WriteLine($"count: {count} speed: {speed} yaer: {year} ");
    }
}