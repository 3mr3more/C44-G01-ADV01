using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass6
{
    internal class FixedSizeList<T>
    {
         T[] items;
         int count = 0;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                Console.WriteLine(" Must be greater than 0");

            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (count >= items.Length)
                Console.WriteLine("List is full");

            items[count++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                Console.WriteLine("Invalid index");

            return items[index];
        }
    }
}
