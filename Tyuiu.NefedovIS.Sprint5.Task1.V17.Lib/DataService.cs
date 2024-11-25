using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NefedovIS.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            //string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string strY;
            string s = "";
            for (int x = startValue; x  < stopValue; x++)
            {
                y = Math.Round(2 * x - 4 + (2 * x - 1) / (Math.Sin(x) + 1), 2);
                strY = Convert.ToString(y);

                if (x != stopValue) {
                    File.AppendAllText(path, strY + "\n");
                    //Console.WriteLine(strY);
                }
                else
                {
                    File.AppendAllText(path, strY);
                    //Console.Write(strY);
                }

            }
            return s;
        }
    }
}
