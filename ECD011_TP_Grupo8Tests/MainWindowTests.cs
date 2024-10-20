using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECD011_TP_Grupo8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECD011_TP_Grupo8.src;

namespace ECD011_TP_Grupo8.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void AddTest()
        {
            int a = 1;
            int b = 2;
            int expectedRet = 3;

            Program program = new Program();

            Assert.AreEqual(expectedRet, program.Add(a, b));
        }
    }
}