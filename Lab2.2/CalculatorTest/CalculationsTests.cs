using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2.Tests
{
    [TestClass]
    public class CalculationsTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideTest()
        {
            Calculations myCalc = new Calculations();
            var nominator = 6;
            var denominator = 0;
            myCalc.Divide(nominator, denominator);
        }

        [TestMethod]
        public void AddTest()
        {
        }
    }
}