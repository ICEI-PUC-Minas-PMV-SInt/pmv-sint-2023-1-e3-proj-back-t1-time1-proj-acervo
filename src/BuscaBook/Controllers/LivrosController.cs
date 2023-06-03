using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BuscaBook.Models;

namespace BuscaBook.Controllers
{
    public class LivrosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LivrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: Livros/Reservar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reservar(Guid id)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro == null)
            {
                return NotFound();
            }

            livro.Reservado = true;
            livro.TempoReserva = DateTime.Now.AddDays(1);

            _context.Update(livro);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // POST: Livros/Alugar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alugar(Guid id)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro == null)
            {
                return NotFound();
            }

            livro.Alugado = true;
            livro.TempoAluguel = DateTime.Now.AddDays(7);

            _context.Update(livro);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Livros
        public async Task<IActionResult> Index()
        {
            if (_context.Livros == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Livros' is null.");
            }

            var livros = await _context.Livros.ToListAsync();
            return View(livros);
        }

        // GET: Livros/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Livros == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros.FirstOrDefaultAsync(m => m.LivroId == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // GET: Livros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Livros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LivroId,Titulo,Tipo,Autor,Localizacao,AnoPublicacao,Reservado,TempoReserva,Alugado,TempoAluguel,NumeroPaginas")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                livro.LivroId = Guid.NewGuid();
                livro.Reservado = false;
                livro.Alugado = false;
                _context.Add(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(livro); ;
        }

        // GET: Livros/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Livros == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros.FindAsync(id);
            if (livro == null)
            {
                return NotFound();
            }
            return View(livro);
        }

        // POST: Livros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("LivroId,Titulo,Tipo,Autor,Localizacao,AnoPublicacao,Reservado,TempoReserva,Alugado,TempoAluguel,NumeroPaginas")] Livro livro)
        {
            if (id != livro.LivroId || _context.Livros == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (livro.Reservado == null)
                        livro.Reservado = false;

                    if (livro.Alugado == null)
                        livro.Alugado = false;

                    _context.Update(livro);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException)
                {
                    if (!LivroExists(livro.LivroId))
                    {
                        return NotFound();
                    } else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(livro);
        }
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Livros == null)
            {
                return NotFound();
            }

            var livro = await _context.Livros.FirstOrDefaultAsync(m => m.LivroId == id);
            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var livro = await _context.Livros.FindAsync(id);
            if (livro == null)
            {
                return NotFound();
            }

            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LivroExists(Guid id)
        {
            return _context.Livros.Any(e => e.LivroId == id);
        }
    }
}