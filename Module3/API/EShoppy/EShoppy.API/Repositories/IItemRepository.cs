using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.API.Entities;
namespace EShoppy.API.Repositories
{
    interface IItemRepository
    {
        List<Item> GetItems();
        Item GetItem(int id);
        void AddItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(int id);
    }
}
