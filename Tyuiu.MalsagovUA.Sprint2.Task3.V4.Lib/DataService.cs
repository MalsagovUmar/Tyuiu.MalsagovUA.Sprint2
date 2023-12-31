﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MalsagovUA.Sprint2.Task3.V4.Lib
{
    public class DataService : ISprint2Task3V4
    {
        public double Calculate(double x)
        {
            double res; 
            if (x > 0)
            {
                res = x + Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                res = (Math.Pow(x, 2) + Math.Cos(Math.Pow(x, 2))) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2) + 12));
            }
            else if (x > -8 && x < 0)
            {
                res = Math.Pow(x - (1 / Math.Pow(x, 2)), x);
            }
            else
            {
                res = x + 10 * x - (1 / x);
            }
            return Math.Round(res, 3);
        }
    }
}
