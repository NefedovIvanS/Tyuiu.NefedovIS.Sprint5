using Tyuiu.NefedovIS.Sprint5.Task6.V8.Lib;
namespace Tyuiu.NefedovIS.Sprint5.Task6.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/DataSprint5/InPutDataFileTask6V8.txt";
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************\n");

            Console.WriteLine($"Путь = {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
