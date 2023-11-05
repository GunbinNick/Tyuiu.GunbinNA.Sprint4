using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint4.Task1.V27.Lib;
namespace Tyuiu.GunbinNA.Sprint4.Task1.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Тема: Одномерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("*Задание #4.1                                                             *");
            Console.WriteLine("*Вариант #27                                                              *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дан одномерный целочисленный массив на 10 элементов заполненный          *");
            Console.WriteLine("*значениями с клавиатуры в диапазоне от 1 до 9. Подсчитать произведение   *");
            Console.WriteLine("*четных элементов массива. { 8, 1, 4, 4, 1, 2, 3, 5, 1, 5}                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.Write("Введите кол-во элементво массива: ");
            len = int.Parse(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= array.Length - 1; i++)
                Console.Write(array[i] + "\t");

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            var res = ds.Calculate(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
