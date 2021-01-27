using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;
using CompraComerciante;
using Telerik.JustMock.Helpers;

namespace PruebaAndersonChanchay
{
    [TestClass]
    public class PruebaComerciante
    {
        [TestMethod]
        public void DadoQueExisteLaptopsDisponiblesCuandoVaAComprarLaptopsEntoncesRecibeLaptops()
        {
            string modeloLaptop = "Dell";
            int numeroLaptopsAComprar = 3;
            var almacen = Mock.Create<Almacen>();
            almacen.Arrange(a => a.LaptopsDisponibles(modeloLaptop)).Returns(20);
            almacen.Arrange(a => a.GenerarRecibo(modeloLaptop, numeroLaptopsAComprar))
                .Returns(new List<string> { "DellGM2020", "Dell2018", "Dell2019" });

            Comerciante comerciante = new Comerciante();
            comerciante.ComprarLaptops(almacen, numeroLaptopsAComprar, modeloLaptop);

            Assert.IsTrue(comerciante.RecibeLaptops);
            almacen.Assert(a => a.LaptopsDisponibles(modeloLaptop));
            almacen.Assert(a => a.GenerarRecibo(modeloLaptop, numeroLaptopsAComprar));
        }

        [TestMethod]
        public void DadoQueNoExisteLaptopsDisponiblesCuandoVaAComprarLaptopsEntoncesReservaLaptops()
        {
            string modeloLaptop = "Dell";
            var NoExisteLaptops = 0;
            int numeroLaptopsAComprar = 5;
            var almacen = Mock.Create<Almacen>();
            almacen.Arrange(a => a.LaptopsDisponibles(modeloLaptop)).Returns(NoExisteLaptops);
            almacen.Arrange(a => a.GenerarRecibo(modeloLaptop, numeroLaptopsAComprar))
                .Returns(new List<string> { "Dell2020", "Dell2018", "Dell2019" });

            Comerciante comerciante = new Comerciante();
            comerciante.ComprarLaptops(almacen, numeroLaptopsAComprar, modeloLaptop);

            Assert.IsTrue(comerciante.ReservaLaptos);
            almacen.Assert(a => a.LaptopsDisponibles(modeloLaptop));
            almacen.Assert(a => a.GenerarRecibo(modeloLaptop, numeroLaptopsAComprar));
        }

        [TestMethod]
        public void DadoQueHayLimiteDeCompraDeLaptopsCuandoVoyARealizaLaCompraDeUnaLaptopEntoncesNoCompraLaptop()
        {
            int numeroLaptopsAComprar = 1;
            var almacen = Mock.Create<Almacen>();
            almacen.Arrange(a => a.LimiteDeCompra).Returns(5);

            Comerciante comerciante = new Comerciante();
            comerciante.RealizaCompra(almacen, numeroLaptopsAComprar);

            Assert.IsFalse(comerciante.NoCompraLaptop);
            almacen.Assert(a => a.LimiteDeCompra);
        }
    }
}
