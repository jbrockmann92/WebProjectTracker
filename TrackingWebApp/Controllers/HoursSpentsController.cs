using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;
using TrackingWebApp.Data;

namespace TrackingWebApp.Controllers
{
    public class HoursSpentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HoursSpentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HoursSpents
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.HoursSpent.Include(h => h.Project);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: HoursSpents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoursSpent = await _context.HoursSpent
                .Include(h => h.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hoursSpent == null)
            {
                return NotFound();
            }

            return View(hoursSpent);
        }

        // GET: HoursSpents/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id");
            return View();
        }

        // POST: HoursSpents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Hours,ProjectId")] HoursSpent hoursSpent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoursSpent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", hoursSpent.ProjectId);
            return View(hoursSpent);
        }

        // GET: HoursSpents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoursSpent = await _context.HoursSpent.FindAsync(id);
            if (hoursSpent == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", hoursSpent.ProjectId);
            return View(hoursSpent);
        }

        // POST: HoursSpents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Hours,ProjectId")] HoursSpent hoursSpent)
        {
            if (id != hoursSpent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoursSpent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoursSpentExists(hoursSpent.Id))
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
            ViewData["ProjectId"] = new SelectList(_context.Projects, "Id", "Id", hoursSpent.ProjectId);
            return View(hoursSpent);
        }

        // GET: HoursSpents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoursSpent = await _context.HoursSpent
                .Include(h => h.Project)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hoursSpent == null)
            {
                return NotFound();
            }

            return View(hoursSpent);
        }

        // POST: HoursSpents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hoursSpent = await _context.HoursSpent.FindAsync(id);
            _context.HoursSpent.Remove(hoursSpent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoursSpentExists(int id)
        {
            return _context.HoursSpent.Any(e => e.Id == id);
        }
    }
}
