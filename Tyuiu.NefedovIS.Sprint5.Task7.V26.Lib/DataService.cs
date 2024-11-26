using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NefedovIS.Sprint5.Task7.V26.Lib
{
    public class DataService : ISprint5Task7V26
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");
            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSave);
            }

            string strLine = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                line = line.Replace(",", " ,");
                line = line.Replace(".", " .");
                line = line.Replace("!", " !");
                string[] lineArr = line.Split(' ');
                foreach (string s in lineArr)
                {
                    Console.WriteLine(s);
                    if (((s[0] >= 'a' && s[0] <= 'z') || (s[0] >= 'A' && s[0] <= 'Z')))
                    {
                        strLine += " word";
                    }
                    else if ((s[0] == '!') || (s[0] == ',') || (s[0] == '.'))
                    {
                        strLine += s;
                    }
                    else
                    {
                        strLine += " " + s;
                    }
                }
                File.AppendAllText(pathSave, strLine.Trim());
                return pathSave;
            }
        }
    }
}
