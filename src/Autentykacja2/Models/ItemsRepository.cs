using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warsztaty.Interfaces;

namespace Warsztaty.Data.Models
{
    public class ItemsRepository:IItemRepository
    {
        private ItemsDbContext _db;
        public ItemsRepository(ItemsDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Item> GetUserItems(int id)
        {
            //TODO
            return null;

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
            _db.Add(item);
            _db.SaveChanges();
        }

        public ListPageModel GetItemsListAndModel()
        {
            ListPageModel pageModel= new ListPageModel();
            pageModel.List = GetItemsList();
            pageModel.Model = new Item();
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
    }
}
