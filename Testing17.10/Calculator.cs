using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing17._10
{
    class Calculator
    {
        //Overloading methods
        //Calculations
        //Additions
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static double Addition(double a, double b)
        {
            return a + b;
        }

        //Subtractions
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static double Subtraction(double a, double b)
        {
            return a - b;
        }

        //Multiplications
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        //Devisions
        public static double Division(int a, int b)
        {
            return (double) a / b;
        }

        public static double Division(double a, double b)
        {
            return a / b;
        }

        //Comparisons
        //Find the minimum
        public static int MinInInt2(int a, int b)
        {
            int min = a;
            if (min > b)
            {
                min = b;
            }
            else if (min < b)
            {
                min = a;
            }
            return a;
        }

        public static double MinInDouble2(double a, double b)
        {
            double min = a;
            if (min > b)
            {
                min = b;
            }
            else if (min < b)
            {
                min = a;
            }
            return a;
        }

        public static int MinInInt3(int a, int b, int c)
        {
            int min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            return min;
        }

        public static double MinInDouble3(double a, double b, double c)
        {
            double min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            return min;
        }

        //Find the maximum
        public static int MaxInInt2(int a, int b)
        {
            int max = a;
            if (max < b)
            {
                max = b;
            }
            else if (max > b)
            {
                max = a;
            }
            return max;
        }

        public static double MaxInDouble2(double a, double b)
        {
            double max = a;
            if (max < b)
            {
                max = b;
            }
            else if (max > b)
            {
                max = a;
            }
            return max;
        }

        public static int MaxInInt3(int a, int b, int c)
        {
            int max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            return max;
        }

        public static double MaxInDouble3(double a, double b, double c)
        {
            double max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            return max;
        }
    }
}
