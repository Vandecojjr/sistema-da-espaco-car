using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EspacoCar.Api.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EspacoCar.Tests.Models.Testes
{
    [TestClass]
    public class MovimentacaodeProdutoTestes
    {
        [TestMethod]
        public void MovimentacaodeProdutoValida()
        {
            var movimentacaoDeProduto = new MovimentacaoDeProduto(10, Guid.NewGuid());
            Assert.IsTrue(movimentacaoDeProduto.IsValid);
        }

        [TestMethod]
        public void MovimentacaodeProdutoInValida()
        {
            var movimentacaoDeProduto = new MovimentacaoDeProduto(0, Guid.NewGuid());
            Assert.IsFalse(movimentacaoDeProduto.IsValid);
        }
    }
}