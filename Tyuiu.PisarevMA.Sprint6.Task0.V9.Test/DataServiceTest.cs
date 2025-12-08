using Tyuiu.PisarevMA.Sprint6.Task0.V9.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(3);
            double wait = -2.56;

            Assert.AreEqual(wait, res);
        }
    }
}
