using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SizikovSS.Sprint5.Task1.V30.Lib
{
    public class DataService : ISprint5Task1V30
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            int count = 0;
            for (int x = startValue; x <= stopValue; x++) count++;
            double[] mass = new double[count];// массив на 11 ячеек
            int k = 0;
            string path = Path.Combine(Path.GetTempPath(), @"C:\Users\simen\source\repos\Tyuiu.SizikovSS.Sprint5\OutPutFileTask1.txt");
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    File.WriteAllText(path, Convert.ToString(0) + "\n");
                    mass[k] = 0;
                    continue;
                }
                y = Math.Round(( Math.Cos(x)+(Math.Sin(x)/2-2*x) + 2*x + 2 ), 2);
                File.AppendAllText(path, Convert.ToString(y) + "\n");
                mass[k] = Math.Round(((5 * x + 2.5) / (Math.Sin(x) + 2) + 2 * x + 2), 2);
                k++;
            }
            return path;
        }
    }
}
