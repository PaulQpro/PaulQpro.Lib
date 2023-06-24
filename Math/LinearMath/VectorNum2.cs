using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaulQpro.Lib.Math.Numbers;

namespace PaulQpro.Lib.Math.LinearMath
{
    public class VectorNum2 : Vector<double>
    {
        new protected int VectorLength { get; } = 2;
        public double X { get => VectorValues[0]; }
        public double Y { get => VectorValues[1]; }

        override public int GetDimensions() => VectorLength;

        public static implicit operator VectorNum2(double[] values) => new VectorNum2(values);
        public static implicit operator VectorInt(VectorNum2 vector) => (VectorInt)vector.VectorValues;
        public static implicit operator VectorNum(VectorNum2 vector) => vector.VectorValues;
        public static explicit operator Complex(VectorNum2 vector) => new Complex(vector[0], vector[1]);

        protected VectorNum2(double[] values)
        {
            if (values.Length == 2)
            {
                VectorValues = values;
            }
            else if (values.Length < 2)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    VectorValues[i] = values[i];
                }
                for (int i = values.Length; i < 2; i++)
                {
                    VectorValues[i] = 0;
                }
            }
            else throw new ArgumentOutOfRangeException("values", $"Array is too long, {values.Length} instead of 2");
        }
    }
}
