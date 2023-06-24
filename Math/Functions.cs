using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        static public BigInteger Factorial(uint n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        static public double Sqr(double a) { return System.Math.Pow(a, 2); }
    }
}
