using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.BogdanovaSA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность элесентов массива = " + DataService.SubstractionArray(numsArray));
            Console.WriteLine("Произведение элесентов массива = " + DataService.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
    }
}
