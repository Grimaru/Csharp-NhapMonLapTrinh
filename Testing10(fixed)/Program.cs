using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing10_fixed_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ma tran Image ");
            int[,] image;
            NhapMaTranImage(out image);
            Console.WriteLine("Ma tran Image vua nhap: ");
            InMaTranImage(image);
            Console.WriteLine("Nhap ma tran Kernel ");
            int[,] kernel;
            NhapMaTranKernel(out kernel);
            Console.WriteLine("Ma tran Kernel vua nhap: ");
            InMaTranKernel(kernel);
            Console.WriteLine("Convolution: " + Convolution(image, kernel));
        }

        static void NhapMaTranImage(out int[,] image)
        {
            Console.Write("Nhap dong ma tran Image: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap cot ma tran Image: ");
            int cols = int.Parse(Console.ReadLine());
            image = new int[rows, cols];
            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    image[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        static void InMaTranImage(int[,] image)
        {
            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    Console.Write(image[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void NhapMaTranKernel(out int[,] kernel)
        {
            Console.Write("Nhap dong ma tran Kernel: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap cot ma tran Kernel: ");
            int cols = int.Parse(Console.ReadLine());
            kernel = new int[rows, cols];
            for (int i = 0; i < kernel.GetLength(0); i++)
            {
                for (int j = 0; j < kernel.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    kernel[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        static void InMaTranKernel(int[,] kernel)
        {
            for (int i = 0; i < kernel.GetLength(0); i++)
            {
                for (int j = 0; j < kernel.GetLength(1); j++)
                {
                    Console.Write(kernel[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] Convolution(int[,] image, int[,] kernel)
        {
            int rows = image.GetLength(0) - kernel.GetLength(0) + 1;
            int cols = image.GetLength(1) - kernel.GetLength(1) + 1;
            int[,] conv = new int[rows, cols];
            for (int m = 0; m < rows; m++)
            {
                for (int n = 0; n < cols; n++)
                {
                    int result = 0;
                    for (int i = 0; i < image.GetLength(0); i++)
                    {
                        for (int j = 0; j < kernel.GetLength(1); j++)
                        {
                            result += image[m + i, n + j] * kernel[i, j];
                        }
                        //conv[m, n] = result;
                    }
                    conv[m, n] = result;
                }
            }
            return conv;
        }

    }
}
