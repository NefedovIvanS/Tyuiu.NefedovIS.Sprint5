using Tyuiu.NefedovIS.Sprint5.Task7.V26.Lib;
namespace Tyuiu.NefedovIS.Sprint5.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask7"); //sss

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExists);
        }
    }
}