using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing10._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            // Declare the array of two elements.
            int[][] arr = new int[m][];
            Random rd = new Random();
            //int c = rd.Next(1, 10);

            // Initialize the elements.
            for(int i = 0; i < m; i++)
            {
                arr[i] = new int[] { };
            }
            //arr[0] = new int[3] { 5, 4, 7 };
            //arr[1] = new int[5] { 1, 7, 9, 0, 2 };
            //arr[2] = new int[4] { 7, 5, 8, 0 };
            //arr[3] = new int[2] { 7, 9 };

            // Display the array elements.
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

    }
}
