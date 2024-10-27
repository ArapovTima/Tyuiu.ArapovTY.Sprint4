using Tyuiu.ArapovTY.Sprint4.Task6.V15.Lib;
namespace Tyuiu.ArapovTY.Sprint4.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Арапов Т. Я. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Арапов Тимофей Яковлевич | АСОиУб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Подсчитать количество элементов, длина которых меньше 7.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var slova = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i <= slova.Length - 1; i++)
            {
                Console.WriteLine(slova[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов, длина которых меньше 7:");
            int nums = ds.Calculate(slova);
            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
