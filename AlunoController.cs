using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private static List<Aluno> alunos = new List<Aluno>();

        [HttpPost("adicionar")]
        public IActionResult Adicionar([FromBody] Aluno aluno)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (alunos.Any(a => a.Ra == aluno.Ra))
                return BadRequest("RA já cadastrado!");

            alunos.Add(aluno);
            return Ok("Aluno adicionado com sucesso.");
        }

        [HttpGet("todos")]
        public IActionResult Todos()
        {
            return Ok(alunos);
        }
    }
}
