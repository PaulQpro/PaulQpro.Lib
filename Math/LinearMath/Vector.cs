using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulQpro.Lib.Math.LinearMath
{
    public class Vector<T>
    {
        protected T[] VectorValues { get; set; }
        protected int VectorLength { get; set; }

        virtual public int GetDimensions() => VectorLength;

        public T this[int i]
        {
            get => VectorValues[i];
        }
        public static implicit operator Vector<T>(T[] values) => new Vector<T>(values);
        public static implicit operator string(Vector<T> vector) => vector.ToString();

        public string ToString(bool horizontal)
        {
            string result = "";
            if (horizontal)
            {
                result += "[ ";
                for (int i = 0; i < VectorLength; i++)
                {
                    result += VectorValues[i].ToString() + " ";
                    if (i < VectorLength - 1) result += ", ";
                    else result += "]";
                }
            }
            else
            {
                int max_len = 0;
                for (int i = 0; i < VectorLength; i++)
                {
                    int new_len = VectorValues[i].ToString().Length;
                    if (new_len > max_len) max_len = new_len;
                }
                for (int i = 0; i < VectorLength; i++)
                {
                    if (i == 0) result += "┌ ";
                    else if (i == VectorLength - 1) result += "└ ";
                    else result += "│ ";
                    string to_add = VectorValues[i].ToString();
                    while (to_add.Length < max_len)
                    {
                        to_add += " ";
                    }
                    result += to_add;
                    if (i == 0) result += " ┐\n";
                    else if (i == VectorLength - 1) result += " ┘\n";
                    else result += " │\n";
                }
            }
            return result;
        }
        public override string ToString()
        {
            return ToString(false);
        }

        protected Vector(T[] values)
        {
            VectorLength = values.Length;
            VectorValues = values;
        }
        protected Vector() { }
    }
}