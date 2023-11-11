using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint4.Task7.V1.Lib;

namespace Tyuiu.GunbinNA.Sprint4.Task7.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Тема: Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("*Задание #4.6                                                             *");
            Console.WriteLine("*Вариант #2                                                               *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дана строка из одноразрядных цифр '135792468'. Преобразуйте ее в матрицу *");
            Console.WriteLine("*3 на 3 и подсчитайте количество четных чисел                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            string str = "135792468";
            int[,] matrix = new int[3, 3];
            Console.WriteLine();

            int index = 0;
            Console.WriteLine("Матрица: ");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = int.Parse(str[index++].ToString());
                    Console.Write(matrix[i, j] + " ");
                    if (j == 2)
                        Console.WriteLine("\n");
                }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            var res = ds.Calculate(3, 3, str);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
