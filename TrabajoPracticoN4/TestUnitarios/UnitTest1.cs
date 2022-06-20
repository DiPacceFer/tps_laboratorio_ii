using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CobrarCuota_CuandoElSocioEsNull_DeberiaRetornarCuota0()
        {
            //Arrange
            Socio socio = null;
            double expected = 0;
            double actual;
            //Act
            actual = Cobro.CobrarCuota(socio);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CobrarArancel_DeberiaRetornarValorArancel()
        {
            //Arrange
            Futbolista futbolista = new Futbolista("Fernando", "Di Pacce", new DateTime(1984, 8, 4), 31070791, ECategoriasFutbol.Adulto);
            double expected = 300;
            double actual;
            //Act
            actual = Cobro.CobrarArancel(futbolista);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EqualsSocio_CuandoSeComparaSociosConDiferenteNombre_RetornaFalse()
        {
            //Arrange
            Socio socio = new Socio("Fernando", "Di Pacce", new DateTime(1984, 8, 4), 31070791);
            Socio socio2 = new Socio("Delfina", "Di Pacce", new DateTime(2019, 10, 18), 34180609);
            bool actual;
            //Act
            actual = socio.Equals(socio2);
            //Assert
            Assert.IsFalse(actual);
        }
    }
}
