using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EspacoCar.Api.DTOs
{
    public class UpdateCategoriaDeProdutoDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}