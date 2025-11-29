using System.IO;
using Tyuiu.UsoltsevGP.Sprint5.Task7.V16.Lib;
namespace Tyuiu.UsoltsevGP.Sprint5.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Глеб\AppData\Local\Temp\OutPutFileTask7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
