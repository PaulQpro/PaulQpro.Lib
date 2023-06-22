using Maths = System.Math;

namespace PaulQpro.Lib.Math.LinearMath
{
    public class VectorInt : Vector<int>
    {
        public double Length { 
            get{
                double result = 0;
                foreach(int val in vector)
                {
                    result += Maths.Pow(val, 2);
                }
                result = Maths.Sqrt(result);
                return result;
            } 
        }

        public static implicit operator VectorInt(int[] values) => new VectorInt(values);
        public static explicit operator VectorInt(double[] values) => new VectorInt(values);
        public static implicit operator VectorNum(VectorInt vector) => vector.vector;
        protected VectorInt(int[] values)
        {
            vectorLength = (int)values.Length;
            vector = values;
        }
        protected VectorInt(double[] values)
        {
            vectorLength = (int)values.Length;
            vector = new int[values.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = (int)values[i];
            }
        }
    }
}