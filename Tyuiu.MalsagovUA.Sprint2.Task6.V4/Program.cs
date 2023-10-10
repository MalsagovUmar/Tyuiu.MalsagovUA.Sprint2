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
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ds.FindCardSuit(value));
            Console.ReadKey();
        }
    }
}
