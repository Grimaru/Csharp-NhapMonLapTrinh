using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing14
{
    class Program
    {
        static string NumberInWords (long n, int Position)
        {
                switch (n)
                {
                    case 0:
                            if (Position == 0) return "Muoi";
                            else if (Position == 1) return "";
                            else if (Position == 2) return "";
                            else return "";
                    case 1:
                            if (Position == 0) return "Mot";
                            else if (Position == 1) return "Muoi";
                            else if (Position == 2) return "Mot";
                            else if (Position == 3) return "Mot";
                            else if (Position == 4) return "Muoi";
                            else if (Position == 5) return "";
                            else if (Position == 6) return "Mot";
                            else if (Position == 7) return "Muoi";
                            else if (Position == 8) return "Mot";
                            else if (Position == 9) return "Mot";
                            else return "Muoi";

                    case 2: return "Hai";
                    case 3: return "Ba";
                    case 4: return "Bon";
                    case 5: return "Nam";
                    case 6: return "Sau";
                    case 7: return "Bay";
                    case 8: return "Tam";
                    case 9: return "Chin";
                }          
                return " ";
        }

        static string And (int Position, long du)
        {           
                switch (Position)
                {
                    case 0:
                    if (du == 0) return "";
                    else return "";

                    case 1:
                    if (du == 0) return "";
                    else return "";

                    case 2: 
                        if (du == 0) return "Le";                            
                        else return "Muoi";

                    case 3: 
                        if (du == 0) return "";                           
                        else return "Tram";

                    case 4:
                        if (du == 0) return "Ngan";
                        else return "Ngan";

                    case 5:
                        if (du == 0) return "";
                        else return "Muoi";

                    case 6: 
                        if (du == 0) return "";
                        else return "Tram";

                    case 7: 
                        if (du == 0) return "Trieu";
                        else return "Trieu";

                    case 8: 
                        if (du == 0) return "";
                        else return "Muoi";

                    case 9:
                        if (du == 0) return "";
                        else return "Tram";

                    case 10:
                        if (du == 0) return "Ty";
                        else return "Ty";
                }
                return " ";


        }
        static void Main(string[] args)
        {
            long n, du;
            string chuoi = " ";
            Console.Write("Nhap n: ");
            n = long.Parse(Console.ReadLine());
            int Position = 1;
            while (n != 0)
            {
                du = n % 10;
                chuoi = NumberInWords(du, Position) + " " + And(Position, du) + " " + chuoi;
                n = n / 10;
                Position += 1;
            }
            Console.WriteLine(chuoi);
            Console.ReadKey();
        }
    }
}
