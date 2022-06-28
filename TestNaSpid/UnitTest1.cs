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
            string c = "+";
            float expected = x + y;
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Calculate(x, y, c);
            Assert.AreEqual(expected, actual, "PEREDELAI!!!");
        }

        [TestMethod]
        public void Otnimaet()
        {
            float x = 216.97F, y = 81.28F;
            string c = "-";
            float expected = x - y;
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Calculate(x, y, c);
            Assert.AreEqual(expected, actual, "PEREDELAI!!!");
        }

        [TestMethod]
        public void Umnozhaet()
        {
            float x = 123F, y = 321F;
            string c = "*";
            float expected = x * y;
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Calculate(x, y, c);
            Assert.AreEqual(expected, actual, "PEREDELAI!!!");
        }

        [TestMethod]
        public void Delit()
        {
            float x = 999.99F, y = 111.11F;
            string c = "/";
            float expected = x / y;
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Calculate(x, y, c);
            Assert.AreEqual(expected, actual, "PEREDELAI!!!");
        }

        [TestMethod]
        public void Stepenit()
        {
            float x = 11F, y = 4F;
            string c = "^";
            float expected = (float)Math.Pow(x, y);
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Calculate(x, y, c);
            Assert.AreEqual(expected, actual, "PEREDELAI!!!");
        }

        [TestMethod]
        public void Exponiruet()
        {
            float x = 5F, y=0;
            string c = "e^";
            float expected = (float)Math.Exp(x);
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Calculate(x, y, c);
            Assert.AreEqual(expected, actual, "PEREDELAI!!!");
        }
    }
}
