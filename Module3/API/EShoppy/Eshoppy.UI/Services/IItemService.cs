using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshoppy.UI.Models;
namespace Eshoppy.UI.Services
{
    public interface IItemService
    {
        List<Item> GetItems();
        Item GetItem(int id);
        void AddItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(int id);
    }
}
