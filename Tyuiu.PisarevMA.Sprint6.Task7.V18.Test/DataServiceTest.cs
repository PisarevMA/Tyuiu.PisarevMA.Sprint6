using Tyuiu.PisarevMA.Sprint6.Task7.V18.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile()
        {
            string paths = @"C:\Files\InPutDataFileTask7V18.csv";
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
