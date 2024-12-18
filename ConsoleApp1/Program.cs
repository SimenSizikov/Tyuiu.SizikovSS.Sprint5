using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double start = 1, end = 3, step = 1;
            string outputFile = @"C:\\Users\\simen\\source\\repos\\Tyuiu.SizikovSS.Sprint5\OutPutFileTask1.txt";
            for (double x = start; x <= end; x += step)
            {
                double result = 5 * x - 3 * Math.Pow(x, 2) - 7;
                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    result = 0;
                }
                result = Math.Round(result, 2);
                File.AppendAllText(outputFile, $"{result}\n");
                Console.WriteLine($"{result}");
            }
        }
    }
}
