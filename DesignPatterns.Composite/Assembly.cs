using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    public class Assembly : Item
    {
        private IList<Item> items;

        public Assembly(string description) : base(description, 0)
        {
            items = new List<Item>();
        }

        public override void AddItem(Item item)
        {
            items.Add(item);
        }

        public override void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public override Item[] Items
        {
            get 
            {
                return items.ToArray();
            }
        }

        public override int Cost
        {
            get
            {
                int total = 0;
                foreach (Item item in items)
                {
                    total += item.Cost;
                }

                return total;
            }
        }
    }
}
