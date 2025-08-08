using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class MultiBox<T>
    {
         List<T> items;


        public void InsertItem(T item)
        {
            items.Add(item);
        }
        public List<T> GetAllItems()
        {
            return items; 
        }

        public int Count()
        {
            return items.Count;
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }
    }
}
