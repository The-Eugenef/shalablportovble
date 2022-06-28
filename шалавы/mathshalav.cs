using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шалавы
{
    public class mathshalav
    {
        public float Addition(float a, float b) 
        {
            return a + b;
        }
        public float Subtraction(float a, float b)
        {
            return a - b;
        }
        public float Division(float a, float b)
        {
            return a / b;
        }
        public float Multiplication(float a, float b)
        {
            return a * b;
        }
        public float FuncPow(float a, float b)
        {
            return (float)Math.Pow(a, b);
        }
        public float Exponent(float a)
        {
            return (float)Math.Exp(a);
        }
    }
}
