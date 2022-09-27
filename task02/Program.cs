namespace task02;

internal class Program
{
    private static void Main()
    {
        var audi = new Car(1600000, 180, 2020);
        audi.print();
        var aero32 = new Plane(3000000, 500, 2022, 480, 160);
        aero32.print();
        var gr2 = new Ship(49209342, 380, 2009, "mew", 420);
        gr2.print();
    }
}