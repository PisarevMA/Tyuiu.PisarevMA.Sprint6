using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PisarevMA.Sprint6.Task4.V22.Lib
{
    public class DataService : ISprint6Task4V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                double y = Math.Sin(i) + (Math.Cos(2 * i)) / 2 - 1.5 * i;
                res[count] = Math.Round(y, 2);
                count++;
            }
            return res;
        }
    }
}
