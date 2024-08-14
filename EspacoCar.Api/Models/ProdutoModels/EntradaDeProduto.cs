using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EspacoCar.Api.Models.ProdutoModels
{
    public class EntradaDeProduto : MovimentacaoDeProduto
    {
        public EntradaDeProduto(int quantidade, Guid produtoId) : base(quantidade, produtoId)
        {
        }
    }
}