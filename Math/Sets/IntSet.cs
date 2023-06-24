using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulQpro.Lib.Math.Sets
{
    public class IntSet : Set<int>
    {
        public static implicit operator IntSet(List<int> values) => new IntSet(values);
        public static implicit operator IntSet(int[] values) => new IntSet(new List<int>(values));
        public static implicit operator List<int>(IntSet value) => value.Values;
        public static implicit operator int[](IntSet value) => value.Values.ToArray();

        private IntSet(List<int> values)
        {
            Values = values;
            Count = values.Count;
        }
    }
}
