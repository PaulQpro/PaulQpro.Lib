using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulQpro.Lib.Math.LinearMath
{
    public class Vector<T>
    {
        protected T[] vector;
        protected int vectorLength;

        virtual public int GetDimensions() => vectorLength;

        public T this[int i]
        {
            get => vector[i];
        }
        public static implicit operator Vector<T>(T[] values) => new Vector<T>(values);
        public static implicit operator string(Vector<T> vector) => vector.ToString();

        public string ToString(bool horizontal)
        {
            string result = "";
            if (horizontal)
            {
                result += "[ ";
                for (int i = 0; i < vectorLength; i++)
                {
                    result += vector[i].ToString() + " ";
                    if (i < vectorLength - 1) result += ", ";
                    else result += "]";
                }
            }
            else
            {
                int max_len = 0;
                for (int i = 0; i < vectorLength; i++)
                {
                    int new_len = vector[i].ToString().Length;
                    if (new_len > max_len) max_len = new_len;
                }
                for (int i = 0; i < vectorLength; i++)
                {
                    if (i == 0) result += "┌ ";
                    else if (i == vectorLength - 1) result += "└ ";
                    else result += "│ ";
                    string to_add = vector[i].ToString();
                    while (to_add.Length < max_len)
                    {
                        to_add += " ";
                    }
                    result += to_add;
                    if (i == 0) result += " ┐\n";
                    else if (i == vectorLength - 1) result += " ┘\n";
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
            vectorLength = values.Length;
            vector = values;
        }
        protected Vector() { }
    }
}