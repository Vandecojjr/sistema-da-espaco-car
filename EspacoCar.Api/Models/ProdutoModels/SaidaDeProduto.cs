using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EspacoCar.Api.Models.ProdutoModels
{
    public class SaidaDeProduto : MovimentacaoDeProduto
    {
        public SaidaDeProduto(int quantidade, Guid produtoId) : base(quantidade, produtoId)
        {
        }
    }
}