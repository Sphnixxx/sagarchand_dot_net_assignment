using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sagarchand_dot_net_assignment.Data;
using sagarchand_dot_net_assignment.Models;

namespace sagarchand_dot_net_assignment.Controllers
{
    public class StudentinfoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentinfoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Studentinfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Studentinfo.ToListAsync());
        }

        // GET: Studentinfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentinfo = await _context.Studentinfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentinfo == null)
            {
                return NotFound();
            }

            return View(studentinfo);
        }

        // GET: Studentinfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Studentinfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CollegeName,GraduationYear,JobTitle,Email")] Studentinfo studentinfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentinfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentinfo);
        }

        // GET: Studentinfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentinfo = await _context.Studentinfo.FindAsync(id);
            if (studentinfo == null)
            {
                return NotFound();
            }
            return View(studentinfo);
        }

        // POST: Studentinfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,CollegeName,GraduationYear,JobTitle,Email")] Studentinfo studentinfo)
        {
            if (id != studentinfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentinfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentinfoExists(studentinfo.Id))
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
            return View(studentinfo);
        }

        // GET: Studentinfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentinfo = await _context.Studentinfo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentinfo == null)
            {
                return NotFound();
            }

            return View(studentinfo);
        }

        // POST: Studentinfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentinfo = await _context.Studentinfo.FindAsync(id);
            if (studentinfo != null)
            {
                _context.Studentinfo.Remove(studentinfo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentinfoExists(int id)
        {
            return _context.Studentinfo.Any(e => e.Id == id);
        }
    }
}
