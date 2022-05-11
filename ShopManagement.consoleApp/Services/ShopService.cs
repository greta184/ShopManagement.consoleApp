using ShopManagement.consoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.consoleApp.Services
{
    public class ShopService
    {
        private List<ShopItem> _items;
        public ShopService() //constructor
        {
            _items = new List<ShopItem>();
        }
        public void Add(string name, string quantity)
        {
            var item = new ShopItem()
            {
                Name = name,
                Quantity = quantity

            };
            _items.Add(item);
        }
        public void Remove(string name)
        {
            _items = _items.Where(i => i.Name != name).ToList(); 
        }
        public void Update(string name, string quantity)
        {
          var item =  _items.First(i => i.Name == name);
            item.Quantity = quantity;

        }
        public List<ShopItem> GetAll()
        {
            return _items;
        }


    }
}
