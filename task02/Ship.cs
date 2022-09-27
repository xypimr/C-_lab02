namespace task02;

public class Ship : Vehicle
{
    private readonly int passegers;
    private readonly string port;

    public Ship(int count, int speed, int year, string port, int passegers) : base(count, speed, year)
    {
        this.port = port;
        this.passegers = passegers;
    }

    public override void print()
    {
        Console.WriteLine("ship");
        base.print();
        Console.WriteLine($"port: {port} passegers: {passegers}");
    }
}