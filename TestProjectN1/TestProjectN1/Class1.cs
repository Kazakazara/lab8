using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectN1
{
    public static class Universal
    {
        public static int[] SortBubble(int[] a) 
        {
            if (a == null || a.Length <= 1)
            {
                return a;
            }

            int temp;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            return a;
        }
        public static bool IsPalindrome(string s)
        {
            if (s == null)
            {
                return false;
            }

            s = s.ToLower();

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
        public static int FactorialOfNumber(int x)
        {
            if (x <= 0)

                throw new ArgumentException("Число должно быть положительным.");

            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }

            return result;
        }

        public static int Fibonacci(int position)
        {
            if (position <= 0)
            {
                throw new ArgumentException("Позиция должна быть положительным целым числом.");
            }

            if (position == 1 || position == 2)
            {
                return 1;
            }

            int a = 1;
            int b = 1;
            int output = 0;

            for (int i = 3; i <= position; i++)
            {
                output = a + b;
                a = b;
                b = output;
            }

            return output;
        }

        public static double Power(double x, double stepen)
        {
            return Math.Pow(x, stepen);
        }

        public static bool IsPrime(int num)
        {
            for (int i = 2; i <= (int)Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }



    }
}
