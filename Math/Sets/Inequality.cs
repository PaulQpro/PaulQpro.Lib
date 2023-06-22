using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulQpro.Lib.Math.Sets
{
    public class Inequality
    {
        public double TopBoundary { get; }
        public double LowBoundary { get; }
        public bool TopStrict { get; }
        public bool LowStrict { get; }

        public bool Has(double value)
        {
            if (LowStrict && TopStrict) return LowBoundary < value && value < TopBoundary;
            else if (LowStrict && !TopStrict) return LowBoundary < value && value <= TopBoundary;
            else if (!LowStrict && TopStrict) return LowBoundary <= value && value < TopBoundary;
            else return LowBoundary <= value && value <= TopBoundary;
        }
        static public bool IsValueBelongsToInequality(double value, Inequality inequality)
        {
            return inequality.Has(value);
        }
        /// <summary>
        /// Converts Inequality type to String type
        /// </summary>
        /// <param name="chainedNotation"></param>
        /// <param name="codeNotation">Works only with chainedNotation = true</param>
        /// <returns></returns>
        public string ToString(bool chainedNotation, bool codeNotation)
        {
            string result = "";
            if (chainedNotation)
            {
                result += LowBoundary;
                if (LowStrict) result += '<';
                else if (codeNotation) result += "<=";
                else result += '≤';
                result += 'x';
                if (TopStrict) result += '<';
                else if (codeNotation) result += "<=";
                else result += '≤';
                result += TopBoundary;
            }
            else
            {
                if (LowStrict) result += '(';
                else result += '[';
                result += $"{LowBoundary};{TopBoundary}";
                if (TopStrict) result += ')';
                else result += ']';
            }
            return result;
        }
        public string ToString(bool chainedNotation)
        {
            string result = "";
            if (chainedNotation)
            {
                result += LowBoundary;
                if (LowStrict) result += '<';
                else result += "<=";
                result += 'x';
                if (TopStrict) result += '<';
                else result += "<=";
                result += TopBoundary;
            }
            else
            {
                if (LowStrict) result += '(';
                else result += '[';
                result += $"{LowBoundary};{TopBoundary}";
                if (TopStrict) result += ')';
                else result += ']';
            }
            return result;
        }
        public override string ToString()
        {
            string result = "";
            if (LowStrict) result += '(';
            else result += '[';
            result += $"{LowBoundary};{TopBoundary}";
            if (TopStrict) result += ')';
            else result += ']';
            return result;
        }
        public Inequality(double bottom, double top, bool strict)
        {
                TopBoundary = top;
                LowBoundary = bottom;
                TopStrict = strict;
                LowStrict = strict;
            }
        public Inequality(double bottom, double top, bool bottomStrict, bool topStrict)
        {
            TopBoundary = top;
            LowBoundary = bottom;
            TopStrict = topStrict;
            LowStrict = bottomStrict;
        }
    }
}
