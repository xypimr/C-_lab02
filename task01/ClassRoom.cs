namespace task01;

public class ClassRoom
{
    private readonly Pupil[] PUPS;

    public ClassRoom(params Pupil[] PUPSL)
    {
        PUPS = (Pupil[])PUPSL.Clone();
    }

    public void Info()
    {
        foreach (var pup in PUPS)
        {
            Console.WriteLine("\n" + pup.GetType());
            pup.Study();
            pup.Read();
            pup.Write();
            pup.Relax();
        }
    }
}