namespace task03;

internal class Program
{
    private static void Main(string[] args)
    {
        const string PRO_KEY = "pro";
        const string EXP_KEY = "exp";

        void docWork<T>(T arg_class)
        {
            Console.WriteLine("Что вы хотите сделать? \n 0 - открыть \n 1 - отредактировать; \n 2 - сохранить");
            var arg = Convert.ToInt32(Console.ReadLine());
            dynamic type = arg_class;
            switch (arg)
            {
                case 0:
                    type.OpenDocument();
                    break;
                case 1:
                    type.EditDocument();
                    break;
                case 2:
                    type.SaveDocument();
                    break;
                default:
                    Console.WriteLine("Неверное значение аргумента!");
                    break;
            }
        }

        Console.WriteLine("Введите лицензионный ключ: (если у вас его нет нажмите 'Enter')");
        var key = Console.ReadLine();


        if (key == PRO_KEY)
        {
            var pro = new ProDocumentWorker();
            docWork(pro);
        }
        else if (key == EXP_KEY)
        {
            var exr = new ExpertDocumentWorker();
            docWork(exr);
        }
        else
        {
            var doc = new DocumentWorker();
            docWork(doc);
        }
    }
}