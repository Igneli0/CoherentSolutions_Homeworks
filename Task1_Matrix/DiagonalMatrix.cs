using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class DiagonalMatrix
    {
        private int[] _diagonalMatrixArray;
        public int Size { get; }

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 && j < 0 || i >= Size && j >= Size)
                {
                    throw new IndexOutOfRangeException();
                }
                else if (i == j)
                {
                    return _diagonalMatrixArray[i];
                }
                else if(i != j)
                {
                    return 0;
                }
                else return 0;
            }
            set
            {
                if (i >= 0 && j >= 0 || i == j || i <= Size && j <= Size)
                {
                    _diagonalMatrixArray[i] = value;
                }

            }
        }
        //Params using https://www.youtube.com/watch?v=k23u6-px6Bs&ab_channel=AvetisGProgramming
        //Creating matrix
        public DiagonalMatrix(params int[] DiagonalMatrixArray)
        {
            if (DiagonalMatrixArray == null)
            {
                Size = 0;
            }
            else
            {
                Size = DiagonalMatrixArray.Length;
                _diagonalMatrixArray = new int[Size];
                Array.Copy(DiagonalMatrixArray, _diagonalMatrixArray, Size);
            }
        }
        //Printing matrix
        public string PrintMatrixElements()
        {
            var builder = new StringBuilder();

            if (Size == 0)
            {
                throw new IndexOutOfRangeException();
            }

            for (int row = 0; row < Size; row++)
            {
                builder.AppendLine();
                for (int column = 0; column < Size; column++)
                {
                    builder.Append(this[row, column]);
                }
            }
            return builder.ToString();
        }

        public override bool Equals(object obj)
        {
            var testMatrix = obj as DiagonalMatrix;

            if (testMatrix == null || GetType() != obj.GetType() || Size != testMatrix.Size)
            {
                return false;
            }

            for (int i = 0; i < _diagonalMatrixArray.Length; i++)
            {
                if (_diagonalMatrixArray[i] != testMatrix._diagonalMatrixArray[i])
                {
                    return false;
                }
            }

            return true;
        }
        public override string ToString() { return PrintMatrixElements(); }

        public int Track() { return _diagonalMatrixArray.Sum(); }

    }
}
