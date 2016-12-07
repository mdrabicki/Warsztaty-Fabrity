using System.Collections.Generic;
using MyNotesWall.Models;

namespace MyNotesWall.Interfaces
{
    public interface IItemRepository
    {
        void CreateItem(Item item);
        void DeleteItem(int id);
        void EditItem(int id);
        IEnumerable<Item> GetUserItems(int id);
        IEnumerable<Item> GetItemsList();
    }
}
