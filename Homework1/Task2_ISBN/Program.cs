
/*
The 10-digit ISBN is a numeric code that uniquely identifies a book. It has the
following form: d1d2d3d4d5d6d7d8d9d10.. Digit d10 is a control one. It is calculated
according to the condition that the expression

10d1 + 9d2 + 8d3+.. .+ 1d10

(the sum of the products of code elements by the weight of their positions) must be a
multiple of 11. Create a program that prompts the user for a 9 character-digit string (the
first nine digits of the ISBN), calculates the check digit, and prints the resulting ISBN. Do
not check the correctness of the user's input - assume that the user does not make
mistakes when entering.
Note 1: the check "digit" can be equal to 10. In this case, the symbol X is used to denote it.
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {   //Reading input value
            Console.WriteLine("Please enter 9 digit number: ");
            var nineDigitNumber = Console.ReadLine();
            //Calculating the last character for ISBN
            Console.WriteLine(CheckDigit(nineDigitNumber));

            Console.ReadKey();
        }

        //Method for finding Sum of nine digits by calculation ((10*d1)+(9*d2)+(8*d3)+(7*d4)+(6*d5)+(5*d6)+(4*d7)+(3*d8)+(2*d9))
        static int sumOfNineDigits(string nineDigits)
        {
            int multiplier = 10;
            int sum = 0;

            for (int i = 0; i < 9; i++)
            {
                //bellow loop is: ((10*d1)+(9*d2)+(8*d3)+(7*d4)+(6*d5)+(5*d6)+(4*d7)+(3*d8)+(2*d9))
                //Solution which I found how to convert char to int https://stackoverflow.com/questions/239103/convert-char-to-int-in-c-sharp
                sum += (nineDigits[i] - '0') * (multiplier - i);
            }

            return sum;
        }

        //Method for checking if Sum of nine digits is multiple of 11 or not and giving the last character for ISBN
        static string CheckDigit(string nineDigits)
        {
            string result;
            int checkDigit = 0;
            int finalDigit = 0;
         
            checkDigit = sumOfNineDigits(nineDigits) % 11;
            finalDigit = 11 - checkDigit;
            //If finalDigit is equal to 10 then last character is X
            if (finalDigit == 10)
            {
                result = nineDigits + "-X";
            }
            //Else last chareacter is finalDigit
            else
            {
                result = nineDigits + "-" + finalDigit.ToString();
            }

            return result;
        }
    }
}
