using Acervo.DB;
using Acervo.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Acervo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly DataContext _context;

        public UsuariosController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CadastrarUsuario([FromBody] Usuario usuario)
        {
            usuario.UsuarioId = Guid.NewGuid(); // Gera um novo GUID para o usuário
            usuario.FezReserva = false; // Define como não fez reserva por padrão

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetUsuario), new { id = usuario.UsuarioId }, usuario);
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuario(Guid id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }
        [HttpPut("{id}")]
        public IActionResult AtualizarUsuario(Guid id, [FromBody] Usuario usuarioAtualizado)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
            {
                return NotFound();
            }

            usuario.Nome = usuarioAtualizado.Nome;
            usuario.Cpf = usuarioAtualizado.Cpf;
            usuario.Senha = usuarioAtualizado.Senha;
            usuario.Email = usuarioAtualizado.Email;
            usuario.Telefone = usuarioAtualizado.Telefone;
            usuario.FezReserva = usuarioAtualizado.FezReserva;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarUsuario(Guid id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();

            return NoContent();
        }
    }
    }
