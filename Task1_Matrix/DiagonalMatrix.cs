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
        public int Size => _size;
        readonly int _size;

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 && j < 0 || i >= _size && j >= _size || i != j)
                {
                    return 0;
                }
                else if (i == j)
                {
                    return _diagonalMatrixArray[i];
                }
                else return 0;
            }
            set
            {
                if (i >= 0 && j >= 0 || i <= _size && j <= _size || i == j)
                {
                    _diagonalMatrixArray[i] = value;
                }

            }
        }
        //Params using https://www.youtube.com/watch?v=k23u6-px6Bs&ab_channel=AvetisGProgramming
        public DiagonalMatrix(params int[] DiagonalMatrixArray)
        {
            if (DiagonalMatrixArray == null)
            {
                _size = 0;
            }
            else
            {
                _size = DiagonalMatrixArray.Length;
                _diagonalMatrixArray = new int[_size];
                Array.Copy(DiagonalMatrixArray, _diagonalMatrixArray, _size);
            }
        }

        


        public override string ToString()
        {
            var sb = new StringBuilder();
            if (Size == 0)
            {
                return string.Empty;
            }
            //a loop for creating a matrix, iterating through rows and columns:
            for (int row = 0; row < _size; row++)
            {
                sb.AppendLine();
                for (int column = 0; column < _size; column++)
                {
                    sb.Append(this[row, column]);
                }
            }
            return sb.ToString();
        }

        public int Track()
        {
            return _diagonalMatrixArray.Sum();
        }

    }
}
