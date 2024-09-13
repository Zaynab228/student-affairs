using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Students_Affaires.Data;
using Students_Affaires.Models;

namespace Students_Affaires.Controllers
{
    public class AffairController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly IWebHostEnvironment _environment;

        public AffairController(ApplicationDBContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Affair
        public async Task<IActionResult> Index()
        {
              return _context.Affairs != null ? 
                          View(await _context.Affairs.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.Affairs'  is null.");
        }

        // GET: Affair/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Affairs == null)
            {
                return NotFound();
            }

            var affair = await _context.Affairs
                .FirstOrDefaultAsync(m => m.AffairID == id);
            if (affair == null)
            {
                return NotFound();
            }

            return View(affair);
        }

        // GET: Affair/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Affair/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Affair affair, IFormFile img_file)
        {
            string path = Path.Combine(_environment.WebRootPath, "Img"); // wwwroot/Img/
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (img_file != null)
            {
                path = Path.Combine(path, img_file.FileName); // for exmple : /Img/Photoname.png
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await img_file.CopyToAsync(stream);
                    ViewBag.Message = string.Format("<b>{0}</b> uploaded.</br>", img_file.FileName.ToString());
                }
                affair.ImageAffairl = img_file.FileName;
            }
            else
            {
                affair.ImageAffairl = "default.jpeg"; // to save the default image path in database.
            }
            try
            {
                _context.Add(affair);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex) { ViewBag.exc = ex.Message; }

            return View(affair);
        }

        // GET: Affair/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Affairs == null)
            {
                return NotFound();
            }

            var affair = await _context.Affairs.FindAsync(id);
            if (affair == null)
            {
                return NotFound();
            }
            return View(affair);
        }

        // POST: Affair/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AffairID,AffairName,Email,password,phone,Address,ImageAffairl")] Affair affair)
        {
            if (id != affair.AffairID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(affair);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AffairExists(affair.AffairID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                
            }
            return RedirectToAction("Index");
        }

        // GET: Affair/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Affairs == null)
            {
                return NotFound();
            }

            var affair = await _context.Affairs
                .FirstOrDefaultAsync(m => m.AffairID == id);
            if (affair == null)
            {
                return NotFound();
            }

            return View(affair);
        }

        // POST: Affair/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Affairs == null)
            {
                return Problem("Entity set 'ApplicationDBContext.Affairs'  is null.");
            }
            var affair = await _context.Affairs.FindAsync(id);
            if (affair != null)
            {
                _context.Affairs.Remove(affair);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AffairExists(int id)
        {
          return (_context.Affairs?.Any(e => e.AffairID == id)).GetValueOrDefault();
        }
    }
}
