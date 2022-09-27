namespace task02;

public class Car : Vehicle
{
    public Car(int count, int speed, int year) : base(count, speed, year)
    {
    }

    public override void print()
    {
        Console.WriteLine("car");
        base.print();
    }
}