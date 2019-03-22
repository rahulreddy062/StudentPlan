using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentPlan.Data;
using StudentPlan.Models;

namespace StudentPlan.Controllers
{
    public class DegreeRequirementsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DegreeRequirementsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DegreeRequirements
        public async Task<IActionResult> Index(String sortOrder, string searchString)
        {
            ViewData["DegreeIdParm"] = String.IsNullOrEmpty(sortOrder) ? "DegreeId_desc" : "";
            ViewData["RequirementIdParm"] = sortOrder == "RequirementId" ? "ReauirementId_desc" : "RequirementId";
            ViewData["CurrentFilter"] = searchString;
            var degreereq = from s in _context.DegreeRequirements
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                degreereq = degreereq.Where(s => s.DegreeId.ToString().Contains(searchString)
                                       || s.CreditId.ToString().Contains(searchString));
            }

            switch (sortOrder)
            {
                case "DegreeId_desc":
                    degreereq = degreereq.OrderByDescending(s => s.DegreeId);
                    break;

                case "RequirementId":
                    degreereq = degreereq.OrderBy(s => s.CreditId);
                    break;
                case "ReauirementId_desc":
                    degreereq = degreereq.OrderByDescending(s => s.CreditId);
                    break;
                default:
                    degreereq = degreereq.OrderBy(s => s.Id);
                    break;
            }

            return View(await degreereq.AsNoTracking().ToListAsync());
        }

        // GET: DegreeRequirements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeRequirement = await _context.DegreeRequirements
                .Include(d => d.Credit)
                .Include(d => d.Degree)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (degreeRequirement == null)
            {
                return NotFound();
            }

            return View(degreeRequirement);
        }

        // GET: DegreeRequirements/Create
        public IActionResult Create()
        {
            ViewData["CreditId"] = new SelectList(_context.Credits, "CreditId", "CreditAbv");
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeAbbr");
            return View();
        }

        // POST: DegreeRequirements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DegreeId,CreditId")] DegreeRequirement degreeRequirement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(degreeRequirement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CreditId"] = new SelectList(_context.Credits, "CreditId", "CreditAbv", degreeRequirement.CreditId);
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeAbbr", degreeRequirement.DegreeId);
            return View(degreeRequirement);
        }

        // GET: DegreeRequirements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeRequirement = await _context.DegreeRequirements.FindAsync(id);
            if (degreeRequirement == null)
            {
                return NotFound();
            }
            ViewData["CreditId"] = new SelectList(_context.Credits, "CreditId", "CreditAbv", degreeRequirement.CreditId);
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeAbbr", degreeRequirement.DegreeId);
            return View(degreeRequirement);
        }

        // POST: DegreeRequirements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DegreeId,CreditId")] DegreeRequirement degreeRequirement)
        {
            if (id != degreeRequirement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(degreeRequirement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DegreeRequirementExists(degreeRequirement.Id))
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
            ViewData["CreditId"] = new SelectList(_context.Credits, "CreditId", "CreditAbv", degreeRequirement.CreditId);
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeAbbr", degreeRequirement.DegreeId);
            return View(degreeRequirement);
        }

        // GET: DegreeRequirements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var degreeRequirement = await _context.DegreeRequirements
                .Include(d => d.Credit)
                .Include(d => d.Degree)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (degreeRequirement == null)
            {
                return NotFound();
            }

            return View(degreeRequirement);
        }

        // POST: DegreeRequirements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var degreeRequirement = await _context.DegreeRequirements.FindAsync(id);
            _context.DegreeRequirements.Remove(degreeRequirement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DegreeRequirementExists(int id)
        {
            return _context.DegreeRequirements.Any(e => e.Id == id);
        }
    }
}
