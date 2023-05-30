using Acervo.DB;
using Acervo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Acervo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private readonly DataContext _context;

        public ReservasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetReserva(Guid id)
        {
            var reserva = _context.Reservas.Find(id);

            if (reserva == null)
            {
                return NotFound();
            }

            return Ok(reserva);
        }

        [HttpPost]
        public IActionResult CriarReserva([FromBody] Reserva reserva)
        {
            var livro = _context.Livros.FirstOrDefault(l => l.LivroId == reserva.LivroId);

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
            reserva.DataReserva = DateTimeOffset.Now;

            _context.Reservas.Add(reserva);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetReserva), new { id = reserva.ReservaId }, reserva);
        }

        [HttpDelete("{id}")]
        public IActionResult CancelarReserva(Guid id)
        {
            var reserva = _context.Reservas.FirstOrDefault(r => r.ReservaId == id);

            if (reserva == null)
            {
                return NotFound();
            }

            var livro = _context.Livros.FirstOrDefault(l => l.LivroId == reserva.LivroId);

            if (livro == null)
            {
                return NotFound("Livro não encontrado.");
            }

            livro.Reservado = false;

            _context.Reservas.Remove(reserva);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
