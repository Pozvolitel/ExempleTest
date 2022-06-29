using System;

namespace homework_lesson_2
{
    class Program
    {
        //1. The user enters 2 numbers (A and B). If A > B, result is A+B, if A=B, result is A * B, if A < B, result is A-B.
        static void Task1()
        {
            Console.WriteLine("enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b) Console.WriteLine(a + b);
            else if (a == b) Console.WriteLine(a * b);
            else if (a < b) Console.WriteLine(a - b);
        }

        // 2. The user enters 2 numbers(X and Y). Determine which quarter the point with coordinates(X, Y) belongs to.
        static void Task2()
        {
            Console.WriteLine("enter x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter y");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0) Console.WriteLine("belongs to 1");
            else if (x < 0 && y > 0) Console.WriteLine("belongs to 2");
            else if (x < 0 && y < 0) Console.WriteLine("belongs to 3");
            else if (x > 0 && y < 0) Console.WriteLine("belongs to 4");
            else Console.WriteLine("you hit the target");
        }

        //3. The user enters 3 numbers (A, B and C). Print them to the console in ascending order.
        static void Task3()
        {
            Console.WriteLine("enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && b > c) Console.WriteLine(c + " " + b + " " + a);
            else if (c > b && b > a) Console.WriteLine(a + " " + b + " " + c);
            else if (c > a && a > b) Console.WriteLine(b + " " + a + " " + c);
            else if (b > a && a > c) Console.WriteLine(c + " " + a + " " + b);
            else if (a > c && c > b) Console.WriteLine(b + " " + c + " " + a);
            else if (b > c && c > a) Console.WriteLine(a + " " + c + " " + b);
        }

        // 4.The user enters 3 numbers(A, B and C). Print to the console the solution(X-values) of the standard form quadratic equation, where AX^2+BX+C=0.
        static void Task4()
        {
            Console.WriteLine("enter a");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c");
            float c = Convert.ToInt32(Console.ReadLine());

            double d = Math.Sqrt((b * b) - (4 * a * c));

            if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("x = {0}", x);
            }
            else if (d > 0)
            {
                double x1, x2;
                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);
                Console.WriteLine("D={0}, x1={1}, x2={2}", d, x1, x2);
            }
            else
            {
                Console.WriteLine("Since the discriminant is less than zero, the equation has no real solutions.");
            }
        }

        //5. The user enters a two-digit number. Print the capitalization of this number to the console. For example, typing "25" will print "twenty-five" to the console.
        static void Task5()
        {
            Console.WriteLine("enter number");
            int number = Convert.ToInt32(Console.ReadLine());

            int first = number / 10;
            int second = number % 10;

            string secondNumber = "Temp1";
            string firstNumber = "Temp2";
            
            if (number == 10)  Console.WriteLine("ten");
            else if (number == 11) Console.WriteLine("eleven");
            else if (number == 12) Console.WriteLine("twelve");
            else if (number == 13) Console.WriteLine("thirteen");
            else if (number == 14) Console.WriteLine("fourteen");
            else if (number == 15) Console.WriteLine("fifteen");
            else if (number == 16) Console.WriteLine("sixteen");
            else if (number == 17) Console.WriteLine("seventeen");
            else if (number == 18) Console.WriteLine("eighteen");
            else if (number == 19) Console.WriteLine("nineteen");
            else if (number == 20) Console.WriteLine("twenty");
            else if (number == 30) Console.WriteLine("thirty");
            else if (number == 40) Console.WriteLine("fourty");
            else if (number == 50) Console.WriteLine("fifty");
            else if (number == 60) Console.WriteLine("sixty");
            else if (number == 70) Console.WriteLine("seventy");
            else if (number == 80) Console.WriteLine("eighty");
            else if (number == 90) Console.WriteLine("ninety");

            if (first == 2) firstNumber = "twenty";
            else if (first == 3) firstNumber = "thirty";
            else if (first == 4) firstNumber = "fourty";
            else if (first == 5) firstNumber = "fifty";
            else if (first == 6) firstNumber = "sixty";
            else if (first == 7) firstNumber = "seventy";
            else if (first == 8) firstNumber = "eighty";
            else if (first == 9) firstNumber = "ninety";
            
            if (second == 1) secondNumber = "one";
            else if (second == 2) secondNumber = "two";
            else if (second == 3) secondNumber = "three";
            else if (second == 4) secondNumber = "four";
            else if (second == 5) secondNumber = "five";
            else if (second == 6) secondNumber = "six";
            else if (second == 7) secondNumber = "seven";
            else if (second == 8) secondNumber = "eight";
            else if (second == 9) secondNumber = "nine";

            if (number > 20 && number < 30) Console.WriteLine(firstNumber + "-" + secondNumber);
            else if (number > 30 && number < 40) Console.WriteLine(firstNumber + "-" + secondNumber);
            else if (number > 40 && number < 50) Console.WriteLine(firstNumber + "-" + secondNumber);
            else if (number > 50 && number < 60) Console.WriteLine(firstNumber + "-" + secondNumber);
            else if (number > 60 && number < 70) Console.WriteLine(firstNumber + "-" + secondNumber);
            else if (number > 70 && number < 80) Console.WriteLine(firstNumber + "-" + secondNumber);
            else if (number > 80 && number < 90) Console.WriteLine(firstNumber + "-" + secondNumber);
            else if (number > 90 && number < 100) Console.WriteLine(firstNumber + "-" + secondNumber);
            else Console.WriteLine("you hit the target");
        }
        static void Main(string[] args)
        {
            Task5();
        }
    }
}
