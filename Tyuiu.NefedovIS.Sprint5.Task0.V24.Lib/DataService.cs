using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.NefedovIS.Sprint5.Task0.V24.Lib
{
    public class DataService : ISprint5Task0V24
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutputFileTask0.txt");
            //string path = $@"{Directory.GetCurrentDirectory()}\OutputFileTask0.txt";
            double z = (Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2));
            File.WriteAllText(path, Convert.ToString(Math.Round(z, 3)));
            return path;
        }
    }
}
