using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DatskiyDE.Sprint0.Task6.V0.Lib;

namespace Tyuiu.DatskiyDE.Sprint0.Task6.V0
{
    class Programm
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма массива = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность массива = " + DataService.SubtractionArray(numsArray));
            Console.WriteLine("Произведение массива = " + DataService.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
    }
}
