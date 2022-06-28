using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шалавы
{
    public class mathshalav
    {
        public double Addition(double a, double b)
        {
            return a + b;
        }
        public double Subtraction(double a, double b)
        {
            return a - b;
        }
        public double Division(double a, double b)
        {
            return a / b;
        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double FuncPow(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public double Exponent(double a)
        {
            return (float)Math.Exp(a);
        }
    }
}
