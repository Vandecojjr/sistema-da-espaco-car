using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EspacoCar.Api.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EspacoCar.Tests.Models.Testes
{
    [TestClass]
    public class CategoriaTeste
    {
        [TestMethod]
        public void CategoriaValida()
        {
            var categoria = new CategoriaDeProduto("Teste");
            Assert.IsTrue(categoria.IsValid);
        }

        [TestMethod]
        public void CategorIniaValida()
        {
            var categoria = new CategoriaDeProduto("");
            Assert.IsFalse(categoria.IsValid);
        }
    }
}