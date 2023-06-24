using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaulQpro.Lib.Math;
using Maths = System.Math;

namespace PaulQpro.Lib.Math.Numbers.Binary
{
    /// <summary>
    /// 1 to 64 length binary number as boolean array
    /// </summary>
    public class UXBit
    {
        private bool[] Value { get; set; }
        public ulong MaxValue { get; }
        virtual public byte Bits { get; protected set; }

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
        static public explicit operator bool[](UXBit value) => value.Value;
        static public implicit operator ulong(UXBit value)
        {
            ulong result = 0;
            for(int i = 0; i < value.Bits; i++)
            {
                ulong j = 0;
                if(value.Value[value.Bits - 1 - i])
                {
                    j = 1;
                }
                result += (ulong)Maths.Pow(2, i)*j;
            }
            return result;
        }
        static public implicit operator UXBit(ulong value)
        {
            UXBit result = new UXBit
            {
                Bits = (byte)Maths.Ceiling(Maths.Log(value, 2))
            };
            result.Value = new bool[result.Bits];
            for (int i = 0; i < result.Bits; i++)
            {
                switch (value % 2)
                {
                    case 1: result.Value[result.Bits - 1 - i] = true; break;
                    case 0: result.Value[result.Bits - 1 - i] = false; break;
                }
                value /= 2;
            }
            return result;
        }

        public string ToString(bool asBool)
        {
            string result = "";
            if (asBool)
            {
                result += "[";
                for(int i = 0; i < Bits; i++)
                {
                    result += Value[i];
                    if(i < Bits - 1)
                    {
                        result += ",";
                    }
                }
                result += "]";
            }
            else
            {
                result += "b";
                foreach(bool val in Value)
                {
                    switch (val)
                    {
                        case true: result += 1; break;
                        case false: result += 0; break;
                    }
                }
            }
            return result;
        }
        public override string ToString()
        {
            return ((ulong)this).ToString();
        }

        protected UXBit(byte length)
        {
            if (length >= 1 && length <= 64)
            {
                Bits = length;
                Value = new bool[Bits];
                for (byte i = 0; i < Bits; i++)
                {
                    Value[i] = false;
                }
                MaxValue = (ulong)Maths.Pow(2, Bits) - 1;
            }
            else throw new ArgumentOutOfRangeException();
        }
        protected UXBit() { }
    }
}
