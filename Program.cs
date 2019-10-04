using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong count, firstNumber = 0, secondNumber = 1, nestNumber;
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            for (count = 2; count < 1000; count++)
            {
                nestNumber = firstNumber + secondNumber;
                Console.WriteLine(nestNumber);

                firstNumber = secondNumber;
                secondNumber = nestNumber;
            }
            Console.ReadLine();
        }
    }
}
