using System;

namespace PaulQpro.Lib.Math.LinearMath
{
    public class VectorInt2 : Vector<int>
    {
        new protected const int vectorLength = 2;
        public int X { get => vector[0]; }
        public int Y { get => vector[1]; }

        override public int GetDimensions() => vectorLength;

        public static implicit operator VectorInt2(int[] values) => new VectorInt2(values);
        public static implicit operator VectorInt(VectorInt2 vector) => vector.vector;
        public static implicit operator VectorNum(VectorInt2 vector) => vector.vector;

        protected VectorInt2(int[] values)
        {
            if (values.Length == 2)
            {
                vector = values;
            }
            else if (values.Length < 2)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    vector[i] = values[i];
                }
                for (int i = values.Length; i < 2; i++)
                {
                    vector[i] = 0;
                }
            }
            else throw new ArgumentOutOfRangeException("values", $"Array is too long, {values.Length} instead of 2");
        }
    }
}