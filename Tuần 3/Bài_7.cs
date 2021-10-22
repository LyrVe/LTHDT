using System;
using System.Collections.Generic;
using System.Text;

namespace Bài_7
{
    class program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.Write("Nhập kích cỡ ma trận vuông, n = ");
            int n = int.Parse(Console.ReadLine());
            double[,] matrix = new double [n, n];
            double sum = 0; 

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Nhập phần tử Matrix[{0}, {1}] = ", i, j);
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {https://github.com/LyrVe/LTHDT/blob/main/Tu%E1%BA%A7n%203/Program.cs
                        sum += matrix[i, j];
                    }    
                }
            }
            Console.Write("Tổng giá trị phần tử trên đường chéo chính = {0}", sum);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
