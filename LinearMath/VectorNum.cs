namespace PaulQpro.Lib.Math.LinearMath
{
    public class VectorNum : Vector<double>
    {
        public static implicit operator VectorNum(double[] values) => new VectorNum(values);
        public static implicit operator VectorNum(int[] values) => new VectorNum(values);
        public static explicit operator VectorInt(VectorNum vector) => (VectorInt)vector.vector;
        protected VectorNum(double[] values)
        {
            vectorLength = (int)values.Length;
            vector = values;
        }
        protected VectorNum(int[] values)
        {
            vectorLength = (int)values.Length;
            vector = new double[values.Length];
            for(int i = 0; i< vector.Length; i++)
            {
                vector[i] = values[i];
            }
        }
    }
}