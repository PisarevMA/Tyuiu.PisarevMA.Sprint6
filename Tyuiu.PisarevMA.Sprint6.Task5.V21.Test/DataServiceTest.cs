using Tyuiu.PisarevMA.Sprint6.Task5.V21.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Files\InPutDataFileTask5V21.txt";

            Assert.IsTrue(File.Exists(path));

            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);

            double[] waitArray = { 12.000, -9.000 };

            CollectionAssert.AreEqual(waitArray, res);
        }
    }
}
