using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyNotesWall.Data;
using MyNotesWall.Models;
using Microsoft.AspNetCore.Authorization;

namespace MyNotesWall.Controllers
{
    [Authorize]
    public class WallsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WallsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Walls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Walls.ToListAsync());
        }

        // GET: Walls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wall = await _context.Walls
                .SingleOrDefaultAsync(m => m.WallId == id);
            if (wall == null)
            {
                return NotFound();
            }

            return View(wall);
        }

        // GET: Walls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Walls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WallId,Name")] Wall wall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wall);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(wall);
        }

        // GET: Walls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wall = await _context.Walls.SingleOrDefaultAsync(m => m.WallId == id);
            if (wall == null)
            {
                return NotFound();
            }
            return View(wall);
        }

        // POST: Walls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WallId,Name")] Wall wall)
        {
            if (id != wall.WallId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WallExists(wall.WallId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(wall);
        }

        // GET: Walls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wall = await _context.Walls
                .SingleOrDefaultAsync(m => m.WallId == id);
            if (wall == null)
            {
                return NotFound();
            }

            return View(wall);
        }

        // POST: Walls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wall = await _context.Walls.SingleOrDefaultAsync(m => m.WallId == id);
            _context.Walls.Remove(wall);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool WallExists(int id)
        {
            return _context.Walls.Any(e => e.WallId == id);
        }
    }
}
