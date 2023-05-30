using Acervo.DB;
using Acervo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

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

        [HttpPut("{id}")]
        public IActionResult AtualizarLivro(Guid id, [FromBody] Livro livroAtualizado)
        {
            var livro = _context.Livros.FirstOrDefault(l => l.LivroId == id);

            if (livro == null)
            {
                return NotFound();
            }

            livro.Titulo = livroAtualizado.Titulo;
            livro.Tipo = livroAtualizado.Tipo;
            livro.Autor = livroAtualizado.Autor;
            livro.Localizacao = livroAtualizado.Localizacao;
            livro.AnoPublicacao = livroAtualizado.AnoPublicacao;
            livro.Reservado = livroAtualizado.Reservado.GetValueOrDefault();

            _context.SaveChanges();

            return Ok(livro);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarLivro(Guid id)
        {
            var livro = _context.Livros.FirstOrDefault(l => l.LivroId == id);

            if (livro == null)
            {
                return NotFound();
            }

            _context.Livros.Remove(livro);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpPost("{id}/reservas")]
        public IActionResult ReservarLivro(Guid id, [FromBody] Reserva reserva)
        {
            var livro = _context.Livros.FirstOrDefault(l => l.LivroId == id);

            if (livro == null)
            {
                return NotFound("Livro não encontrado.");
            }

            if (livro.Reservado ?? false)
            {
                return BadRequest("O livro já está reservado.");
            }

            livro.Reservado = true;

            reserva.ReservaId = Guid.NewGuid();
            reserva.LivroId = livro.LivroId;
            reserva.DataReserva = DateTime.Now;

            _context.Reservas.Add(reserva);
            _context.SaveChanges();

            return CreatedAtAction("GetReserva", new { id = reserva.ReservaId }, reserva);
        }
    }
}
