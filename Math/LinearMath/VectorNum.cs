namespace PaulQpro.Lib.Math.LinearMath
{
    public class VectorNum : Vector<double>
    {
        public static implicit operator VectorNum(double[] values) => new VectorNum(values);
        public static implicit operator VectorNum(int[] values) => new VectorNum(values);
        public static explicit operator VectorInt(VectorNum vector) => (VectorInt)vector.VectorValues;
        protected VectorNum(double[] values)
        {
            VectorLength = (int)values.Length;
            VectorValues = values;
        }
        protected VectorNum(int[] values)
        {
            VectorLength = (int)values.Length;
            VectorValues = new double[values.Length];
            for(int i = 0; i< VectorValues.Length; i++)
            {
                VectorValues[i] = values[i];
            }
        }
    }
}