namespace task02;

public class Ship : Vehicle
{
    string port;
    int passegers;
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