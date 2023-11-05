using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint4.Task0.V19.Lib;

namespace Tyuiu.GunbinNA.Sprint4.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Тема: Одномерные массивы (статический ввод)                              *");
            Console.WriteLine("*Задание #4.0                                                             *");
            Console.WriteLine("*Вариант #19                                                              *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дан одномерный целочисленный массив на 10 элементов заполненный          *");
            Console.WriteLine("*статическими значениями в диапазоне от 0 до 9. Подсчитать произведение   *");
            Console.WriteLine("*нечетных элементов массива. { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 }             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

            for (int i = 0; i <= array.Length - 1; i++)
                Console.WriteLine(array[i]+);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            var res = ds.GetMultOddArrEl(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
