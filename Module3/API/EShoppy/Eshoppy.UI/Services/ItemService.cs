using Eshoppy.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Eshoppy.UI.Services
{
    public class ItemService : IItemService
    {
        public void AddItem(Item item)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:37351/");
                var contentData = new StringContent(JsonConvert.SerializeObject(item),
                    System.Text.Encoding.UTF8, "application/json"); //convert Item into Json type.
                HttpResponseMessage response = client.PostAsync("api/Item/AddItem", contentData).Result;
              
            }
        }

        public void DeleteItem(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:37351/");
                HttpResponseMessage response = client.DeleteAsync("api/Item/DeleteItem/" + id).Result;
             
            }
        }

        public Item GetItem(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:37351/"); //set API address
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json"); //set the media type format as json
                client.DefaultRequestHeaders.Accept.Add(contentType); //set the media type as json
                HttpResponseMessage response = client.GetAsync("api/Item/GetItem/"+id).Result;
                Item item = JsonConvert.DeserializeObject<Item>(response.Content.ReadAsStringAsync().Result);
                return item;
            }
        }

        public List<Item> GetItems()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:37351/"); //set API address
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json"); //set the media type format as json
                client.DefaultRequestHeaders.Accept.Add(contentType); //set the media type as json
                HttpResponseMessage response = client.GetAsync("api/Item/GetAllItems").Result;
                List<Item> items = JsonConvert.DeserializeObject<List<Item>>(response.Content.ReadAsStringAsync().Result);
                return items;
            }
        }

        public void UpdateItem(Item item)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:37351/");
                var contentData = new StringContent(JsonConvert.SerializeObject(item),
                    System.Text.Encoding.UTF8, "application/json"); //convert Item into Json type.
                HttpResponseMessage response = client.PutAsync("api/Item/UpdateItem", contentData).Result;

            }
        }
    }
}
