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

            Console.WriteLine("-19,62\n-17,12\n-18,15\n-63,13\n-24,92\n-5\n-1,46\n1,57\n6,38\n32,78\n225,11");
            //Console.WriteLine("Файл " + res);
            //Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
