using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NefedovIS.Sprint5.Task5.V12.Lib
{
    public class DataService : ISprint5Task5V12
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double plus = 0;
            double minus = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                line = line.Replace('.', ',');
                string[] stringArray = line.Split(' ');
                double[] numbers = Array.ConvertAll(stringArray, double.Parse);
                foreach (double x in numbers)
                {
                    if (x > 0)
                    {
                        plus += x;
                    }
                    else
                    {
                        minus += x;
                    }
                }
                res = plus - minus;
                return res;
            }
        }
    }
}
