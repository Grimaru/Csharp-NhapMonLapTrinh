using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> dayDiem = new List<double>();
            DocDayDiem(dayDiem);
            Console.WriteLine(" " + dayDiem.Count);
            Console.WriteLine(" " + Math.Round(TinhTrungBinh(dayDiem),2));
            Console.ReadKey();
        }

        static void DocDayDiem(List<double> dayDiem)
        {
            double a = double.Parse(Console.ReadLine());
            while (a != -1)
            {
                dayDiem.Add(a);
                a = double.Parse(Console.ReadLine());
            }
        }

        static double TinhTrungBinh(List<double> dayDiem)
        {
            double sum = 0;
            double tb = 0;
            for (int i = 0; i < dayDiem.Count; i++)
            {
                sum += dayDiem[i];
                tb = sum / dayDiem.Count;
            }            
            return tb; 
        }
        
    }
}
