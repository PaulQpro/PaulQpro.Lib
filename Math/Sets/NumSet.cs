using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulQpro.Lib.Math.Sets
{
    public class NumSet : Set<double>
    {
        public static implicit operator NumSet(List<double> values) => new NumSet(values);
        public static implicit operator NumSet(double[] values) => new NumSet(new List<double>(values));
        public static implicit operator List<double>(NumSet value) => value.Values;
        public static implicit operator double[](NumSet value) => value.Values.ToArray();

        private NumSet(List<double> values)
        {
            Values = values;
            Count = values.Count;
        }
    }
}
