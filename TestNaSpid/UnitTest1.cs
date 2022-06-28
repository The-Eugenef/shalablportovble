using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using шалавы;

namespace TestNaSpid.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Skladuvaet()
        {
            float x = 47.3F, y = 84.12F;
            float expected = x + y;
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Addition(x, y);
            Assert.AreEqual(expected, actual, "PEREDELAI!!!");
        }

        [TestMethod]
        public void Otnimaet()
        {
            float x = 216.97F, y = 81.28F;
            float expected = x - y;
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Subtraction(x, y);
            Assert.AreEqual(expected, actual, "PEREDELAI!!!");
        }

        [TestMethod]
        public void Umnozhaet()
        {
            float x = 123F, y = 321F;
            float expected = x * y;
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Multiplication(x, y);
            Assert.AreEqual(expected, actual, "PEREDELAI!!!");
        }

        [TestMethod]
        public void Delit()
        {
            float x = 999.99F, y = 111.11F;
            float expected = x / y;
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Division(x, y);
            Assert.AreEqual(expected, actual, "PEREDELAI!!!");
        }

        [TestMethod]
        public void Stepenit()
        {
            float x = 11F, y = 4F;
            float expected = (float)Math.Pow(x, y);
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.FuncPow(x, y);
            Assert.AreEqual(expected, actual, "PEREDELAI!!!");
        }

        [TestMethod]
        public void Exponiruet()
        {
            float x = 5F;
            float expected = (float)Math.Exp(x);
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Exponent(x);
            Assert.AreEqual(expected, actual, "PEREDELAI!!!");
        }
    }
}
