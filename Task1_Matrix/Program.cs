/*Task 1.A diagonal matrix is a square matrix, all elements of which outside the main diagonal are
equal to zero (read here Diagonal matrix - https://en.wikipedia.org/wiki/Diagonal_matrix).
You need to create and test a class to represent a diagonal matrix containing integers (int).
1.The class object stores only the elements of the matrix located on the diagonal. For this,
a one-dimensional array is used.
2. The class object has a read-only property Size - the size of the matrix (for example, for a
5x5 matrix, the Size property returns 5).
3.The class has a constructor for creating a matrix. A list of parameters (params) is passed
to the constructor - these are the elements of the matrix located on the diagonal. If the
value of the constructor argument is not correct (for example, equal to null), a zero-size
matrix is created (Size = 0).
4.For convenience, the class offers an indexer with two indices i and j. If i is not equal to j,
then the indexer returns the value 0 (when writing, nothing happens). If the values of the
indices are not correct (out of bounds: less than zero or greater or equal to Size), nothing
happens during writing, and when reading, the value 0 is returned. (In this case an exception has
to be generated, but up to now this point wasn’t discussed).
5.The class of the matrix has an instance method Track (), which returns the sum of the
elements of the matrix located on the main diagonal.
6. Override the Equals () and ToString() methods in the matrix class. Two matrices are
considered equal if their sizes and the corresponding elements on the diagonal coincide.
7. Create a diagonal matrix extension method that adds two diagonal matrices. The result
of the method is a new diagonal matrix.If the dimensions of the matrix do not match, the
smaller matrix is padded with zeros*/
using System;
using System.Collections.Generic;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixArray1 = new int[] { 3, 3, 2 };
            var matrixArray2 = new int[] { 7, 4, 1 };


            Console.WriteLine("First matrix array numbers is:");
            foreach (var matrix in matrixArray1)
            {
                Console.Write(matrix + ", ");
            }

            Console.WriteLine("\n\nSecond matrix array numbers is:");
            foreach (var matrix in matrixArray2)
            {
                Console.Write(matrix +", ");
            }

            Console.WriteLine("\nFirst matrix");
            var matrix1 = new DiagonalMatrix(matrixArray1);
            Console.WriteLine(matrix1.ToString());

            Console.WriteLine("\nSecond matrix");
            var matrix2 = new DiagonalMatrix(matrixArray1);
            Console.WriteLine(matrix2.ToString());


            Console.WriteLine("Extended matrix");
            var extendedMatrix = MatrixExtension.creatingExtensionOfTwoDiagonalMatrix(matrix1, matrix2).ToString();
            Console.WriteLine(extendedMatrix);

            Console.ReadLine();
        }
    }
}