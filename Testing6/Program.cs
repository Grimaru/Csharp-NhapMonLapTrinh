using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
	public static void Main(string[] args)
	{
		
		int[,] a;
		int[,] b;
		int m, n, p;

		//Nhập kích thước ma trận A
		Console.WriteLine("Nhập vào số hàng ma trận A:");
		m = int.Parse(Console.ReadLine());
		Console.WriteLine("Nhập vào số cột ma trận A:");
		n = int.Parse(Console.ReadLine());

		//Đọc vào ma trận A
		ReadMatrix(out a, m, n);
		//In ma trận
		Console.WriteLine($"Matrix({a})");

		//Nhập kích thước ma trận B
		Console.WriteLine("Nhập vào số hàng ma trận B:");
		m = int.Parse(Console.ReadLine());
		Console.WriteLine("Nhập vào số cột ma trận B:");
		n = int.Parse(Console.ReadLine());
		//Đọc vào ma trận B
		ReadMatrix(out b, m, n);
		//In ma trận
		PrintMatrix(b);

		int[,] c;
		//Cộng hai ma trận
		//In cộng ma trận kết quả
		Console.WriteLine("Kết quả của phép cộng ma trận:");
		AddMatrix(a, b, out c);
		PrintMatrix(c);
		//Gọi Hàm nhân hai ma trận
		//In nhân ma trận kết quả
		Console.WriteLine("Kết quả của phép nhân ma trận:");
		MulMatrix(a, b, out c);
		PrintMatrix(c);

	}
	//Hàm đọc dữ liệu vào cho ma trận
	public static void ReadMatrix(out int[,] M, int row, int col)
	{
		M = new int[row, col];
		for (int i = 0; i < row; i++)
			for (int j = 0; j < col; j++)
			{
				Console.Write("Phần tử [{0},{1}]:", i, j);
				M[i, j] = int.Parse(Console.ReadLine());
			}
	}
	//Hàm in ma trận 
	public static void PrintMatrix(int[,] M)
	{
		//Console.WriteLine("Hàng: {0} ,",M.GetLength(0));//Lấy kích thước hàng
		//Console.WriteLine("Cột: {0} ,",M.GetLength(1));//Lấy kích thước cột
		if (M != null)
		{
			for (int i = 0; i < M.GetLength(0); i++)
			{
				for (int j = 0; j < M.GetLength(1); j++)
				{
					Console.Write("{0} ,", M[i, j]);
				}
				Console.WriteLine();
			}
		}
	}
	//Hàm cộng hai ma trận, hai ma trận muốn cộng được phải cùng kích thước
	public static void AddMatrix(int[,] a, int[,] b, out int[,] c)
	{
		c = new int[a.GetLength(0), a.GetLength(1)];
		if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
		{
			Console.WriteLine("Hai ma trận không cùng kích thước nên không cộng được!");
			c = null;
		}
		else
		{
			//Console.WriteLine("Hàng: {0} ,", c.GetLength(0));//Lấy kích thước hàng
			//Console.WriteLine("Cột: {0} ,", c.GetLength(1));//Lấy kích thước cột
			//Cộng các phần tử tương ứng
			for (int i = 0; i < c.GetLength(0); i++)
				for (int j = 0; j < c.GetLength(1); j++)
					c[i, j] = a[i, j] + b[i, j];

		}
	}
	//Hàm nhân hai ma trận, A[m,n] * B[n,p] tức số cột của ma trận A phải bằng số hàng của ma trận B thì mới nhân được
	//Kết quả của ma trận C[m,p]
	public static void MulMatrix(int[,] a, int[,] b, out int[,] c)
	{
		c = new int[a.GetLength(0), b.GetLength(1)];
		if (a.GetLength(1) != b.GetLength(0))
		{
			Console.WriteLine("Số cột của Ma trận A không bằng số hàng của Ma trận B nên không nhân được");
			c = null;
		}
		else
		{
			//Console.WriteLine("Hàng: {0} ,", c.GetLength(0));//Lấy kích thước hàng
			//Console.WriteLine("Cột: {0} ,", c.GetLength(1));//Lấy kích thước cột
			//Thuật toán nhân hai ma trận
			for (int i = 0; i < a.GetLength(0); i++)
				for (int j = 0; j < b.GetLength(1); j++)
				{
					c[i, j] = 0;
					for (int k = 0; k < b.GetLength(0); k++)
					{
						c[i, j] = c[i, j] + a[i, k] * b[k, j];
					}
				}
		}
	}
}