using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SwappingOfTwo
    {
        public void Main()
        {
            int number1, number2;

            Console.WriteLine("Enter the first value");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The numbers are  number1 = {number1} and number2 ={number2}");

            Swapping(number1, number2);
        }

        void Swapping(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine($"The swapped numbers are  number1 = {num1} and number2 ={num2}");
        }
    }
}
