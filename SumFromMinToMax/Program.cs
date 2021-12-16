/*Task 3. The application asks the user for the number of elements in a numeric array (at
least two), and then in a loop -the elements themselves (of int type). After entering the
elements, the application prints out the original array and outputs the sum of the array
elements located between the smallest element in the array (the leftmost element if there
are several) and the largest element (the rightmost element if there are several). Develop
a console application that implements the specified functionality.
Example: array[1, 3, 5, 1, 0, 3, 0, 1].The sum of the required elements = 5 + 1 + 0 = 6.
Note 1: the correctness of the length of the array can be left unchecked.

Note 2: The smallest and largest items are to be included in the amount.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 8, 8, 0, 8, 5, 6 };
            SumFromMaxToMinFinder(array);
        }

        static void SumFromMaxToMinFinder(int[] array)
        {
            var arrayAsList = array.ToList();

            //Finding max value and max index
            int maxValue = array.Max();
            int maxIndex = arrayAsList.IndexOf(maxValue);

            //Finding min value and min index
            int minValue = array.Min();
            int minIndex = arrayAsList.IndexOf(minValue);

            var count = 0;
            //method which helps to find how much elements I need to go throw from minIndex to maxIndex or opposite. Adding +1 for having correct counting
            if (minIndex > maxIndex)
            {
                count = minIndex - maxIndex + 1;
            }
            else
            {
                count = maxIndex - minIndex + 1;
            }

            var startIndex = 0;
            //method for finding out from which side program should count the range for Sum
            if (minIndex > maxIndex)
            {
                startIndex = maxIndex;
            }
            else
            {
                startIndex = minIndex;
            }

            //Getting range from minValue to maxValue
            var range = arrayAsList.GetRange(startIndex, count);
            //Getting sum from range
            var Sum = range.Sum();

            //Find method how to writeline array to console without using for cicle
            //https://stackoverflow.com/questions/16265247/printing-all-contents-of-array-in-c-sharp
            Console.WriteLine(string.Join(", ",array));
            Console.WriteLine("\nMaxValue is {0} and max Index is {1}", maxValue, maxIndex);
            Console.WriteLine("MinValue is {0} and min Index is {1}",minValue, minIndex);
            Console.WriteLine("\nSum of max and min is {0} it needs to run throw {1} elements to find sum of min and max", Sum, count);
            
        }

    }


}
