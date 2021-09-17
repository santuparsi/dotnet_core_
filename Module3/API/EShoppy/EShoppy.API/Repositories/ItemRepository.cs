using EShoppy.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EShoppy.API.Repositories
{
    public class ItemRepository : IItemRepository
    {
        EShoppyContext db = null;
        public ItemRepository()
        {
            db = new EShoppyContext();
        }
        public void AddItem(Item item)
        {
            try
            {
                db.Items.Add(item);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteItem(int id)
        {
            try
            {
                Item item = db.Items.Find(id);
                db.Items.Remove(item);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Item GetItem(int id)
        {
            try
            {
                Item item = db.Items.Find(id);
                return item;
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Item> GetItems()
        {
            try
            {
                return db.Items.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateItem(Item item)
        {
            try
            {
                db.Items.Update(item);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
