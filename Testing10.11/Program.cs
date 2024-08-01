using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing10._11
{
    class Program
    {
        static void Main(string[] args)
        {
  

        }
        public static int[][] createArray(Random random)
        {
            
            int row = (int)(Math.random() * 5) + 5;
            //int column = (int)(Math.random()*5)+5; //not needed

            int[][] array = new int[row][];

            for (int i = 0; i < array.Length; i++)
            {

                int column = (int)(Math.random() * 5) + 5; //create your random column count on each iteration
                array[i] = new int[column]; //Initialize with each random column count

                for (int j = 0; j < array[i].Length; j++)
                {
                    //Fill the matrix with random numbers
                    array[i][j] = (int)(Math.random() * 10);
                }
            }

            return array;
        }//End createArray method
    }
}


