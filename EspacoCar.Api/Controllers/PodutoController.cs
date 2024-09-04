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
    }
}