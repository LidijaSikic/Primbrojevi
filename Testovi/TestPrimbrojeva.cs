using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.Pood
{
    [TestClass]
    public class TestPrimbrojeva
    {
        [TestMethod]
        public void GenerirajPrimbrojeveVraćaPrazanNizZaArgument0()
        {
            Assert.AreEqual(0, Primbrojevi.GenerirajPrimBrojeve(0).Length);
        }
        [TestMethod]
        public void GenerirajPrimbrojeveVraćaPrazanNizZaArgument1()
        {
            Assert.AreEqual(0, Primbrojevi.GenerirajPrimBrojeve(1).Length);
        }

        [TestMethod]
        public void GenerirajPrimbrojeveVraćaNizkojiSadržiSamo2ZaArgument2()
        {
            Assert.AreEqual(1, Primbrojevi.GenerirajPrimBrojeve(2).Length);
            Assert.AreEqual(2, Primbrojevi.GenerirajPrimBrojeve(2)[0]);

        }

        [TestMethod]
        public void GenerirajPrimbrojeveVraćaNizkojiSadrži25ProstihBrojevaZaArgument100()
        {
            Assert.AreEqual(25, Primbrojevi.GenerirajPrimBrojeve(100).Length);
            Assert.AreEqual(2, Primbrojevi.GenerirajPrimBrojeve(100)[0]);
            Assert.AreEqual(97, Primbrojevi.GenerirajPrimBrojeve(100)[24]);
        }

    }
}
