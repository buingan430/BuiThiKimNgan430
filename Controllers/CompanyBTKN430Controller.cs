using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuiThiKimNgan430.Models;
using BuiThiKimNgan430.Data;
namespace BuiThiKimNgan430.Controllers
{
    public class CompanyBTKN430Controller : Controller
    {
        private readonly  ApplicationDbcontext _context;

        public CompanyBTKN430Controller(ApplicationDbcontext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
              return _context.CompanyBTKN430!= null ? 
                          View(await _context.CompanyBTKN430.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbcontext.CompanyBTKN430'  is null.");
        }

      
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CompanyBTKN430 == null)
            {
                return NotFound();
            }

            var companyBTKN430= await _context.CompanyBTKN430
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyBTKN430 == null)
            {
                return NotFound();
            }

            return View(companyBTKN430);
        }

        
        public IActionResult Create()
        {
            return View();
        }

     
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyBTKN430 companyBTKN430)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyBTKN430);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyBTKN430);
        }

        
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CompanyBTKN430 == null)
            {
                return NotFound();
            }

            var companyBTKN430 = await _context.CompanyBTKN430.FindAsync(id);
            if (companyBTKN430 == null)
            {
                return NotFound();
            }
            return View(companyBTKN430);
        }

       
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanytBTKN430 companyBTKN430)
        {
            if (id != companyBTKN430.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyBTKN430);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyBTKN430Exists(companyBTKN430.CompanyId))
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
            return View(companyBTKN430);
        }

       
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CompanyBTKN430 == null)
            {
                return NotFound();
            }

            var companyBTKN430= await _context.CompanyBTKN430
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyBTKN430 == null)
            {
                return NotFound();
            }

            return View(companyBTKN430);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CompanyBTKN430 == null)
            {
                return Problem("Entity set 'ApplicationDbcontext.CompanyBTKN430'  is null.");
            }
            var companyBTKN430 = await _context.CompanyBTKN430.FindAsync(id);
            if (CompanyBTKN430!= null)
            {
                _context.CompanyBTKN430.Remove(companyBTKN430);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyBTKN430Exists(string id)
        {
          return (_context.CompanyBTKN430?.Any(e => e.CompanyId == id)).GetValueOrDefault();
        }
    }
}