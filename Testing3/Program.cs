using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Testing3
{
    class Program
    {
        //static void Bai1CountChar(string s, int[] count)
        //{
        //    string str = s.ToUpper();
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] != ' ')
        //        {
        //            count[str[i]]++;
        //        }                
        //    }
        //    Console.WriteLine("- Cac ki tu trong chuoi la: ");
        //    for(int i = 'A'; i <= 'Z'; i++)
        //    {
        //        if(count[i] > 0)
        //        {
        //            Console.WriteLine($"{(char)i}: {count[i]}");
        //        }
        //    }
        //}
        //static void Bai1FindChar(int[] count)
        //{
        //    int max = count['A'];
        //    char pos = 'A';
        //    for (int i = 'B'; i <= 'Z'; i++)
        //    {
        //        if (max < count[i])
        //        {
        //            max = count[i];
        //            pos = (char)i;
        //        }               
        //    }
        //    Console.WriteLine($"First Max Freq: {pos} ");
        //}
        //static void Main(string[] args)
        //{
        //    //Bai 1
        //    Console.Write("Enter s = ");
        //    string s = Console.ReadLine();
        //    int[] count = new int[91];
        //    Bai1CountChar(s, count);
        //    Bai1FindChar(count);


        //    //Bai 2
        //    string pathInp, pathOut;
        //    while(true)
        //    {
        //        Console.WriteLine("Enter duong dan: ");
        //        string path = Console.ReadLine();
        //        string pathInp = path + "\\Password.txt";
        //        string pathOut = path + "\\PassWordValidation.txt";
        //        if (File.Exists(pathInp) && File.Exists(pathOut))
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("File not found!");
        //        }
        //    }
        //    string result = "";
        //    using (StreamReader sr = new StreamReader(pathInp))
        //    {
        //        string line;
        //        while (line = sr.ReadLine() != null)
        //        {
        //            if (Bai2Contains8har(line) && ContainsLowerCase(line) && ContainsUpperCase(line) && ContrainsNumberCase(line)
        //                {
        //                result = result + $"{line}" : Yes\n;
        //            }
        //            else
        //            {
        //                result = result + $"{line}" : No\n;
        //            }
        //        }
        //    }
        //    using (StreamWriter sw = new StreamWriter(pathOut))
        //    {
        //        sw.WriteLine(result);
        //    }
        //    Console.WriteLine("Check password success!");

        //    //Bai3
        //    Console.WriteLine("Enter name: ");
        //    string name = Console.ReadLine();
        //    Console.WriteLine(TachHoTen(name));
        //    Console.ReadKey();
        }
    }
}
