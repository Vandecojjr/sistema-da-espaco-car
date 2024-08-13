using EspacoCar.Api.Models;

namespace EspacoCar.Tests;

[TestClass]
public class ProdutoTeste
{
    [TestMethod]
    public void ProdutoValido()
    {
        var produto = new Produto("Amortecedor", 10, 100, 50, Guid.NewGuid());
        Assert.IsTrue(produto.IsValid);
    }


    [TestMethod]
    public void ProdutoInValido()
    {
        var produto = new Produto("", -1, -100, -50, Guid.Empty);
        Assert.IsFalse(produto.IsValid);
    }
}