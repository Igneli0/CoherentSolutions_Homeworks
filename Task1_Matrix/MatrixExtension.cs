using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal static class MatrixExtension
    {

        //Method for creating one matrix out of two
       public static DiagonalMatrix creatingExtensionOfTwoDiagonalMatrix(this DiagonalMatrix first, DiagonalMatrix second)
        {
            var newMatrixLength = 0;

            if (first.Size > second.Size || first.Size == second.Size)
            {
                newMatrixLength = first.Size;
            }

            else if (first.Size < second.Size || first.Size == second.Size)
            {
                newMatrixLength = second.Size;
            }
            int[] array = new int[newMatrixLength];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = first[i, i] + second[i, i];
            }
            return new DiagonalMatrix(array);
        }
        
    }
}
