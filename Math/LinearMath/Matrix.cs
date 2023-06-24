using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulQpro.Lib.Math.LinearMath
{
    public class Matrix<T>
    {
        protected T[,] MatrixValues { get; set; }
        protected VectorInt2 MatrixLength { get; }

        virtual public VectorInt2 GetDimensions() => MatrixLength;

        public T this[int x, int y]
        {
            get => MatrixValues[x, y];
        }
        public static implicit operator Matrix<T>(T[,] values) => new Matrix<T>(values);
        public static implicit operator string(Matrix<T> matrix) => matrix.ToString();

        public override string ToString()
        {
            string result = "";
            int[] max_len = new int[MatrixLength.X];
            for(int x = 0; x < MatrixLength.X; x++)
            {
                for(int y = 0; y < MatrixLength.Y; y++)
                {
                    int new_len = this[x, y].ToString().Length;
                    if (new_len > max_len[x]) max_len[x] = new_len;
                }
            }
            for(int y = 0; y < MatrixLength.Y; y++)
            {
                if (y == 0) result += "╓ ";
                else if (y == MatrixLength.Y - 1) result += "╙ ";
                else result += "║ ";
                for (int x = 0; x < MatrixLength.X; x++)
                {
                    string to_add = MatrixValues[x, y].ToString();
                    while (to_add.Length < max_len[x] )
                    {
                        to_add += " ";
                    } 
                    result += to_add;
                    if (x < MatrixLength.X - 1) result += " , ";
                    else if (y == 0) result += " ╖\n";
                    else if (y == MatrixLength.Y - 1) result += " ╜\n";
                    else result += " ║\n";
                }
            }
            return result;
        }

        protected Matrix(T[,] values)
        {
            MatrixLength = new int[] { values.GetLength(0), values.GetLength(1) };
            MatrixValues = values;
        }
        protected Matrix() { }
    }
}
