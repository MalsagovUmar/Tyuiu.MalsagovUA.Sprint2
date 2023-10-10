﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MalsagovUA.Sprint2.Task6.V4.Lib
{
    public class DataService : ISprint2Task6V4
    {
        public string FindCardSuit(int value)
        {
            return value switch
            {
                1 => "пики",
                2 => "трефы",
                3 => "бубны",
                4 => "червы"
            };
        }
    }
}
