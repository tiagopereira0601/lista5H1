using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> produtos = new List<Produto>();

        [HttpPost("adicionar")]
        public IActionResult Adicionar([FromBody] Produto produto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (produtos.Any(p => p.CodigoProduto == produto.CodigoProduto))
                return BadRequest("Código de produto já cadastrado!");

            produtos.Add(produto);
            return Ok("Produto adicionado com sucesso.");
        }

        [HttpGet("todos")]
        public IActionResult Todos()
        {
            return Ok(produtos);
        }
    }
}
