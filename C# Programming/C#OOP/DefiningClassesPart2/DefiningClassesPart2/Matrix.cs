using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class Matrix <T>
    {
        private T[,] matrix = new T[5,5];

        public T this[int row, int column]
        {
            get
            {
                return matrix[row, column];
            }
            set
            {
                matrix[row, column] = value;
            }
        }   

        public static Matrix<T> operator+ (Matrix<T> matrix, dynamic anotherMatrix)
        {
            var result = new Matrix<T>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(string.IsNullOrEmpty(matrix[i,j].ToString()) || string.IsNullOrEmpty(anotherMatrix[i, j].ToString()))
                    {
                        throw new ArgumentNullException("There musnt't have empty fields!");
                    }
                    result[i, j] = matrix[i, j] + anotherMatrix[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator- (Matrix<T> matrix, dynamic anotherMatrix)
        {
            var result = new Matrix<T>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (string.IsNullOrEmpty(matrix[i, j].ToString()) || string.IsNullOrEmpty(anotherMatrix[i, j].ToString()))
                    {
                        throw new ArgumentNullException("There musnt't have empty fields!");
                    }
                    result[i, j] = matrix[i, j] - anotherMatrix[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator* (Matrix<T> matrix, dynamic anotherMatrix)
        {
            var result = new Matrix<T>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (string.IsNullOrEmpty(matrix[i, j].ToString()) || string.IsNullOrEmpty(anotherMatrix[i, j].ToString()))
                    {
                        throw new ArgumentNullException("There musnt't have empty fields!");
                    }
                    result[i, j].Equals(0);
                    for (int k = 0; k < 5; k++) // OR k<b.GetLength(0)
                        result[i, j] = result[i, j] + matrix[i, k] * anotherMatrix[k, j];
                }
            }
            return result;
        }

        //public static implicit operator bool(Matrix<T> firstMatrix)       //Checks if there isn't empty fields
        //{
        //    if (firstMatrix == null)
        //    {
        //        throw new ArgumentNullException("Matrix must not be null.");
        //    }

        //    for (int row = 0; row < 5; row++)
        //    {
        //        for (int col = 0; col < 5; col++)
        //        {
        //            if (firstMatrix[row, col].Equals(default(T)))
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}


        public override string ToString()
        {
            var result = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    result.Append(matrix[i, j].ToString().PadRight(4));
                }
                if (i != 4)
                {
                    result.Append("\n");
                }
            }
            return result.ToString();
        }
    }
}
