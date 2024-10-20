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
        public void AddTest()
        {
            int a = 1;
            int b = 2;
            int expectedRet = 3;

            Add addOperation = new Add();
            addOperation.Numbers.Add(a);
            addOperation.Numbers.Add(b);

            Assert.AreEqual(expectedRet, addOperation.Run());
        }
    }
}