using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyNotesWall.Data;
using MyNotesWall.Models;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyNotesWall.Controllers
{
    [Authorize]
    public class ItemsController : Controller
    {

        private ItemsRepository itemsRespository;
        private IHttpContextAccessor httpContextAccessor;

        public ItemsController(ApplicationDbContext _db, IHttpContextAccessor httpContextAccessor)
        {
            this.itemsRespository = new ItemsRepository(_db, httpContextAccessor);
            this.httpContextAccessor = httpContextAccessor;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return RedirectToAction("List");
        }
        public IActionResult List()
        {
            
            return View(itemsRespository.GetItemsListAndModel());
        }
       // [HttpGet]
        public IActionResult EditItem(Item model)
        {
       
           
           return View();
        }
        
        public IActionResult NewMessageForm(Item model)
        {
            return View(model);
        }
        
        public IActionResult CreateItem(Item model)
        {
        
            if (ModelState.IsValid)
            {
                itemsRespository.CreateItem(model);
                return RedirectToAction("List");
            }
            return RedirectToAction("NewMessageForm",model);
        }
        public IActionResult DeleteItem(int id)
        {
            itemsRespository.DeleteItem(id);
            return RedirectToAction("List");
        }

        public IActionResult QuickNote(ListPageModel pageModel)
        {
            return RedirectToAction("CreateItem", pageModel.Model);
        }

    }
}
