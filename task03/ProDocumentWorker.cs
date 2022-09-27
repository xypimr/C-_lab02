namespace task03;

public class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine(
            "Документ сохранен в старом формате, сохраненные в остальных форматах доступно в версии Expert");
    }
}