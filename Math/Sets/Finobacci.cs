using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulQpro.Lib.Math.Sets
{
    public static class Finobacci
    {
        /// <summary>
        /// Return Finobacci numbers up to positive index
        /// </summary>
        /// <param name="index">Must be positive</param>
        public static IntSet GetUpTo(int index)
        {
            if (index <= 0) throw new ArgumentOutOfRangeException();
            else if (index == 1) return new List<int> { 1 };
            else if (index == 2) return new List<int> { 1, 1 };
            List<int> preResult = new List<int> { 1, 1 };
            for (int i = 2; i < index; i++)
            {
                preResult.Add(preResult[i - 2] + preResult[i - 1]);
            }
            return preResult;
        }
        /// <summary>
        /// Return n Finobacci number (0th number is 0)
        /// </summary>
        /// <param name="index">Must be not negative</param>
        /// <returns></returns>
        public static double Get(int index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException();
            else if (index == 0) return 0;
            IntSet F = GetUpTo(index);
            return F[F.Count - 1];
        }
    }
}
