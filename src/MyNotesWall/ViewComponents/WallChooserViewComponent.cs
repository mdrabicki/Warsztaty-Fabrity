using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MyNotesWall.Data;
using MyNotesWall.Models;
using Microsoft.EntityFrameworkCore;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyNotesWall.ViewComponents
{
    public class WallChooserViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext db;

        public WallChooserViewComponent(ApplicationDbContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(
        int activeWall)
        {
            var items = await GetItemsAsync(activeWall);
            return View(items);
        }
        private Task<List<Wall>> GetItemsAsync(int activeWall)
        {
            return db.Walls.Where(x => x.WallId != activeWall).ToListAsync();
        }
    }
}
