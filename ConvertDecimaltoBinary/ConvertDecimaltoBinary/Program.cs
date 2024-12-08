using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDecimaltoBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Decimal Number : ");
            int number1 = int.Parse(Console.ReadLine()); // input decimal number
            int i;
            int[] numberArray = new int[10]; // create integer array of 10 
            for (i = 0; number1 > 0; i++) // loop as long number1 > 0
            {
                numberArray[i] = number1 % 2; // store remaining of division in numberarray
                number1 = number1 / 2; // change value of number1 
            }
            Console.Write("Binary no ");
            for (i = i - 1; i >= 0; i--) // loop thru the array backword
            {
                Console.Write(numberArray[i]); // print array content next to each other
            }


        }
    }
}
