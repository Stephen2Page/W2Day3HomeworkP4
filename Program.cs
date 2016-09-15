using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2Day3HomeworkP4
{
    class Program
    {
        //Create a method to calculate the sum of the elements in an array.
        static void Main(string[] args)
        {
            int[] example = { 20, 10, 5, 2 };
            Console.WriteLine("The sum of the example array is {0}", Sum(example));
        }
        static int Sum(int[] listOfNum) // accept array as parameter, return an interger
        {
            int total = 0;
            for (int i = 0; i < (listOfNum.Length); i++) // count thru array
            {
                total += listOfNum[i];//add number
            }
            return total;
        }
    }
}
