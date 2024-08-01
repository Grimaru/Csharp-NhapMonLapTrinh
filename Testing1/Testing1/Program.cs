using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //Bài 5: Nhập số nguyên n gồm 3 chữ số. Xuất ra màn hình chữ số lớn nhất? VD: n = 291 => Chữ số lớn nhất là 9.
            //    Console.Write("Nhập số n: ");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] arr = new int[3]; //Cấp phát 3 ô nhớ cho mảng arr thuộc kiểu int.

            //    //Tạo vòng lặp để tách số n ra từng phần tử của nó:
            //    for (int i = 0; i < 3; i++) //khởi tạo biến vòng lặp (int i = 0) -> kiểm tra biểu thức điều kiện (i < 3) -> thực hiện câu lệnh (2 cái dòng trong "{}") -> cập nhật biến vòng lặp (i++).
            //    {
            //        //Quá trình tách số n ra từng phần tử:
            //        arr[i] = n % 10;
            //        n = n / 10;
            //    }
            //    int max = arr[0]; //Quy ra từng phần tử của số đó.

            //    //Tìm ra phần tử lớn nhất trong đám phần tử đã tách ra từ số đó.
            //    for (int i = 0; i < 3; i++)
            //    {
            //      if (arr[i] > max)
            //      max = arr[i];
            //    }
            //    Console.WriteLine($"Chữ số lớn nhất là: {max} ");
            //    Console.ReadKey();

            //    //*Question: Chưa hiểu khúc cấp 3 ô nhớ tại thử ghi 4 chữ số cũng thực hiện tách số quy ra max được.

            //    //Bài 6: Nhập điểm 3 môn Toán, Lí, Hóa. Tính điểm trung bình 3 môn? Dựa vào điểm trung bình (ĐTB) vừa tính được in ra xếp loại:
            //    Console.Write("Nhập điểm Toán: ");
            //    double Toán = double.Parse(Console.ReadLine());
            //    Console.Write("Nhập điểm Lí: ");
            //    double Lí = double.Parse(Console.ReadLine());
            //    Console.Write("Nhập điểm Hóa");
            //    double Hóa = double.Parse(Console.ReadLine());
            //    double ĐTB = (Toán + Lí + Hóa) / 3;
            //    Console.WriteLine($"Điểm trung bình: {ĐTB}");

            //    //Xét điểm trung bình ĐTB:
            //    if (Toán < 0 || Lí < 0 || Hóa < 0 || Toán > 10 || Lí > 10 || Hóa > 10) // "||" là HOẶC. Nghĩa là nếu 1 (hoặc nhiều) trong 6 cái này xuất hiện trong chương trình thì ra dòng Console.WriteLine ở dưới.
            //    {
            //        Console.WriteLine("Không có điểm nào như vậy. Vui lòng nhập lại.");
            //    }
            //    else
            //    {
            //        if (ĐTB < 5)
            //        {
            //            Console.WriteLine("Xếp loại: Yếu.");
            //        }
            //        else if (ĐTB < 6) //else if: else (ĐTB >= 5) và if (ĐTB < 6).
            //        {
            //            Console.WriteLine("Xếp loại: Trung Bình.");
            //        }
            //        else if (ĐTB < 8) //else if: else (ĐTB >= 6) và if (ĐTB < 8).
            //        {
            //            Console.WriteLine("Xếp loại: Khá. ");
            //        }
            //        else if (ĐTB < 9) //else if: else (ĐTB >= 8) và if (ĐTB < 9).
            //        {
            //            Console.WriteLine("Xếp loại: Giỏi. ");
            //        }
            //        else if (ĐTB <= 10) //else if: else (ĐTB >= 9) và if (ĐTB <= 10).
            //        {
            //            Console.WriteLine("Xếp loại: Xuất xắc. ");
            //        }
            //    }
            //    Console.ReadKey();

            ////Bài 10: Tính tiền taxi:           
            //Console.Write("Nhap so kilomet: ");
            //double km = double.Parse(Console.ReadLine());
            //double Money = 0;
            //double KMSafterthe1stkm = (km - (int)km) * 1000 / 200;
            //if (KMSafterthe1stkm % 1 == 0)
            //    Console.Write("Số km đã trọn vẹn không cần làm tròn. ");

            //if (KMSafterthe1stkm % 1 != 0)
            //    KMSafterthe1stkm = (int)KMSafterthe1stkm + 1;

            //if (km <= 1)
            //{
            //    Money = 5000;
            //}

            //else if (km <= 30)
            //{
            //    Money = 5000 * (int)km + KMSafterthe1stkm * 1000;
            //}

            //double KMSafterthe30thkm = km - (int)km;
            //if (km > 30)
            //{
            //    if (KMSafterthe30thkm != 0)
            //    {
            //        KMSafterthe30thkm = (int)KMSafterthe30thkm + 1;
            //    }
            //    km = (int)km + KMSafterthe30thkm;
            //    Money = 30 * 5000 + (km - 30) * 3000;
            //}

            //Console.Write($"So tien phai tra: {Money}");
            //Console.ReadKey();


            ////Bài 12: Nhập số nguyên có 3 chữ số. In ra chữ số thuộc hàng trăm, chục, đơn vị:
            //Console.Write("Nhập số n: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[3]; //Cấp phát 3 ô nhớ cho mảng arr thuộc kiểu int.

            ////Tạo vòng lặp để tách số n ra từng phần tử của nó:
            //for (int i = 0; i < 3; i++) //khởi tạo biến vòng lặp (int i = 0) -> kiểm tra biểu thức điều kiện (i < 3) -> thực hiện câu lệnh (2 cái dòng trong "{}") -> cập nhật biến vòng lặp (i++).
            //{
            //    //Quá trình tách số n ra từng phần tử:
            //    arr[i] = n % 10;
            //    n = n / 10;
            //}
            //int tram = arr[2];
            //int chuc = arr[1];
            //int donvi = arr[0];
            ////Quy ra từng phần tử của số đó.
            //Console.WriteLine($"Hàng trăm: {arr[2]} ");
            //Console.WriteLine($"Hàng chục: {arr[1]} ");
            //Console.WriteLine($"Hàng đơn vị: {arr[0]} ");
            //Console.ReadKey();


            ////Bài 13: Cho nhập số nguyên dương n. Đếm số lượng chữ số chẵn lẻ trong số nguyên dương đó:
            //Console.Write("Nhập số n: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n]; //Cấp phát n ô nhớ cho mảng arr thuộc kiểu int.
            //int count = 0;
            //int count1 = 0;

            ////Tạo vòng lặp để tách số n ra từng phần tử của nó:
            //for (int i = 0; i < n; i++) //khởi tạo biến vòng lặp (int i = 0) -> kiểm tra biểu thức điều kiện (i < 3) -> thực hiện câu lệnh (2 cái dòng trong "{}") -> cập nhật biến vòng lặp (i++).
            //{
            //    //Quá trình tách số n ra từng phần tử và sắp xếp về chẵn lẻ:
            //    arr[i] = n % 10;
            //    n = n / 10;
            //    if (arr[i] % 2 == 1)
            //    {
            //        count = count + 1;
            //    }
            //    if (arr[i] % 2 == 0)
            //    {
            //        count1 = count1 + 1;
            //    }
            //}
            //Console.WriteLine($"Có {count} số lẻ trong số nguyên dương đó.");
            //Console.WriteLine($"Có {count1} số chẵn trong số nguyên dương đó.");
            //Console.ReadKey();

            ////Bài 14: Cho nhập số nguyên dương n. Hãy tính tổng và tích các số của số n.
            //Console.Write("Nhập số n: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n]; //Cấp phát n ô nhớ cho mảng arr thuộc kiểu int.           
            //int Tong = 0, Tich = 1;

            ////Tạo vòng lặp để tách số n ra từng phần tử của nó:
            //for (int i = 0; i < n; i++) //khởi tạo biến vòng lặp (int i = 0) -> kiểm tra biểu thức điều kiện (i < 3) -> thực hiện câu lệnh (2 cái dòng trong "{}") -> cập nhật biến vòng lặp (i++).
            //{
            //    //Quá trình tách số n ra từng phần tử và sắp xếp về chẵn lẻ:
            //    arr[i] = n % 10;
            //    n = n / 10;                
            //    Tong += arr[i];
            //    Tich *= arr[i];                
            //}
            //Console.WriteLine($"Tổng các số trong số nguyên dương đó là: {Tong}");
            //Console.WriteLine($"Tích các số trong số nguyên dương đó là: {Tich}");
            //Console.ReadKey();

            ////Bài 15 trùng Bài 5.

            ////Bài 16 tương tự bài 5.

            ////Bài 17: Cho nhập số nguyên dương n. Hãy tính tổng và tích các chữ số chẵn và lẻ của số n.
            //Console.Write("Nhập số n: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n]; //Cấp phát n ô nhớ cho mảng arr thuộc kiểu int.           
            //int Tongle = 0, Tongchan = 0, Tichle = 1, Tichchan = 1;

            ////Tạo vòng lặp để tách số n ra từng phần tử của nó:
            //for (int i = 0; i < n; i++) //khởi tạo biến vòng lặp (int i = 0) -> kiểm tra biểu thức điều kiện (i < 3) -> thực hiện câu lệnh (2 cái dòng trong "{}") -> cập nhật biến vòng lặp (i++).
            //{
            //    //Quá trình tách số n ra từng phần tử và sắp xếp về chẵn lẻ:
            //    arr[i] = n % 10;
            //    n = n / 10;
            //    if (arr[i] % 2 == 1)
            //    {                   
            //        Tongle += arr[i];
            //        Tichle *= arr[i];
            //    }
            //    if (arr[i] % 2 == 0)
            //    {
            //        Tongchan += arr[i];
            //        Tichchan *= arr[i];
            //    }
            //}
            //Console.WriteLine($"Tổng các số lẻ trong số nguyên dương đó là: {Tongle}");
            //Console.WriteLine($"Tổng các số chẵn trong số nguyên dương đó là: {Tongchan}");
            //Console.WriteLine($"Tích các số lẻ trong số nguyên dương đó là: {Tichle}");
            //Console.WriteLine($"Tích các số chẵn trong số nguyên dương đó là: {Tichchan}");
            //Console.ReadKey();

            ////Bài 18: Nhập vào số nguyên n gồm 3 chữ số. In ra thứ tự đảo ngược của các chữ số.
            //Console.Write("Nhập số n:");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //int reverse = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = n % 10;
            //    n = n / 10;
            //    reverse = reverse*10 + arr[i];
            //}
            //Console.WriteLine($"Số đảo ngược của n là: {reverse}");
            //Console.ReadKey();

            //Bài 19: Nhập vào số nguyên n. Liệt kê các ước số của n.
            Console.Write("Nhập số n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Các ước số của {n} là: ");

            for(int i = 1; i <= n/2; i++)
            {
                if(n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();


        }
    }
}


