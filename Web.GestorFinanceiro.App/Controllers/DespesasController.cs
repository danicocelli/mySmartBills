using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web.GestorFinanceiro.App.Data;
using Web.GestorFinanceiro.App.Models;

namespace Web.GestorFinanceiro.App.Controllers
{
    public class DespesasController : Controller
    {
        private readonly WebGestorFinanceiroAppContext _context;

        public DespesasController(WebGestorFinanceiroAppContext context)
        {
            _context = context;
        }

        // GET: Despesas
        public async Task<IActionResult> Index()
        {
              return View(await _context.Despesa.ToListAsync());
        }

        // GET: Despesas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Despesa == null)
            {
                return NotFound();
            }

            var despesa = await _context.Despesa
                .FirstOrDefaultAsync(m => m.DespesaId == id);
            if (despesa == null)
            {
                return NotFound();
            }

            return View(despesa);
        }

        // GET: Despesas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Despesas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DespesaId,NomeDespesa,Recorrente,TipoDespesa,DespesaData,ValorDespesa,DescricaoDespesa,DataCadastroAlteracao,Operacao,Situacao")] Despesa despesa)
        {
            if (ModelState.IsValid)
            {
                despesa.DataCadastroAlteracao = DateTime.Now;
                _context.Add(despesa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(despesa);
        }

        // GET: Despesas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Despesa == null)
            {
                return NotFound();
            }

            var despesa = await _context.Despesa.FindAsync(id);
            if (despesa == null)
            {
                return NotFound();
            }
            return View(despesa);
        }

        // POST: Despesas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DespesaId,NomeDespesa,Recorrente,TipoDespesa,DespesaData,ValorDespesa,DescricaoDespesa,DataCadastroAlteracao,Operacao,Situacao")] Despesa despesa)
        {
            if (id != despesa.DespesaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(despesa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DespesaExists(despesa.DespesaId))
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
            return View(despesa);
        }

        // GET: Despesas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Despesa == null)
            {
                return NotFound();
            }

            var despesa = await _context.Despesa
                .FirstOrDefaultAsync(m => m.DespesaId == id);
            if (despesa == null)
            {
                return NotFound();
            }

            return View(despesa);
        }

        // POST: Despesas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Despesa == null)
            {
                return Problem("Entity set 'WebGestorFinanceiroAppContext.Despesa'  is null.");
            }
            var despesa = await _context.Despesa.FindAsync(id);
            if (despesa != null)
            {
                _context.Despesa.Remove(despesa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DespesaExists(int id)
        {
          return _context.Despesa.Any(e => e.DespesaId == id);
        }
    }
}
