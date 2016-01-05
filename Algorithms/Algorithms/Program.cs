using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] matrix = new int[10, 10];

            // Create random matrix
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = rnd.Next(0, 100);
                }
            }

            // Show original matrix
            ShowMatrix(matrix);
            
            // Detect zero value and change entire line
            for (int i = 0; i < matrix.GetLength(0); i++)
            {                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] == 0)
                    {
                        for (int x = 0; x < matrix.GetLength(1); x++)
                        {
                            matrix[i, x] = 0;
                        }
                        break;
                    }
                }                
            }

            // Show changed matrix
            ShowMatrix(matrix);

            Console.WriteLine("Algorithm finished!");
            Console.ReadLine();

        }

        static void ShowMatrix(int[,] matrix)
        {
            Console.WriteLine("**************");
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("Linha " + i + ":");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
        }

    }
}
