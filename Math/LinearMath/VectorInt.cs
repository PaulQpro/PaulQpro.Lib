using Maths = System.Math;

namespace PaulQpro.Lib.Math.LinearMath
{
    public class VectorInt : Vector<int>
    {
        public double Length { 
            get{
                double result = 0;
                foreach(int val in VectorValues)
                {
                    result += Maths.Pow(val, 2);
                }
                result = Maths.Sqrt(result);
                return result;
            } 
        }

        public static implicit operator VectorInt(int[] values) => new VectorInt(values);
        public static explicit operator VectorInt(double[] values) => new VectorInt(values);
        public static implicit operator VectorNum(VectorInt vector) => vector.VectorValues;
        protected VectorInt(int[] values)
        {
            VectorLength = (int)values.Length;
            VectorValues = values;
        }
        protected VectorInt(double[] values)
        {
            VectorLength = (int)values.Length;
            VectorValues = new int[values.Length];
            for (int i = 0; i < VectorValues.Length; i++)
            {
                VectorValues[i] = (int)values[i];
            }
        }
    }
}