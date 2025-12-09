using Tyuiu.PisarevMA.Sprint6.Task4.V22.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            int start = -5;
            int stop = 5;
            DataService ds = new DataService();
            double[] wait = { 8.04, 6.68, 4.84, 1.76, 0.45, 0.50, -0.87, -2.42, -3.88, -6.83, -8.88 };
            double[] res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
