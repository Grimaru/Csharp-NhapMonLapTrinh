using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing14._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ChangePlate(n, 'A', 'C', 'B');
            Console.ReadKey();            
        }

        static void ChangePlate(int n, char Begin, char End, char Temp)
        {
            if (n==1)
            {
                Console.WriteLine($"Change 1 from {Begin} to {End}");
            }
            else
            {
                ChangePlate(n - 1, Begin, Temp, End);

                Console.WriteLine($"Chang 1 from {Begin} to {End}");

                ChangePlate(n - 1, Temp, End, Begin);
            }
          
        }

    }
}
