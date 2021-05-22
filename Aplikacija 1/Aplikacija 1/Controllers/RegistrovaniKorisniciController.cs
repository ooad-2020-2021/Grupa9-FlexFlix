using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aplikacija_1.Data;
using Aplikacija_1.Models;

namespace Aplikacija_1.Controllers
{
    public class RegistrovaniKorisniciController : Controller
    {
        private readonly DataContext _context;

        public RegistrovaniKorisniciController(DataContext context)
        {
            _context = context;
        }

        // GET: RegistrovaniKorisnici
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistrovaniKorisnik.ToListAsync());
        }

        // GET: RegistrovaniKorisnici/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrovaniKorisnik = await _context.RegistrovaniKorisnik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registrovaniKorisnik == null)
            {
                return NotFound();
            }

            return View(registrovaniKorisnik);
        }

        // GET: RegistrovaniKorisnici/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistrovaniKorisnici/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Password,Ime,Prezime,Email,ProfilnaFotografija,JeLiAdmin")] RegistrovaniKorisnik registrovaniKorisnik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registrovaniKorisnik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registrovaniKorisnik);
        }

        // GET: RegistrovaniKorisnici/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrovaniKorisnik = await _context.RegistrovaniKorisnik.FindAsync(id);
            if (registrovaniKorisnik == null)
            {
                return NotFound();
            }
            return View(registrovaniKorisnik);
        }

        // POST: RegistrovaniKorisnici/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Password,Ime,Prezime,Email,ProfilnaFotografija,JeLiAdmin")] RegistrovaniKorisnik registrovaniKorisnik)
        {
            if (id != registrovaniKorisnik.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registrovaniKorisnik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistrovaniKorisnikExists(registrovaniKorisnik.Id))
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
            return View(registrovaniKorisnik);
        }

        // GET: RegistrovaniKorisnici/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registrovaniKorisnik = await _context.RegistrovaniKorisnik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registrovaniKorisnik == null)
            {
                return NotFound();
            }

            return View(registrovaniKorisnik);
        }

        // POST: RegistrovaniKorisnici/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registrovaniKorisnik = await _context.RegistrovaniKorisnik.FindAsync(id);
            _context.RegistrovaniKorisnik.Remove(registrovaniKorisnik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistrovaniKorisnikExists(int id)
        {
            return _context.RegistrovaniKorisnik.Any(e => e.Id == id);
        }
    }
}
