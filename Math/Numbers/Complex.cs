using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaulQpro.Lib.Math.LinearMath;
using static System.Math;

namespace PaulQpro.Lib.Math.Numbers
{
    public class Complex
    {
        public double Real { get; }
        public double Imaginary { get; }

        public static Complex operator + (Complex a, Complex b) => new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        public static Complex operator -(Complex a, Complex b) => new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        public static Complex operator *(Complex a, Complex b) => new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Imaginary * b.Real + a.Real * b.Imaginary);
        public static Complex operator /(Complex a, Complex b) => new Complex((a.Real * b.Real + a.Imaginary * b.Imaginary) / (Pow(b.Real, 2) + Pow(b.Imaginary, 2)), (a.Imaginary * b.Real - a.Real * b.Imaginary) / (Pow(b.Real, 2) + Pow(b.Imaginary, 2)));

        public static implicit operator string(Complex number) => number.ToString();
        public static explicit operator VectorNum2(Complex number) => new double[] { number.Real, number.Imaginary };

        public override string ToString()
        {
            if (Real == 0 && Imaginary != 0) return $"({Imaginary}i)";
            else if (Imaginary == 0) return $"({Real})";
            else return $"({Real} + {Imaginary}i)";
        }

        public Complex(double Re, double Im)
        {
            Real = Re;
            Imaginary = Im;
        }
    }
}
