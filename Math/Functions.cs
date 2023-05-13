using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulQpro.Lib.Math
{
    public static class Functions
    {
        static public double Sum(int n, int m, Func<double, double> f)
        {
            double result = n;
            for (int i = n+1; i <= m; i++)
            {
                result += f(i);
            }
            return result;
        }
        static public double Prod(int n, int m, Func<double, double> f)
        {
            double result = n;
            for (int i = n+1; i <= m; i++)
            {
                result *= f(i);
            }
            return result;
        }
    }
}
