using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing16._3
{
    class Program
    {
        static int[] x;
        static bool[] TheCol;
        static bool[] TheMajor;
        static bool[] TheMinor;
        static int count;

        static void Try(int i)
        {
            if (i >= 8)
            {
                XuatNghiem();
            }
            else
            {
                for (int j = 0; j <= 7; j++)
                {
                    if(TheCol[j] == false && TheMajor[i - j + 7] == false && TheMinor[i + j] == false)
                    {
                        x[i] = j;
                        TheCol[j] = true;
                        TheMajor[i - j + 7] = true;
                        TheMinor[i + j] = true;
                        Try(i + 1);
                        TheCol[j] = false;
                        TheMajor[i - j + 7] = false;
                        TheMinor[i + j] = false;
                    }                    
                }
            }

        }

        static void KhoiTaoGiaTri()
        {           
            x = new int[8];
            TheCol = new bool[8];
            TheMajor = new bool[15];
            TheMinor = new bool[15];
            for(int i = 0; i < TheCol.Length; i++)
            {               
                TheCol[i] = false;
            }
            for(int i = 0; i < TheMinor.Length; i++)
            {                
                TheMajor[i] = false;
                TheMinor[i] = false;
            }
            count = 1;
        }

        static void XuatNghiem()
        {
            Console.Write($"Solution {count++}: ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(x[i] + 1 + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            KhoiTaoGiaTri();
            Try(0);
        }
    }
}

