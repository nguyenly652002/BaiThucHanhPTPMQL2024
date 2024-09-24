using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Data;
using DemoMVC.Models;
namespace DemoMVC.Controllers
{
    public class LophocController : Controller
    {
         private readonly ApplicationDbContext _context;

        public LophocController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  Index()
        {
            return View(await _context.Lophoc.ToListAsync());
        }
         public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FullName,Address")]Lophoc Lh)
        { 
            if (ModelState.IsValid)
            {
                _context.Add(Lh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Lh);
        }
         public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Lh = await _context.Lophoc.FindAsync(id);
            if (Lh == null)
            {
                return NotFound();
            }
            return View(Lh);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,  [Bind("FullName,Address")] Lophoc Lh)
        {
            if (id != Lh.FullName)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Lh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LophocExists(Lh.FullName))
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
            return View(Lh);
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Lh = await _context.Lophoc
                .FirstOrDefaultAsync(m => m.FullName == id);
            if (Lh == null)
            {
                return NotFound();
            }

            return View(Lh);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var Lh = await _context.Lophoc.FindAsync(id);
            if (Lh != null)
            {
                _context.Lophoc.Remove(Lh);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LophocExists(string id)
        {
            return _context.Lophoc.Any(e => e.FullName == id);
        }
    }
}
