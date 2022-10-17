using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class MatrixArray
    {
        public void Main()
        {
            int[,] arr = new int[3, 3]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            FirstRowTraversal(arr);
            Console.WriteLine("\n");

            LastRowTraversal(arr);
            Console.WriteLine("\n");

            FirstColumnTraversal(arr);
            Console.WriteLine("\n");

            LastColumnTraversal(arr);
            Console.WriteLine("\n");

            PrimeDiagonalTraversal(arr);
            Console.WriteLine("\n");

            SecondDiagonalTraversal(arr);


        }

        private void FirstRowTraversal(int[,] arr)
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
            }
        }

        private void LastRowTraversal(int[,] arr)
        {
            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
            }
        }

        private void FirstColumnTraversal(int[,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine($"{arr[i, j]} ");
                }
            }
        }

        private void LastColumnTraversal(int[,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 2; j < 3; j++)
                {
                    Console.WriteLine($"{arr[i, j]} ");
                }
            }
        }

        private void PrimeDiagonalTraversal(int[,] arr)
        {
            int j = 0;

            for (int i = 0; i < 3; i++)
            {
                while(j == i)
                {   
                    Console.WriteLine($"{arr[i, j]} ");
                    j++;
                }
            }
        }

        private void SecondDiagonalTraversal(int[,] arr)
        {

            for (int i = 0; i < 3; i++)
            {
                for(int j= 0; j< 3; j++)
                {
                    if((i+j) == (2))
                    {
                        Console.WriteLine($"{arr[i, j]} ");
                    }
                }
            }
        }
    }
}
