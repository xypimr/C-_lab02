namespace task02
{
    class Program
    {
        static void Main()
        {
            Car audi = new Car(1600000, 180, 2020);
            audi.print();
            Plane aero32 = new Plane(3000000, 500, 2022, 480, 160);
            aero32.print();
            Ship gr2 = new Ship(49209342, 380, 2009, "mew", 420);
            gr2.print();
        }
    }
}