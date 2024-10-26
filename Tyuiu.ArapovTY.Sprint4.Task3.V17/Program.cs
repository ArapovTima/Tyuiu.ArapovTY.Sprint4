using Tyuiu.ArapovTY.Sprint4.Task3.V17.Lib;
namespace Tyuiu.ArapovTY.Sprint4.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] { { 6, 4, 2, 2, 1 },
                                          { 3, 6, 5, 4, 1 },
                                          { 5, 2, 3, 1, 6 },
                                          { 8, 8, 4, 5, 3 },
                                          { 7, 4, 5, 1, 6 } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Арапов Т. Я. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Арапов Тимофей Яковлевич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Подсчитать сумму элементов 4 столбца двумерного массива.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Сумма элементов 4 столбца массива: " + res);
            Console.ReadKey();
        }
    }
}
