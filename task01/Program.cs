namespace task01
{
    public static class Program
    {
        static void Main()
        {
            ClassRoom classRoom1 = new ClassRoom(new ExelentPupil(), new GoodPupil(), new BadPupil());
            classRoom1.Info();
            // ClassRoom classRoom2 = new ClassRoom(new GoodPupil(), new BadPupil());
            // classRoom2.Info();
        }
    }
}