using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BiggestOfThree
    {
        public void Main()
        {
            int number1, number2, number3;

            Console.WriteLine("Enter the first value");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third value");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The biggest value is "+Biggest(number1,number2,number3));

            Console.WriteLine("Now using Ternary operator");

            Console.WriteLine("The biggest value is " + BiggestUsingTernary(number1, number2, number3));
        }

        int Biggest(int num1, int num2, int num3)
        {
            int big = num1;

            if(big < num2) 
            {
                if(num2 > num3)
                {
                    big = num2;
                }
                else
                {
                    big = num3;
                }
            }
        
            return big;
        }

        int BiggestUsingTernary(int num1, int num2, int num3)
        {
            int big = 0;
             big = num1 > num2 ? num1 : num2;
             big = big > num3 ? big : num3;
            return big;
        }

    }
}
