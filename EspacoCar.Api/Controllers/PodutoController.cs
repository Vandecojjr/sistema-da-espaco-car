using EspacoCar.Api.DTOs;
using EspacoCar.Api.Models;
using EspacoCar.Api.Results;
using EspacoCar.Api.Services.contratos;
using Microsoft.AspNetCore.Mvc;

namespace EspacoCar.Api.Controllers
{
    [ApiController]
    [Route("api/v1/produtos")]
    public class PodutoController : ControllerBase
    {
        public IProdutoService _service;

        public PodutoController(IProdutoService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ResultadoGenerico> Cadastrar([FromBody] ProdutoDTO novoProduto)
        {
            return _service.Cadastrar(novoProduto);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Produto> BuscarPorId(Guid id)
        {
            return _service.BuscarPorId(id);
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<Produto>> BuscarTodos()
        {
            return _service.BuscarTodos().ToList();
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult<ResultadoGenerico> Atualizar(Guid id, [FromBody] AtualizarProdutoDTO produto)
        {
            if (id != produto.Id)
                return BadRequest();

            return _service.Atualizar(produto);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<ResultadoGenerico> Deletar(Guid id)
        {
            return _service.Remover(id);
        }
    }
}