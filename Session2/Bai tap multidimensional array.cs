using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class Bai_tap_multidimensional_array
    {
        public static void Main(string[] args)
        {
            baitap22();
        }
        static void PrintArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void baitap18()
        {
            Console.WriteLine("Input elements in the matrix: ");
            int[,] a = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"element - [{i}],[{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            PrintArray(a);
        }
        static void baitap19()
        {
            int n;
            int sum = 0;


            Console.Write(" Input the size of the square matrix ( less than 5): ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            int[,] b = new int[n, n];
            int[,] c = new int[n, n];
            Console.WriteLine("Input elements in the first matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"element - [{i}],[{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Input elements in the second matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"element - [{i}],[{j}]: ");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            Console.WriteLine(" The First matrix is: ");
            PrintArray(a);
            Console.WriteLine("The Second matrix is: ");
            PrintArray(b);
            Console.WriteLine("The Addition of two matrix is: ");
            PrintArray(c);
        }
        static void baitap20()
        {
            int n;
            int sum = 0;


            Console.Write(" Input the size of the square matrix ( less than 5): ");
            n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            int[,] b = new int[n, n];
            int[,] c = new int[n, n];
            Console.WriteLine("Input elements in the first matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"element - [{i}],[{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Input elements in the second matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"element - [{i}],[{j}]: ");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    c[i, j] = a[i, j] - b[i, j];
                }
            }
            Console.WriteLine(" The First matrix is: ");
            PrintArray(a);
            Console.WriteLine("The Second matrix is: ");
            PrintArray(b);
            Console.WriteLine("The Subtraction of two matrix is: ");
            PrintArray(c);
        }
        static void baitap21()
        {
            Console.Write("Input the rows and columns of first matrix:  ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            Console.Write("Input the rows and columns of second matrix:  ");
            int o = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int[,] b = new int[o, p];
            if (m != o)
            {
                Console.WriteLine("Error!");
                return;
            }
                int[,] c = new int[n,p];
                Console.WriteLine("Input elements in the first matrix: ");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"element - [{i}],[{j}]: ");
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Input elements in the second matrix: ");
                for (int i = 0; i < o; i++)
                {
                    for (int j = 0; j < p; j++)
                    {
                        Console.Write($"element - [{i}],[{j}]: ");
                        b[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < p; j++)
                    {
                    c[i, j] = 0;
                        for(int k = 0; k < m; k++) 
                        {
                        c[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
            Console.WriteLine(" The First matrix is: ");
            PrintArray(a);
            Console.WriteLine("The Second matrix is: ");
            PrintArray(b);
            Console.WriteLine("The multiplication of two matrix is: ");
            PrintArray(c);
        }
        static void baitap22()
        {
            Console.Write("Input the rows and columns of a matrix:  ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            int[,] c = new int[n, m];
            Console.WriteLine("Input elements in the first matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"element - [{i}],[{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    c[i,j] = a[j, i];
                }
            }
            Console.WriteLine("The matrix is: ");
            PrintArray(a);
            Console.WriteLine("The Transpose of two matrix is: ");
            PrintArray(c);
        }
    }
}
