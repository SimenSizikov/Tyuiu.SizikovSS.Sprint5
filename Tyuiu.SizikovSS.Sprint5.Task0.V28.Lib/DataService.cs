using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SizikovSS.Sprint5.Task0.V28.Lib
{
    public class DataService : ISprint5Task0V28
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), @"C:\Users\simen\source\repos\Tyuiu.SizikovSS.Sprint5\OutPutFileTask0.txt");
            double y = Math.Round(x * (Math.Sqrt(x+3)), 3);

            File.WriteAllText(path, Convert.ToString(y));

            return path;
        }
    }
}
