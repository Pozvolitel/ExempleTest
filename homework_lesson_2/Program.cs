using System;

namespace homework_lesson_2
{
    class Program
    {
        //1. The user enters 2 numbers (A and B). If A > B, result is A+B, if A=B, result is A * B, if A < B, result is A-B.
        static int Task1(int a, int b)
        {
            int result = a;
            if (a > b)
            {
                result += b;
            }
            else if (a == b)
            {
                result *= b;
            }
            else
            {
                result -= b;
            }

            return result;
        }

        // 2. The user enters 2 numbers(X and Y). Determine which quarter the point with coordinates(X, Y) belongs to.
        static int Task2(int x, int y)
        {
            int result = default;
            if(x == 0 || y == 0)
            {
                return result;
            }

            if (x > 0)
            {
                if(y > 0)
                {
                    result = 1;
                }
                else
                {
                    result = 4;
                }
            }
            else
            {
                if (y > 0)
                {
                    result = 2;
                }
                else
                {
                    result = 3;
                }
            }

            return result;
        }

        //3. The user enters 3 numbers (A, B and C). Print them to the console in ascending order.
        static (int a, int b, int c) Task3(int a, int b, int c)
        {
            if(a > b)
            {
                Swap(ref a, ref b);
            }
            if(a > c)
            {
                Swap(ref a, ref c);
            }
            if(b > c)
            {
                Swap(ref b, ref c);
            }

            return (a, b, c);
        }

        // 4.The user enters 3 numbers(A, B and C). Print to the console the solution(X-values) of the standard form quadratic equation, where AX^2+BX+C=0.
         static (double x1, double x2) Task4(float a, float b, float c)
        {
            double x1 = double.NaN;
            double x2 = double.NaN;
            double sqrtOfD = Math.Sqrt((b * b) - (4 * a * c));

            if (sqrtOfD >= 0)
            {
                x1 = (-b + sqrtOfD) / (2 * a);
                x2 = (-b - sqrtOfD) / (2 * a);
            }

            return (x1, x2);
        }

        //5. The user enters a two-digit number. Print the capitalization of this number to the console. For example, typing "25" will print "twenty-five" to the console.
        static string GetCapitalizationOfNumber(int a)
        {
            int firstDigit = a / 10;
            int secondDigit = a % 10;

            if (firstDigit != 1)
            {
                return $"{GetDozens(firstDigit)} {GetUnits(secondDigit)}";
            }

            return GetExceptionalNumbers(secondDigit);
        }

        private static string GetExceptionalNumbers(int secondDigit)
        {
            string result = string.Empty;
            switch (secondDigit)
            {
                case 0:
                    result = "ten";
                    break;
                case 1:
                    result = "eleven";
                    break;
                case 2:
                    result = "twelve";
                    break;
                case 3:
                    result = "thirteen";
                    break;
                case 4:
                    result = "fourteen";
                    break;
                case 5:
                    result = "fifteen";
                    break;
                case 6:
                    result = "sixteen";
                    break;
                case 7:
                    result = "seventeen";
                    break;
                case 8:
                    result = "eighteen";
                    break;
                case 9:
                    result = "nineteen";
                    break;
            }

            return result;
        }

        private static string GetUnits(int secondDigit)
        {
            string result = string.Empty;
            switch (secondDigit)
            {
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
            }

            return result;
        }

        private static string GetDozens(int firstDigit)
        {
            string result = string.Empty;
            switch (firstDigit)
            {
                case 2:
                    result = "twenty";
                    break;
                case 3:
                    result = "thirty";
                    break;
                case 4:
                    result = "fourty";
                    break;
                case 5:
                    result = "fifty";
                    break;
                case 6:
                    result = "sixty";
                    break;
                case 7:
                    result = "seventy";
                    break;
                case 8:
                    result = "eighty";
                    break;
                case 9:
                    result = "ninety";
                    break;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Task5();
        }
    }
}
