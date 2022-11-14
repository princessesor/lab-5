using BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace TestApp.UnitTests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void Calculation_UserIsYr_ReturnsTrue()
        {
            var calculate = new Calculate();

            var result = calculate.Calculation(new Calculate { IsYear = true });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Calculation_Userbdwinter_ReturnsTrue()
        {
            var calculate = new Calculate();

            var result = calculate.Calculation(new Calculate { bdwinter = true });

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Calculation_NotIsYr_ReturnsFalse()
        {
            var calculate = new Calculate { Calcby = new User() };

            var result = calculate.Calculation(new Calculate());

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Calculation_Notbdwinter_ReturnsFalse()
        {
            var calculate = new Calculate { Calcby = new User() };

            var result = calculate.Calculation(new Calculate());

            Assert.IsFalse(result);
        } 

    }
}
