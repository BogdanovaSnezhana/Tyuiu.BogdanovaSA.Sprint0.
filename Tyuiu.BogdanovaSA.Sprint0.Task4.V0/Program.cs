﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.BogdanovaSA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WritrLine("A - B = " + DataService.Subsruction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));
            Console.WritrLine("A / B = " + DataService.Division(5, 0));
            Console.ReadKey();
        }
    }
}
