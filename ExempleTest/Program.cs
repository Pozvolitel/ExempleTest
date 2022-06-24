using System;

namespace ExempleTest
{
    class Program
    {
        //1. The user enters the number of hours, output the number of minutes in that number of hours.
        static void Task1()
        {
            Console.WriteLine("enter number of hours");
            int hours = Convert.ToInt32(Console.ReadLine());
            int minets = hours * 60;
            Console.WriteLine("the number of minutes is: " + minets);
        }

        //2. The user enters 2 numbers (A and B). Print the solution (5*A+B^2)/(B-A) to the console.
        static void Task2()
        {
            Console.WriteLine("enter number A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number B");
            int B= Convert.ToInt32(Console.ReadLine());

            int expon = Convert.ToInt32(Math.Pow(B, 2));
            int result = (5 * A + expon) / (B - A);

            Console.WriteLine("the result: " + result);
        }

        //3. The user enters 2 string values (A and B). Swap the contents of variables A and B.
        static void Task3()
        {
            Console.WriteLine("enter number A");
            int A = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("enter number B");
            int B = Convert.ToInt32(Console.ReadLine());

            (A, B) = (B, A);

            Console.WriteLine("number A = " + A + "\nnumber B = " + B);
        }

        //4. The user enters 2 numbers (A and B). Print to the console the result of dividing A by B and the division remainder.
        static void Task4()
        {
            Console.WriteLine("enter number A");
            float A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number B");
            float B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("result of dividing: " + A / B + "\nthe division remainder: " + A % B);
        }

        //5. The user enters 3 non-zero numbers (A, B and C). Print to the console the solution (X value) of the standard linear equation, where A*X+B=C.
        static void Task5()
        {
            Console.WriteLine("enter number A");
            float A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number B");
            float B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number C");
            float C = Convert.ToInt32(Console.ReadLine());

            double X = Math.Ceiling((C - B) / A);

            Console.WriteLine("X value: " + X);
        }

        //6. The user enters 4 numbers (X1, Y1, X2, Y2) describing the coordinates of 2 points on the coordinate plane. Output the equation of a straight line in the format Y=AX+B passing through these points.
        static void Task6()
        {
            Console.WriteLine("enter coordinates x1");
            float X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter coordinates y1");
            float Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter coordinates x2");
            float X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter coordinates y2");
            float Y2 = Convert.ToInt32(Console.ReadLine());

            float A = (Y1 - Y2) / (X1 - X2);
            float B = Y2 - A * X2;

            Console.WriteLine("\nPoint A coordinates: " + "x1: " + X1 + "  y1: " + Y1 +
                               "\nPoint B coordinates: " + "x2: " + X2 + " y2: " + Y2 +
                                   "\n\nStraight line equation: y = " + A +"x + " + B);
        }

        //7. The variable N stores a natural two-digit number (10-99). Write a program that calculates and displays the sum of the digits of n.
        static void Task7()
        {
            Random rnd = new Random();
            int n = rnd.Next(10, 99);
            
            int first = n / 10;
            int second = n % 10;

            int N = first + second;
            Console.WriteLine("random number: " + n + "\n\nthe sum of the digits of n: " + N);
        }

            static void Main(string[] args)
        {
            Task7();
        }
    }
}
