using Tyuiu.NefedovIS.Sprint5.Task0.V24.Lib;
namespace Tyuiu.NefedovIS.Sprint5.Task0.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 3;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************\n");

            Console.WriteLine($"x = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
