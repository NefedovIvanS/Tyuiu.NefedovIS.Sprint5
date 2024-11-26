using Tyuiu.NefedovIS.Sprint5.Task7.V26.Lib;
namespace Tyuiu.NefedovIS.Sprint5.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/DataSprint5/InPutDataFileTask7V26.txt";
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************\n");

            Console.WriteLine($"Путь = {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.LoadDataAndSave(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
