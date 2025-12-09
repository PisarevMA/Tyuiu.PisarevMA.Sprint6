using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PisarevMA.Sprint6.Task5.V21.Lib
{
    public class DataService : ISprint6Task5V21
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index++] = Convert.ToDouble(line);
                }
            }
            numsArray = numsArray.Where(x => Math.Abs(x) % 3 == 0).ToArray();
            return numsArray;
        }
    }
}
