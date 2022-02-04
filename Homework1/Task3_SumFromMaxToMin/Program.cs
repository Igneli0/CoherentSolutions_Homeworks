/*Task 3. The application asks the user for the number of elements in a numeric array (at
least two), and then in a loop -the elements themselves (of int type). After entering the
elements, the application prints out the original array and outputs the sum of the array
elements located between the smallest element in the array (the leftmost element if there
are several) and the largest element (the rightmost element if there are several). Develop
a console application that implements the specified functionality.
Example: array[1, 3, 5, 1, 0, 3, 0, 1].The sum of the required elements = 5 + 1 + 0 = 6.
Note 1: the correctness of the length of the array can be left unchecked.

Note 2: The smallest and largest items are to be included in the amount. { 8, 8, 1, 8, 1, 6 } */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 8, 8, 0, 1, 5, 6 }; 
            SumFromMaxToMinFinder(array);

            Console.ReadKey();
        }

        static void SumFromMaxToMinFinder(int[] array)
        {
            var arrayAsList = array.ToList();

            //Finding min value and min index
            int minValue = array.Min();
            int minIndex = arrayAsList.IndexOf(minValue);

            //Finding max value and max index
            int maxValue = array.Max();
            //Using LastIndexOf to find last index of max value
            int maxIndex = arrayAsList.LastIndexOf(maxValue);

            var sum = 0;

            for (int i = 0; i < arrayAsList.Count; i++)
            {   
                //If first we have max number and after we have min number this if will work
                if (i <= minIndex && i >= maxIndex)
                {
                    sum+= arrayAsList[i];
                }
                //Otherwise if we have first min number and later max number this if will work
                else if (i >= minIndex && i <= maxIndex)
                {
                    sum += arrayAsList[i];
                }
            }

            //Find method how to writeline array to console without using for cicle
            //https://stackoverflow.com/questions/16265247/printing-all-contents-of-array-in-c-sharp
            Console.WriteLine(string.Join(", ",array));
            Console.WriteLine("\nMinValue is {0} and min Index is {1}", minValue, minIndex);
            Console.WriteLine("MaxValue is {0} and max Index is {1}", maxValue, maxIndex);
            Console.WriteLine("\nSum between min and max is {0}", sum);
            
        }

    }


}
