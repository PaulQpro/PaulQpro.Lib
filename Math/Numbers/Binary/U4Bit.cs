using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulQpro.Lib.Math.Numbers.Binary
{   
    public class U4Bit : UXBit
    {
        private bool[] Value { get; }
        override public byte Bits { get; protected set; } = 4;
        new static public byte MaxValue { get; } = 15;
        
        static public explicit operator U4Bit(bool[] value)
        {
            if (value.Length > 4)
            {
                bool[] preResult = new bool[64];
                for (int i = 0; i < 64; i++)
                {
                    preResult[i] = value[i];
                }
                return (U4Bit)preResult;
            }
            else
            {
                U4Bit result = new U4Bit();
                for (int i = 0; i < value.Length; i++)
                {
                    result.Value[i] = value[i];
                }
                return result;
            }
        }
        static public explicit operator bool[](U4Bit value)
        {
            return value.Value;
        }

        protected U4Bit()
        {
            Value = new bool[Bits];
            for (byte i = 0; i < Bits; i++)
            {
                Value[i] = false;
            }
        }
    }
}
