using System;

namespace ExempleTest
{
    class Program
    {
        //1. The user enters the number of hours, output the number of minutes in that number of hours.
        static int Task1(int nubberOfHouse)
        {               
            return nubberOfHouse * 60;           
        }

        //2. The user enters 2 numbers (A and B). Print the solution (5*A+B^2)/(B-A) to the console.
        static float Task2(int a, int b)
        {           
            return (float)(5 * a + b * b) / (b - a);
        }

        //3. The user enters 2 string values (A and B). Swap the contents of variables A and B.
        static void Task3(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;           
        }

        //4. The user enters 2 numbers (A and B). Print to the console the result of dividing A by B and the division remainder.
        static (int dividingResult, int divisionResult) Task4(in int a, in int b)
        {
            int dividing = a / b;
            int division = a % b;

            return (dividing, division);
        }

        //5. The user enters 3 non-zero numbers (A, B and C). Print to the console the solution (X value) of the standard linear equation, where A*X+B=C.
        static float Task5(float a, float b, float c)
        {
            return (float)Math.Round((c - b) / a, 5);
        }

        //6. The user enters 4 numbers (X1, Y1, X2, Y2) describing the coordinates of 2 points on the coordinate plane. Output the equation of a straight line in the format Y=AX+B passing through these points.
        static (float a, float b) Task6(float y1, float y2, float x1, float x2)
        {
            float a = (y1 - y2) / (x1 - x2);
            float b = y2 - a * x2;

            return (a, b);
        }

        //7. The variable N stores a natural two-digit number (10-99). Write a program that calculates and displays the sum of the digits of n.
         static int Task7(int n)
        {
            int first = n / 10;
            int second = n % 10;

            return first + second;
        }

            static void Main(string[] args)
        {

        }
    }
}
