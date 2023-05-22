using Acervo.DB;
using Acervo.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Acervo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly DataContext _context;

        public LivrosController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CadastrarLivro([FromBody] Livro livro)
        {
            livro.LivroId = Guid.NewGuid(); // Gera um novo GUID para o livro
            livro.Reservado = false; // Define como não reservado por padrão

            _context.Livros.Add(livro);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetLivro), new { id = livro.LivroId }, livro);
        }

        [HttpGet("{id}")]
        public IActionResult GetLivro(Guid id)
        {
            var livro = _context.Livros.Find(id);

            if (livro == null)
            {
                return NotFound();
            }

            return Ok(livro);
        }
    }
}