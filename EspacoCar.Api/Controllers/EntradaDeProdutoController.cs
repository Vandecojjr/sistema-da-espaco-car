using EspacoCar.Api.DTOs;
using EspacoCar.Api.Models.ProdutoModels;
using EspacoCar.Api.Results;
using EspacoCar.Api.Services.contratos;
using Microsoft.AspNetCore.Mvc;

namespace EspacoCar.Api.Controllers
{
    [ApiController]
    [Route("api/v1/entradadeprodutos")]
    public class EntradaDeProdutoController : ControllerBase
    {
        private IEntradaDeProdutoServcie _service;
        public EntradaDeProdutoController(IEntradaDeProdutoServcie entradaDeProdutoService)
        {
            _service = entradaDeProdutoService;
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ResultadoGenerico> Cadastrar([FromBody] MovimentacaoDeProdutoDTO entrada)
        {
            return _service.Cadastrar(entrada);
        }

        [HttpGet]
        public ActionResult<List<EntradaDeProduto>> BuscarTodos()
        {
            return _service.BuscarTodos().ToList();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<EntradaDeProduto> BuscarPorId(Guid id)
        {
            return _service.BuscarPorId(id);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<ResultadoGenerico> Deletar(Guid id)
        {
            return _service.Deletar(id);
        }
    }
}