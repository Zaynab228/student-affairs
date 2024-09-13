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
    public class ControlController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly IWebHostEnvironment _environment;

        public ControlController(ApplicationDBContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        // GET: Control
        public async Task<IActionResult> Index()
        {
              return _context.Controls != null ? 
                          View(await _context.Controls.ToListAsync()) :
                          Problem("Entity set 'ApplicationDBContext.Controls'  is null.");
        }

        // GET: Control/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Controls == null)
            {
                return NotFound();
            }

            var control = await _context.Controls
                .FirstOrDefaultAsync(m => m.ControlID == id);
            if (control == null)
            {
                return NotFound();
            }

            return View(control);
        }

        // GET: Control/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Control control, IFormFile img_file)
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
                control.ImageControl = img_file.FileName;
            }
            else
            {
                control.ImageControl = "default.jpeg"; // to save the default image path in database.
            }
            try
            {
                _context.Add(control);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex) { ViewBag.exc = ex.Message; }

            return View(control);
        }

        // GET: Control/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Controls == null)
            {
                return NotFound();
            }

            var control = await _context.Controls.FindAsync(id);
            if (control == null)
            {
                return NotFound();
            }
            return View(control);
        }

        // POST: Control/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ControlID,ControlName,Email,password,phone,Address,ImageControl")] Control control)
        {
            if (id != control.ControlID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(control);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ControlExists(control.ControlID))
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

        // GET: Control/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Controls == null)
            {
                return NotFound();
            }

            var control = await _context.Controls
                .FirstOrDefaultAsync(m => m.ControlID == id);
            if (control == null)
            {
                return NotFound();
            }

            return View(control);
        }

        // POST: Control/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Controls == null)
            {
                return Problem("Entity set 'ApplicationDBContext.Controls'  is null.");
            }
            var control = await _context.Controls.FindAsync(id);
            if (control != null)
            {
                _context.Controls.Remove(control);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ControlExists(int id)
        {
          return (_context.Controls?.Any(e => e.ControlID == id)).GetValueOrDefault();
        }
    }
}
