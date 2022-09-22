namespace task02;

public class Plane : Vehicle
{
    int hight;
    int passeger;
    public Plane(int count, int speed, int year, int hight, int passeger) : base(count, speed, year)
    {
        this.hight = hight;
        this.passeger = passeger;
    }
    public override void print()
    {
        Console.WriteLine("plane");
        base.print();
        Console.WriteLine($"hight: {hight} passeger: {passeger}");
    }

}