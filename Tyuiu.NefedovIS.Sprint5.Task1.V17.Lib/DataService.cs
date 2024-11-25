using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NefedovIS.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutputFileTask1.txt");
            double y;
            string strY;
            string s = "";
            for (int x = startValue; x  < stopValue; x++)
            {
                y = Math.Round(2 * x - 4 + (2 * x - 1) / (Math.Sin(x) + 1), 2);
                strY = Convert.ToString(y);

                if (Math.Sin(x) + 1 == 0) {
                    File.AppendAllText(path, 0 + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }

            }
            return s;
        }
    }
}
