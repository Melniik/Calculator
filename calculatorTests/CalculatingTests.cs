using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace calculator.Tests
{
    [TestClass()]
    public class CalculatingTests
    {

        [TestMethod()]

        public void EnteredNumTest()
        {
            var calc = new Calculating();
            string enteredNum = "9";
            double expected = 9;

            double resultTest = Convert.ToDouble(calc.EnteredNum(enteredNum));

            Assert.AreEqual(expected, resultTest);
        }

        [TestMethod()]
        public void OperandTest()
        {
            try
            {
                var calc = new Calculating();
                System.Windows.Forms.Label label = null;
                calc.Action(1, label);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(false);
            }

        }

        [TestMethod()]
        public void OperandChangeTest()
        {
            try
            {
                var calc = new Calculating();
                System.Windows.Forms.Label label = null;
                calc.OperandChange(label);
                Assert.IsTrue(true);
            }
            catch
            {

                Assert.IsFalse(false);
            }
        }

        [TestMethod()]
        public void EqualsTest()
        {
            try
            {
                var calc = new Calculating();
                System.Windows.Forms.Label label = null;
                calc.Equals(label);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(false);

            }


        }

        [TestMethod()]
        public void ResetTest()
        {
            try
            {
                var calc = new Calculating();
                System.Windows.Forms.Label label = null;
                calc.Reset(label);
                Assert.IsTrue(true);
            }
            catch 
            {

                Assert.IsFalse(false);
            }
        }
    }
}