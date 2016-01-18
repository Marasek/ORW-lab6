using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator1 calc = new Calculator1(); 
        }

        [TestMethod]
        public void TestInput()
        {
            Calculator1 calc = new Calculator1();
            try 
            {
                int result = calc.Calculate("abcd");
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {

            }
        }

        [TestMethod]
        public void JedenplusJeden()
        { 
            Calculator1 calc = new Calculator1();
            int result = calc.Calculate("1+1");
            Assert.AreEqual(2, result);
        }

        void DoSumTest(string input, int expected)
        {
            Calculator1 calc = new Calculator1();
            int result = calc.Calculate(input);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DwaplusDwa()
        {
            DoSumTest("2+2", 4);
        }
        [TestMethod]
        public void CzteryplusJedenascie()
        {
            DoSumTest("4+11", 15);
        }
        [TestMethod]
        public void DwaminusJeden()
        {
            DoSumTest("2-1", 1);
        }
        [TestMethod]
        public void PiecminusDwa()
        {
            DoSumTest("5-2", 3);
        }
        [TestMethod]
        public void PiecrazyDwa()
        {
            DoSumTest("5*2", 10);
        }
        [TestMethod]
        public void DziesiecpodzielicDwa()
        {
            DoSumTest("10/2", 5);
        }
    }
}
