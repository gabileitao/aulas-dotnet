using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Aplicacao;

namespace Aplicacao.UnitTest {

    [TestClass]
    public class CalculadoraTeste {

        [TestMethod]
        public void AddTestHappyFlow() {

            float result = Calculadora.Add(2,2);
            Assert.AreEqual(4, result);

        }

        [TestMethod]
        public void AddTestHappyFlow2() {

            float result = Calculadora.Add(101, 250);
            Assert.AreEqual(351, result);

        }

        [TestMethod]
        public void SubtractTestHappyFlow() {

            float result = Calculadora.Subtract(2, 2);
            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void MultiplyTestHappyFlow() {

            float result = Calculadora.Multiply(2, 2);
            Assert.AreEqual(4, result);

        }

        [TestMethod]
        public void DivideTestHappyFlow() {

            float result = Calculadora.Divide(2, 2);
            Assert.AreEqual(1, result);

        }

    }

}