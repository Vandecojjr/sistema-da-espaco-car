using EspacoCar.Api.DTOs;
using EspacoCar.Api.Models.ProdutoModels;
using EspacoCar.Api.Results;
using EspacoCar.Api.Services.contratos;
using Microsoft.AspNetCore.Mvc;

namespace EspacoCar.Api.Controllers
{
    [ApiController]
    [Route("api/v1/saidadeprodutos")]
    public class SaidaDeProdutoController : ControllerBase
    {
        private ISaidaDeProdutoServcie _service;
        public SaidaDeProdutoController(ISaidaDeProdutoServcie saidaDeProdutoService)
        {
            _service = saidaDeProdutoService;
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ResultadoGenerico> Cadastrar([FromBody] MovimentacaoDeProdutoDTO entrada)
        {
            return _service.Cadastrar(entrada);
        }

        [HttpGet]
        public ActionResult<List<SaidaDeProduto>> BuscarTodos()
        {
            return _service.BuscarTodos().ToList();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<SaidaDeProduto> BuscarPorId(Guid id)
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