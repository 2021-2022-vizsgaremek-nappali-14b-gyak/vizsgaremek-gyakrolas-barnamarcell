using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankProjekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProjekt.Kivetel;

namespace BankProjekt.Model.Tests
{
    [TestClass()]
    public class EgyenlegTests
    {
        [TestMethod()]
        public void BefizetesTestBefizetes200()
        {
            // Arrange
            Egyenleg egyenleg = new Egyenleg(0);
            int elvartEgyenleg = 200;

            // Act

            egyenleg.Befizetes(200);
            int aktualisEgyenleg = egyenleg.Osszeg;

            // Assert
            Assert.AreEqual(elvartEgyenleg, aktualisEgyenleg);
        }
        [TestMethod()]
        public void BefizetesTestBefizetes0()
        {
            // Arrange
            Egyenleg egyenleg = new Egyenleg(300);
            int elvartEgyenleg = 300;
            // Act

            egyenleg.Befizetes(0);
            int aktualisEgyenleg = egyenleg.Osszeg;

            // Assert
            Assert.AreEqual(elvartEgyenleg, aktualisEgyenleg);
        }
        [TestMethod()]
        public void BefizetesTestBefizetesMinusz200()
        {
            // Arrange
            Egyenleg egyenleg = new Egyenleg(300);
            // Act

            // Assert
            Assert.ThrowsException<NegativOsszegBefizeteseException>(() => egyenleg.Befizetes(-200));
        }

        [TestMethod()]
        public void KifizetesTestBefizetés200()
        {
            // Arrange
            Egyenleg egyenleg = new Egyenleg(300);
            int elvartEgyenleg = 100;

            // Act

            egyenleg.Kifizetes(200);
            int aktualisEgyenleg = egyenleg.Osszeg;

            // Assert
            Assert.AreEqual(elvartEgyenleg, aktualisEgyenleg);

        }
        [TestMethod()]
        public void KifizetesTestBefizetés0()
        {
            Egyenleg egyenleg = new Egyenleg(300);
            // Act

            // Assert
            Assert.ThrowsException<MagasabbOsszegKifizetesException>(() => egyenleg.Kifizetes(0));

        }
        [TestMethod()]
        public void KifizetesTestBefizetésMinusz200()
        {
            // Arrange
            Egyenleg egyenleg = new Egyenleg(100);
            // Act

            // Assert
            Assert.ThrowsException<MagasabbOsszegKifizetesException>(() => egyenleg.Kifizetes(-200));
        }

    }
}