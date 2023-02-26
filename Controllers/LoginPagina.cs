using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Soft.Models;

namespace Soft.Controllers
{
    public class LoginPaginaController : Controller
    {
        private readonly Contexto _context;

        public LoginPaginaController(Contexto context)
        {
            _context = context;
        }

      
        public async Task<IActionResult> Index()
        {
              return View(await _context.Produtos.ToListAsync());
        }

       
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produtos = await _context.Produtos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produtos == null)
            {
                return NotFound();
            }

            return View(produtos);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descricao,Codigo,Venda,PesoBruto,PesoLiquido")] Produtos produtos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produtos);
        }

        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produtos = await _context.Produtos.FindAsync(id);
            if (produtos == null)
            {
                return NotFound();
            }
            return View(produtos);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descricao,Codigo,Venda,PesoBruto,PesoLiquido")] Produtos produtos)
        {
            if (id != produtos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutosExists(produtos.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(produtos);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produtos = await _context.Produtos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produtos == null)
            {
                return NotFound();
            }

            return View(produtos);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Produtos == null)
            {
                return Problem("Entity set 'Contexto.Produtos'  is null.");
            }
            var produtos = await _context.Produtos.FindAsync(id);
            if (produtos != null)
            {
                _context.Produtos.Remove(produtos);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutosExists(int id)
        {
          return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
