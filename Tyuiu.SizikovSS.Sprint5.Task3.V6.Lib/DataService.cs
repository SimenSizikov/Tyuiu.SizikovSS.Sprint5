using tyuiu.cources.programming.interfaces.Sprint5;

using System.IO;

namespace Tyuiu.SizikovSS.Sprint5.Task3.V6.Lib
{
    public class DataService : ISprint5Task3V6
    {
        public string SaveToFileTextData(int x)
        {
            string outputFile = @"C:\Users\simen\source\repos\Tyuiu.SizikovSS.Sprint5\OutPutFileTask3.bin";

            string path = Path.Combine(Path.GetTempPath(), outputFile);

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(path);//

            double y = Math.Round( x/Math.Sqrt(Math.Pow(x,2)+x) , 3);

            using (BinaryWriter writer = new(File.Open(path, FileMode.Append)))
            {
                writer.Write(y);
            }
            return path;
        }
    }
}
