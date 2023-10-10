using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MalsagovUA.Sprint2.Task6.V4.Lib;
namespace Tyuiu.MalsagovUA.Sprint2.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Мальсагов У.А. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Мальсагов Умар Асланович | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая определяет название                         *");
            Console.WriteLine("* соответствующей масти, принимая от пользователя цифры.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Введите цифру (от 1 до 4 включительно):");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Ваша масть: {ds.FindCardSuit(n)}");
            Console.ReadKey();
        }
    }
}
