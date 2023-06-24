using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaulQpro.Lib.Math.LinearMath;
using static PaulQpro.Lib.Math.Functions;

namespace PaulQpro.Lib.Math.Numbers
{
    public class Complex
    {
        private double Real { get; }
        private double Imaginary { get; }

        public static Complex operator +(Complex a, Complex b) => new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        public static Complex operator -(Complex a, Complex b) => new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        public static Complex operator *(Complex a, Complex b) => new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Imaginary * b.Real + a.Real * b.Imaginary);
        public static Complex operator /(Complex a, Complex b) => new Complex((a.Real * b.Real + a.Imaginary * b.Imaginary) / (Sqr(b.Real) + Sqr(b.Imaginary)), (a.Imaginary * b.Real - a.Real * b.Imaginary) / (Sqr(b.Real) + Sqr(b.Imaginary)));

        public static implicit operator string(Complex number) => number.ToString();
        public static explicit operator VectorNum2(Complex number) => new double[] { number.Real, number.Imaginary };

        public static double Re(Complex number) { return number.Real; }
        public double Re() { return Real; }
        public static double Im(Complex number) { return number.Imaginary; }
        public double Im() { return Imaginary; }

        public override string ToString()
        {
            if (Real == 0 && Imaginary == 1) return "(i)";
            else if (Real == 0 && Imaginary != 0) return $"({Imaginary}i)";
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
