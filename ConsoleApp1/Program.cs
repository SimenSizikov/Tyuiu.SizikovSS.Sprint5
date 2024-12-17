using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputFile = @"C:\Users\simen\source\repos\Tyuiu.SizikovSS.Sprint5\OutPutFileTask0.txt";
            double x8 = 1;
            double result8 = 4 * Math.Pow(x8, 3) - 5 * Math.Pow(x8, 2) + 6 * x8 - 7;
            File.AppendAllText(outputFile, result8.ToString());
        }
    }
}
