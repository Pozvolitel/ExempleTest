using System;

namespace homework_lesson_3
{
    class Program
    {
        //1. The user enters 2 numbers (A and B). Raise the number A to the power of B.
        static int RaiseTheNumber(int a, int b)
        {            
            return Convert.ToInt32(Math.Pow(a, b));
        }

        //3. The user enters 1 number (A). Find the number of positive integers whose square is less than A.
        static int Number(int a)
        {
            int num = 0;
            for (int i = 1; i < a; ++i)
            {
                num = i;
                if (num * num < a)
                {
                    Console.WriteLine(num);
                }
                else
                {
                    break;
                }
            }            
           return --num;
        }
        //4. The user enters 1 number (A). Print the largest divisor (other than A itself) of the number A.
        static int NumberA(int a)
        {
            int res = 1;
            for (int i = a; i > 0; i--)
            {                
                if (a % i == 0)
                {
                    res = (int)Math.Sqrt(i);
                }
                else { break; }
            }
            return res;
        }

        // 5. The user enters 2 numbers(A and B). Print the sum of all numbers from the range A to B that are divisible by 7 without a remainder. (Note that B may be less than A if you type)
        static int WithoutARemainder(int a, int b)
        {
            int sum = 0;
            if (b > a)
            {
                for (int i = a; b >= i; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            else if (b < a)
            {
                for (int i = b; a >= i; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }

        // 6. The user enters 1 number(N). Print the Nth number of the fibonacci series.In the fibonacci series, each next number is the sum of the previous two. The first and second are considered equal to 1.
        static int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;
           
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        //7. The user enters 2 numbers. Find their greatest common divisor using Euclid's algorithm.
        static int Euclid(int a, int b)
        {
            int nod = 0;           

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
           return nod = a + b;           
        }

        //9. The user enters number. Find the number of odd digits of this number.
        static int OddNumber(int a)
        {
            int c = 0;
            while (a != 0)
            {
                if ((a % 10) % 2 != 0)
                {
                    c++;
                }
                a = a / 10;
            }
            return c;
        }

        //10. The user enters number. Find a number that is a mirror image of the sequence of digits of a given number, for example, given the number 123, output 321.
        static int GivenTheNumber(int number)
        {
            int result = 0;
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
            return result;
        }
               
        static void Main(string[] args)
        {
             
        }
    }
}
