using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SizikovSS.Sprint5.Task2.V7.Lib
{
    public class DataService : ISprint5Task2V7
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            {
                string path = Path.Combine(Path.GetTempPath(), @"C:\Users\simen\source\repos\Tyuiu.SizikovSS.Sprint5\OutPutFileTask2.csv");

                FileInfo fileInfo = new(path);
                bool fileExists = fileInfo.Exists;
                if (fileExists) File.Delete(path);

                string str = "";
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] % 2 != 0) matrix[i, j] = 0;

                        if (j != matrix.GetLength(1) - 1) str += matrix[i, j] + ";";
                        else str += matrix[i, j];
                    }
                    if (i != matrix.GetLength(0) - 1) File.AppendAllText(path, str + Environment.NewLine);
                    else File.AppendAllText(path, str);

                    str = "";
                }
                return path;
            }
        }
    }
}
