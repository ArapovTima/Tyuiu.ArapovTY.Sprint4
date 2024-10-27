using Tyuiu.ArapovTY.Sprint4.Task7.V12.Lib;
namespace Tyuiu.ArapovTY.Sprint4.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string str = "658932125478";
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Арапов Т. Я. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Арапов Тимофей Яковлевич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Преобразовать строку в матрицу и подсчитать сумму её нечётных чисел.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(n, m, str);
            Console.WriteLine("Сумма нечётных чисел: " + res);
            Console.ReadKey();
        }
    }
}
