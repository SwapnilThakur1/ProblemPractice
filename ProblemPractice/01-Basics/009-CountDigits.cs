using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPractice._01_Basics
{
    internal class _009_CountDigits
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a Numbner :");
            int num = Convert.ToInt32(Console.ReadLine());
            int digits = 0;
            if (num < 0)
            {
                Console.WriteLine("Negative numbers are not allowed");
                return;
            }
            if (num == 0)
            {
                digits = 1;
                Console.WriteLine("Digits :" + digits);
                return;
            }
            while (num > 0)
            {
                num = num / 10;
                digits++;
            }
            Console.WriteLine("Digits :" + digits);
        }
    }
}
