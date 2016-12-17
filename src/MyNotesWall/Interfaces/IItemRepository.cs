using System.Collections.Generic;
using MyNotesWall.Models;
using System.Threading.Tasks;

namespace MyNotesWall.Interfaces
{
    public interface IItemRepository
    {
        void CreateItem(Item item);
        void DeleteItem(int id);
        void EditItem(int id);
        IEnumerable<Item> GetItemsList(int? wallId);
        
    }
}
