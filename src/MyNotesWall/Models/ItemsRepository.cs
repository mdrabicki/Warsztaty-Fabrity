﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyNotesWall.Interfaces;
using MyNotesWall.Data;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace MyNotesWall.Models
{ 
    public class ItemsRepository:IItemRepository
    {
        private ApplicationDbContext _db;
        private IHttpContextAccessor httpContextAccessor;
        public ItemsRepository(ApplicationDbContext db, IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
            _db = db;
        }
        public void EditItem(int id) {
        }
        public IEnumerable<Item> GetItemsList()
        {
            return _db.Items.ToList();
        }
        public void CreateItem(Item item)
        {
            
            item.CreatedAt = DateTime.Now;
         //   UserWallItem userWallItem = new UserWallItem();
         //   userWallItem.User.Id = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            item.OwnerId= httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            //  userWallItem.Wall.WallId = 1;
            //  userWallItem.Item = item;
            item.WallID = 1;
            UserWallItem userWallItem = new UserWallItem()
            {
                Item = item,
                User = _db.Find<ApplicationUser>(item.OwnerId),
                Wall = _db.Find<Wall>(1)
            };
            _db.Add(userWallItem);
            _db.SaveChanges();
        }

        public ListPageModel GetItemsListAndModel()
        {
            ListPageModel pageModel = new ListPageModel()
            {
                List = GetItemsList(),
                Model = new Item()
            };
            return pageModel;

        }

        public void DeleteItem(int id)
        {
            Item item = _db.Items.Find(id);
            _db.Remove(item);
            _db.SaveChanges();
        }
        
        public Item GetItemModel()
        {
            return new Item();
        }

        public IEnumerable<Item> GetItemsList(int? wallId)
        {
            if (wallId == null)
            {
                return _db.Items.ToList();
                wallId=default(int);
            }
            return _db.Items.Where(x => x.WallID == wallId).ToList();
        }
    }
}
