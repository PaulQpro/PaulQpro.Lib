using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaulQpro.Lib.Math.Sets;
using PaulQpro.Lib.Math.LinearMath;
using static System.Console;

namespace Tester
{
    class Program
    {
        static void Main()
        {
            Programm();
            ReadKey();
        }
        static void Programm()
        {
            Matrix<int> matrix = new int[,] { { 10000, 0, 500 } };
            VectorInt vector = new int[] { 10000, 0 , 500 };
            WriteLine(vector);
            WriteLine(matrix);
            //WriteLine(vector.ToString(true));
        }
    }
}
