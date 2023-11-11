using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GunbinNA.Sprint4.Task6.V2.Lib;

namespace Tyuiu.GunbinNA.Sprint4.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #3 | Выполнил: Гунбин Н. А. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Тема: Класс Array                                                        *");
            Console.WriteLine("*Задание #4.6                                                             *");
            Console.WriteLine("*Вариант #2                                                               *");
            Console.WriteLine("*Выполнил: Гунбин Никита Анатольевич | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дан строковый массив данных ['Белый', 'Черный', 'Зеленый', 'Синий',      *");
            Console.WriteLine("*'Красный', 'Желтый', 'Фиолетовый'], используя класс Array, выведите      *");
            Console.WriteLine("*элементы массива, длина которых больше 5 символов                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            string[] week = new string[] {"Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };

            Console.WriteLine();

            Console.WriteLine("Массив: ");
            for (int i = 0; i < week.Length; i++)
                Console.Write(week[i] + " ");

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            var res = ds.Calculate(week);
            for (int i = 0; i < res.Length; i++)
                Console.Write(res[i] + " ");
            Console.ReadKey();
        }
    }
}
