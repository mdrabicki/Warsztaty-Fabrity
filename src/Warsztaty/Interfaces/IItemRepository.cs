using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warsztaty.Data.Models;

namespace Warsztaty.Interfaces
{
    public interface IItemRepository
    {
        void CreateItem(Item item);
        void DeleteItem(int id);
        void EditItem(int id);
        IEnumerable GetUserItems(int id);
        IEnumerable GetItemsList();
    }
}
