namespace task01;

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("study bad");
    }

    public override void Read()
    {
        Console.WriteLine("read bad");
    }

    public override void Write()
    {
        Console.WriteLine("write bad");
    }

    public override void Relax()
    {
        Console.WriteLine("relax bad");
    }
}