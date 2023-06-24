using System;

namespace PaulQpro.Lib.Math.LinearMath
{
    public class VectorInt2 : Vector<int>
    {
        new protected int VectorLength { get; } = 2;
        public int X { get => VectorValues[0]; }
        public int Y { get => VectorValues[1]; }

        override public int GetDimensions() => VectorLength;

        public static implicit operator VectorInt2(int[] values) => new VectorInt2(values);
        public static implicit operator VectorInt(VectorInt2 vector) => vector.VectorValues;
        public static implicit operator VectorNum(VectorInt2 vector) => vector.VectorValues;

        protected VectorInt2(int[] values)
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