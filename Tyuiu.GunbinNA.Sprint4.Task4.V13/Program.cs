using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint4.Task4.V13.Lib;

namespace Tyuiu.GunbinNA.Sprint4.Task4.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Тема: Двумерные массивы(ввод с клавиатуры)                               *");
            Console.WriteLine("*Задание #4.4                                                             *");
            Console.WriteLine("*Вариант #13                                                              *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дан двумерный целочисленный массив на 5 на 5 элементов, заполненный      *");
            Console.WriteLine("*значениями с клавиатуры в диапазоне от 3 до 7. Найдите сумму четных      *");
            Console.WriteLine("*элементов массива.                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int rows, columns;
            Console.Write("Введите кол-во строк массива: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов массива: ");
            columns = int.Parse(Console.ReadLine());
            int[,] array = new int[rows, columns];

            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите значение {i},{j} элемента массива: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив: ");
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
