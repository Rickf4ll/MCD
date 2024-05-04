using MCD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MCD;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MCD()
        {
            double nro1 = 24;
            double nro2 = 36;
            double esperado = 12;
            double prueba = Class1.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
    }
}
