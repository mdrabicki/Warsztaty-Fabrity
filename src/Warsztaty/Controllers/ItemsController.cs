﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Warsztaty.Data;
using Warsztaty.Data.Models;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Warsztaty.Controllers
{
     public class ItemsController : Controller
    {

        private ItemsDbContext _db;

        public ItemsController(ItemsDbContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult List()
        {
            
            return View(_db.Items.ToList());
        }
       // [HttpGet]
        public IActionResult Edit(Item model)
        {
       
           
           return View();
        }
        [HttpGet]
        public IActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateMessage(Item model)
        {
            if (ModelState.IsValid)
            {
                _db.Add(model);
                _db.SaveChanges();
                return View("List", _db.Items.ToList());
            }
            return RedirectToAction("NewMessage");
        }

    }
}
