using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    class Program
    {    
        static int Bai6DaoNguocVaThayDau(int n)
        {
            int Reverse = 0;
            while (n != 0)
            {
                int LastNumber = n % 10;
                n /= 10;
                Reverse = Reverse * 10 + LastNumber;
            }
            Reverse *= -1;
            return Reverse;
        }
        static int Bai7TinhTongSoChanCuaSo(int n)
        {
            int Tongchan = 0;
            while (n != 0)
            {
                int LastNumber = n % 10;
                n /= 10;
                if (LastNumber % 2 == 0)
                {
                    Tongchan += LastNumber;
                }                           
            }
            return Tongchan;
        }
        static int Bai8TimSoLonNhatCuaSo(int n)
        {
            int Max = 0;
            while (n != 0)
            {
                int LastNumber = n % 10;
                n /= 10;
                if (LastNumber > Max)
                {
                    Max = LastNumber;
                }
            }
            return Max;

        }
        static int Bai9TinhGiaiThua(int m)
        {
            int GiaiThua = 1;
            if (m < 0)
            {
                GiaiThua = 0;
            }
            else
            {
                if (m == 0 || m == 1)
                {
                    GiaiThua = 1;
                }
                else
                {
                    for (int i = 1; i <= m; i++)
                        GiaiThua *= i;
                }
               
            }
            return GiaiThua;
        }
        static bool Bai11KiemTraSoChinhPhuong(int n)
        {
            for(int i = 1; i < n; i++)
            {
                if (i*i == n)
                {
                    return true;
                }

                if (i*i > n)
                {
                    return false;
                }               
            }
            return false;
        }
        static bool Bai13KiemTraSoNguyenTo(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return true;
            }
            return false;
        }
        static bool Bai14KiemTraSoDoiXung(int n)
        {
            if (n == Bai6DaoNguocVaThayDau(n))
            {
                return true;
            }
            else
            {
                return false;
            }          
        }
        static int TongUoc(int n)
        {
            int Sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % 1 == 0)
                {
                    Sum += 1;
                }
            }
            return Sum;
        }
        static bool Bai15KiemTraSoThanThiet(int n, int p)
        {
            if (TongUoc(n) == p && TongUoc(p) == n )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Bai16KiemTraSoHuaHon(int n, int p)
        {
            if (TongUoc(n) - TongUoc(p) == 1)
            {
                return true;
            }
            return false;
        }
        static bool Bai17KiemTraSoPhongPhu(int n)
        {
            if (TongUoc(n) > n)
            {
                return true;
            }
            return false;
        }
        static bool Bai18KiemTraCapSoCong(int a, int b, int c)
        {
            if (a + c == 2*b)
            {
                return true;
            }
            return false;
        }
        static void Bai19TinhChuViDienTichHinhTron(out double ChuVi, out double DienTich, double r)
        {
            ChuVi = 2 * r * Math.PI;
            DienTich = r * r * Math.PI;
        }
        static void Input(out int d, out int e)
        {
            Console.WriteLine("Enter d: ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter e: ");
            e = int.Parse(Console.ReadLine());
        }
        static void Process(ref int d, ref int e)
        {
            d += 10;
            e += 10;
        }
        static void OutPut(int d, int e)
        {
            Console.WriteLine($"Gia tri sau khi tang 10 don vi la c = {d}, d = {e}");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            //Bai 6
            int n = int.Parse(Console.ReadLine());
            int Reverse = Bai6DaoNguocVaThayDau(n);
            Console.WriteLine($"Bai 6: Reverse = {Reverse} ");

            //Bai 7
            int Tongchan = Bai7TinhTongSoChanCuaSo(n);
            Console.WriteLine($"Bai 7: Tong cac so chan = {Tongchan}");

            //Bai 8
            int Max = Bai8TimSoLonNhatCuaSo(n);
            Console.WriteLine($"Bai 8: Chu so lon nhat la: {Max}");

            Console.Write("Enter m: ");
            //Bai 9
            int m = int.Parse(Console.ReadLine());
            int GiaiThua = Bai9TinhGiaiThua(m);
            Console.WriteLine($"Bai 9: Giai thua cua m: {GiaiThua}");

            Console.Write("Enter k: ");
            //Bai 10
            int k = int.Parse(Console.ReadLine());
            int C = Bai9TinhGiaiThua(m) / Bai9TinhGiaiThua(k) * Bai9TinhGiaiThua(m - k);
            Console.WriteLine($"Bai 10: Chinh hop cua m va k la: {C}");

            //Bai 11
            if (Bai11KiemTraSoChinhPhuong(n))
            {
                Console.WriteLine($"Bai 11: {n} la so chinh phuong");
            }
            else
            {
                Console.WriteLine($"Bai 11: {n} khong la so chinh phuong");
            }

            //Bai 13
            if (Bai13KiemTraSoNguyenTo(n))
            {
                Console.WriteLine($"Bai 13: {n} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"Bai 13: {n} khong la so nguyen to");
            }

            //Bai 14
            if (Bai14KiemTraSoDoiXung(n))
            {
                Console.WriteLine($"Bai 14: {n} la so doi xung");
            }
            else
            {
                Console.WriteLine($"Bai 14: {n} khong la so doi xung");
            }

            Console.Write("Enter p: ");           
            int p = int.Parse(Console.ReadLine());

            //Bai 15
            if (Bai15KiemTraSoThanThiet(n, p))
            {
                Console.WriteLine($"Bai 15: {n} va {p} la cap so than thiet");
            }
            else
            {
                Console.WriteLine($"Bai 15: {n} va {p} khong la cap so than thiet");
            }

            //Bai 16
            if (Bai16KiemTraSoHuaHon(n, p))
            {
                Console.WriteLine($"Bai 16: {n} va {p} la cap so hua hon");
            }
            else
            {
                Console.WriteLine($"Bai 16: {n} va {p} khong la cap so hua hon");
            }

            //Bai 17
            if (Bai17KiemTraSoPhongPhu(n))
            {
                Console.WriteLine($"Bai 17: {n} la so phong phu");
            }
            else
            {
                Console.WriteLine($"Bai 17: {n} khong la so phong phu");
            }

            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = int.Parse(Console.ReadLine());

            //Bai 18
            if (Bai18KiemTraCapSoCong(a,b,c))
            {
                Console.WriteLine("Day la day cap so cong");
            }
            else
            {
                Console.WriteLine("Day khong la day cap so cong");
            }

            //Bai 19
            Console.Write("Enter r: ");
            double r = double.Parse(Console.ReadLine());
            double ChuVi, DienTich;
            Bai19TinhChuViDienTichHinhTron(out ChuVi, out DienTich, r);
            Console.WriteLine($"Chu vi hinh tron la: {ChuVi}");
            Console.WriteLine($"Dien tich hinh tron la: {DienTich}");

            //Bai 2 (BT them)
            int d, e;
            Input(out d, out e);
            Process(ref d, ref e);
            OutPut(d, e);
        }
    }
}
