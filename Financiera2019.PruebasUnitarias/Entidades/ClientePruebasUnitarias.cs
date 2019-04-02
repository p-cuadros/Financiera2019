using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Financiera2019.Dominio.Entidades;
using Financiera2019.Dominio.Repositorios;
using Financiera2019.Infraestructura.Datos.EF.Repositorios;

namespace Financiera2019.PruebasUnitarias.Entidades
{
    [TestClass]
    public class ClientePruebasUnitarias
    {
        [TestMethod]
        public void CrearClienteSatisfactoriamente()
        {
            var cliente = Cliente.Crear(1, "Juan Perez");
            Assert.IsNotNull(cliente);
            Assert.AreEqual(cliente.CodigoCliente, 1);
        }
        [TestMethod]
        public void RegistrarClienteEnBDSatisfactoriamente()
        {
            var cliente = Cliente.Crear(1, "Juan Perez");
            IRepositorio rep = new Repositorio();
            rep.Adicionar(cliente);
            rep.GuardarCambios();

            Assert.IsNotNull(cliente);
            Assert.AreEqual(cliente.CodigoCliente, 1);
        }
        [TestMethod]
        public void BuscarClienteEnBDSatisfactoriamente()
        {
            IRepositorio rep = new Repositorio();
            var cliente = rep.ObtenerPorCodigo<Cliente>(1);

            Assert.IsNotNull(cliente);
            Assert.AreEqual(cliente.CodigoCliente, 1);
        }
    }
}
