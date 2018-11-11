using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int row= 3,col=3;
            string[][] matrix = new string[3][];
            matrix[0] = new string[3] { "Main","up","sub" };
            matrix[1] = new string[3] { "down", "center","up"};
            matrix[2] = new string[3] { "sub","down","main" };

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i==j)
                    {
                        Console.Write($"{matrix[i][j]}      ");
                    }
                    if (i<j)
                    {
                        Console.Write($"{matrix[i][j]}      ");
                    }
                    if (i>j)
                    {
                        Console.Write($"{matrix[i][j]}      ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}


