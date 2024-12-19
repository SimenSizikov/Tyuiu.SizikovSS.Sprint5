using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string outputFile = @"C:\Users\simen\source\repos\Tyuiu.SizikovSS.Sprint5\OutPutFileTask3.bin";
            double x10 = 5;
            double result10 = Math.Pow(x10, 4) - 4 * Math.Pow(x10, 3) + 6 * Math.Pow(x10, 2) - 8 * x10 + 10;
            using (BinaryWriter writer = new BinaryWriter(File.Open(outputFile, FileMode.Append)))
            {
                writer.Write(result10);
            }
        }
    }
}
