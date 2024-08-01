using System;

namespace Testing5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("Nhap so dong m: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so dong n: ");
            n = int.Parse(Console.ReadLine());
            int [,] a = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine();
            }

            

        }

        


    }
}
