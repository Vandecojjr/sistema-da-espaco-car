using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EspacoCar.Api.DTOs
{
    public class AtualizarMovimentacaoDeProdutoDTO : MovimentacaoDeProdutoDTO
    {
        public Guid Id { get; set; }
    }
}