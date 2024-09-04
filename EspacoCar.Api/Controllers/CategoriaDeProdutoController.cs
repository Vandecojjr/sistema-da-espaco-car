using EspacoCar.Api.DTOs;
using EspacoCar.Api.Models;
using EspacoCar.Api.Results;
using EspacoCar.Api.Services.contratos;
using Microsoft.AspNetCore.Mvc;

namespace EspacoCar.Api.Controllers
{
    [ApiController]
    [Route("api/v1/categoriaDeProdutos")]
    public class CategoriaDeProdutoController : ControllerBase
    {
        public ICategoriaDeProdutoService _service;

        public CategoriaDeProdutoController(ICategoriaDeProdutoService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("")]
        public ActionResult<ResultadoGenerico> Cadastrar([FromBody] CategoriaDeProdutoDTO novaCategoria)
        {
            return _service.Cadastrar(novaCategoria);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<CategoriaDeProduto> BuscarPorId(Guid id)
        {
            return _service.BuscarPorId(id);
        }

        [HttpGet]
        [Route("")]
        public ActionResult<List<CategoriaDeProduto>> BuscarTodos()
        {
            return _service.BuscarTodos().ToList();
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult<ResultadoGenerico> Atualizar(Guid id, [FromBody] UpdateCategoriaDeProdutoDTO categoria)
        {
            if (id != categoria.Id)
                return BadRequest();

            return _service.Atualizar(categoria);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<ResultadoGenerico> Deletar(Guid id)
        {
            return _service.Remover(id);
        }

    }
}