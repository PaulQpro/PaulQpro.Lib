using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulQpro.Lib.Math.Sets
{
    public class Set<T>
    {
        protected List<T> Values { get; set; }
        public int Count { get; protected set; }

        public bool Has(T value)
        {
            foreach (T Value in Values)
            {
                if (Value.Equals(value)) return true;
            }
            return false;
        }
        ///<summary>index must be zero or positive</summary>
        /// <param name="index">Must be not negative</param>
        public T this[int index]
        {
            get {
                if (index >= 0) return Values[index];
                else throw new ArgumentOutOfRangeException();
            }
        }
        public static implicit operator Set<T>(List<T> values) => new Set<T>(values);
        public static implicit operator Set<T>(T[] values) => new Set<T>(new List<T>(values));
        public static implicit operator List<T>(Set<T> value) => value.Values;
        public static implicit operator T[](Set<T> value) => value.Values.ToArray();

        protected Set(List<T> values)
        {
            Values = values;
            Count = values.Count;
        }
        protected Set() { }
    }
}
