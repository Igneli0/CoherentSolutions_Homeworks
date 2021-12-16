using System;
using System.Collections.Generic;
using System.Linq;


/*Task 1.Create a console application, whichasks the user for two integers a and b (assume
that the user enters integers without errors). The application then prints out all integers
in the range from a (inclusive) to b(inclusive) that have exactly two 2's in their ternary
number system (0, 1, 2) representation.Develop a console application that implements
the specified functionality.
Note: to convert a string s to an int value, use the int.Parse(s) method.
*/


namespace HomeWork1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Asking to enter values
            Console.Write("Enter number1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number2: ");
            int num2 = int.Parse(Console.ReadLine());
            //Making calculation and giving the result
            OutPutTernariesWithTwo(num1, num2);

            Console.ReadKey();
        }
        //Method for corverting numbers to ternary
        static private string ConvertToTernary(int N)
        {
            string ternaryNum = String.Empty;
            //If number is 0 it returns 0
            if (N == 0)
                return ternaryNum = "0";
            //If number is not 0 it calculates ternary
            while (N >= 1)
            {
                ternaryNum += N % 3;
                N /= 3;
            }
            return ternaryNum;
        }
        //Method for searching if ternary has two's
        static void HasTwo(int num1, int num2)
        {
            string numbers;
            string result;

            for (int i = num1; i <= num2; i++)
            {
                numbers = ConvertToTernary(i);
                //Counting 2's in numbers
                int twoTwice = numbers.Count(f => f == '2');
                //Checking if there is two 2's
                if (twoTwice == 2)
                {
                    result = Convert.ToString(i);
                    Console.Write("{0}, ", result);
                }
            }
        }
        //Writing down all integers to console and calling HasTwo to make calculation
        static void OutPutTernariesWithTwo(int num1, int num2)
        {
            Console.WriteLine("\nPrinting all integers in the range from {0} to {1} that have exactly two 2's in their ternary: ", num1, num2);
            HasTwo(num1, num2);
        }
    }
}