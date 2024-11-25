using Tyuiu.NefedovIS.Sprint5.Task1.V17.Lib;
namespace Tyuiu.NefedovIS.Sprint5.Task1.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************\n");

            Console.WriteLine($"start = {startValue}");
            Console.WriteLine($"stop = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine(res);
            //Console.WriteLine("Файл " + res);
            //Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
