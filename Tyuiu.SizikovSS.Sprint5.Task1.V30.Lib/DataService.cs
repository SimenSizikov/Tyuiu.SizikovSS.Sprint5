using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SizikovSS.Sprint5.Task1.V30.Lib
{
    public class DataService : ISprint5Task1V30
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            double temp;
            string strtemp;

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;
            
            if (fileExists) File.Delete(path);

            for (int x = startValue; x <= stopValue; x++)
            {
                temp = Math.Round((Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x), 2);
                if (x == 1) temp = 0;

                strtemp = Convert.ToString(temp);

                if (x != stopValue) File.AppendAllText(path, strtemp + Environment.NewLine);
                else File.AppendAllText(path, strtemp);
            }
            return path;
        }
    }
}
