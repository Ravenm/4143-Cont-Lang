using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SumAvg
{
    internal class Program
    {
        /// <summary>
        /// Main function just calls the smaller functions to output Sum, Avg, Max and Min
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var myNum = Input();
            
            Console.WriteLine("The number entered is:" + myNum);
            Console.WriteLine("The sum of the number is: " + Sum(myNum));
            Console.WriteLine("The avg of the number is: " + Avg(myNum));
            Console.WriteLine("The max of the number is: " + Max(myNum));
            Console.WriteLine("The min of the number is: " + Min(myNum));
        }

        /// <summary>
        /// Returns user input in the form of an int
        /// </summary>
        /// <returns></returns>
        private static int Input()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// adds the digits of a num
        /// </summary>
        /// <param name="num">number to be added</param>
        /// <returns></returns>
        private static int Sum(int num=0)
        {
            var sum = 0;
            while (num > 0)
            {
                sum += num%10;
                num = num/10;
            }
            return sum;
        }

        /// <summary>
        /// Gets the length of a number
        /// </summary>
        /// <param name="num">number to find length of</param>
        /// <returns></returns>
        private static int GetLen(int num=0)
        {
            var len = 0;
            for (; num > 0;)
            {
                num = num / 10;
                len++;
            }
            return len;
        }

        /// <summary>
        /// Returns the avg of a the sum of digits of a number
        /// </summary>
        /// <param name="num">number to be avg</param>
        /// <returns></returns>
        private static int Avg(int num=0)
        {
            if (num == 0) return 0;
            var temp = num;
            var len = GetLen(num);
            return Sum(num)/len;
        }

        /// <summary>
        /// returns the min of the digits of a number
        /// </summary>
        /// <param name="num">number to find min</param>
        /// <returns></returns>
        private static int Min(int num = 0)
        {
            var temp = num%10;
            while (num > 0)
            {
                if (num % 10 < temp) temp = num % 10;
                num = num / 10;
            }
            return temp;
        }

        /// <summary>
        /// Returns the max of a number
        /// </summary>
        /// <param name="num">number to find the max of</param>
        /// <returns></returns>
        private static int Max(int num = 0)
        {
            var temp = num%10;
            while (num > 0)
            {
                if (num%10 > temp) temp =num%10;
                num = num/10;
            }
            return temp;
        }
    }
}
