using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace PaulQpro.Lib.Math.Numbers.Binary
{
    public class UXBit
    {
        private bool[] Value { get; }
        public ulong MaxValue { get; }
        virtual public byte Bits { get; }

        static public explicit operator UXBit(bool[] value)
        {
            if(value.Length > 64)
            {
                bool[] preResult = new bool[64];
                for (int i = 0; i < 64; i++)
                {
                    preResult[i] = value[i];
                }
                return (UXBit)preResult;
            }
            else
            {
                UXBit result = new UXBit((byte)value.Length);
                for(int i = 0; i < value.Length; i++)
                {
                    result.Value[i] = value[i];
                }
                return result;
            }
        }
        static public explicit operator bool[](UXBit value)
        {
            return value.Value;
        }

        /// <summary>
        /// Creates custom length Binary number
        /// </summary>
        /// <param name="length">
        /// Length (number of bits) in number 1<=length<=64
        /// </param>
        public UXBit(byte length)
        {
            if (length >= 1 && length <= 64)
            {
                Bits = length;
                Value = new bool[Bits];
                for (byte i = 0; i < Bits; i++)
                {
                    Value[i] = false;
                }
                MaxValue = (ulong)Pow(2, Bits) - 1;
            }
            else throw new ArgumentOutOfRangeException();
        }
        internal UXBit() { }
    }
}
