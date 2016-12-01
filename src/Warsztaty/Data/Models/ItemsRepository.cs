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
        public IEnumerable GetUserItems(int id)
        {
            //TODO
            return null;

        }
        public void EditItem(int id) {
        }
        public IEnumerable GetItemsList()
        {
            return _db.Items.ToList();
        }
        public void CreateItem(Item item)
        {
            item.CreatedAt = DateTime.Now;
            _db.Add(item);
            _db.SaveChanges();
        }
        public void DeleteItem(int id)
        {
            Item item = _db.Items.Find(id);
            _db.Remove(item);
            _db.SaveChanges();
        }
    }
}
