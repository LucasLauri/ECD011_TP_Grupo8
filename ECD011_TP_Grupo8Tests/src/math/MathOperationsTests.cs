using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECD011_TP_Grupo8.src.math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECD011_TP_Grupo8.src.math.Tests
{
    [TestClass()]
    public class MathOperationsTests
    {
        [TestMethod()]
        [Description("Verifica se a função de soma esta sendo executada corretamente")]
        public void AddTest()
        {
            //FUTURE: usar n números aleatórios para testar a soma

            int a = 1;
            int b = 2;
            int expectedRet = 3;

            Add operation = new Add();
            operation.Numbers.Add(a);
            operation.Numbers.Add(b);

            Assert.AreEqual(expectedRet, operation.Run(), message: "A soma dos números não ocorreu corretamente!");
        }

        [TestMethod()]
        [Description("Verifica se a função de subtração esta sendo executada corretamente")]
        public void SubtractTest()
        {
            //FUTURE: usar n números aleatórios para testar a subtração

            int a = 1;
            int b = 2;
            int expectedRet = -1;

            Subtract operation = new Subtract();
            operation.Numbers.Add(a);
            operation.Numbers.Add(b);

            Assert.AreEqual(expectedRet, operation.Run(), message: "A subtração dos números não ocorreu corretamente!");
        }
    }
}