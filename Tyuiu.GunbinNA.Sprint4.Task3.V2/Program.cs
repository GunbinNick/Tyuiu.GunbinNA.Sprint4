using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint4.Task3.V2.Lib;

namespace Tyuiu.GunbinNA.Sprint4.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Тема: Одномерные массивы (генератор случайных чисел)                     *");
            Console.WriteLine("*Задание #4.3                                                             *");
            Console.WriteLine("*Вариант #17                                                              *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дан двумерный целочисленный массив на 5 на 5 элементов заполненный       *");
            Console.WriteLine("*статическими значениями в диапазоне от 1 до 8. Найдите сумму элементов   *");
            Console.WriteLine("*в четвертом столбце массива.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5] { { 6, 4, 2, 2, 1 }, { 3, 6, 5, 4, 1 }, { 5, 2, 3, 1, 6 }, { 8, 8, 4, 5, 3 }, { 7, 4, 5, 1, 6 } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length;
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

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
