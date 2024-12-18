using Tyuiu.SizikovSS.Sprint5.Task1.V30.Lib;

namespace Tyuiu.SizikovSS.Sprint5.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();

            Console.Title = "Спринт #5 | Выполнил: Сизиков С. С. | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Сизиков С. С. | РППб-24-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = cos(x)+(sin(x)/2-2x)-4x (произвести табулирование)  *");
            Console.WriteLine("* f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку       *");
            Console.WriteLine("* деления на ноль. При делении на ноль вернуть значение 0. Результат      *");
            Console.WriteLine("* сохранить в текстовый файл OutPutFileTask1.txt и вывести на консоль в   *");
            Console.WriteLine("* таблицу. Значения округлить до двух знаков после запятой.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start, stop;

            do
            {
                Console.Write("Введите начальное значение: ");
                start = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите конечное значение: ");
                stop = Convert.ToInt32(Console.ReadLine());

                if (start > stop) Console.WriteLine("Начальное значение не может быть больше конечного, попробуйте ещё раз.");
            } while (start > stop);

            string path = ds.SaveToFileTextData(start,stop);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Ответ записан в файл по пути:\n" + path);
            Console.WriteLine("Значение выражения: \n" + File.ReadAllText(path));

            Console.WriteLine("***************************************************************************");
            Console.ReadLine();


        }
    }
}
