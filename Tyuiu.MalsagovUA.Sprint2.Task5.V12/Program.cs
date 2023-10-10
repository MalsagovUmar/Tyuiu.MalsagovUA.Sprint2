using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MalsagovUA.Sprint2.Task5.V12.Lib;
namespace Tyuiu.MalsagovUA.Sprint2.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Мальсагов У.А. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Мальсагов Умар Асланович | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая вычисляет дату предыдущего дня              *");
            Console.WriteLine("* по заданным значениям пользователем (год, месяц, день).                 *");
            Console.WriteLine("* Заданный год является високосным.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Введите год (переменная g):");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите месяц (переменная m):");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите день (переменная n):");
            int n = Convert.ToInt32(Console.ReadLine());
            int res = Convert.ToInt32(ds.FindDateOfPreviousDay(g, m, n));
            Console.WriteLine($" Дата предыдущего дня: {res}");
            Console.ReadKey();
        }
    }
}
