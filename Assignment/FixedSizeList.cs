using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class FixedSizeList<T> : IEnumerable<T>
    {
        public List<T> list { get; set; }

        public int capacity { get; set; }

        public FixedSizeList(int capacity)
        {
            this.capacity = capacity;
            list = new List<T>(capacity);
        }

        public void Add(T item)
        {
            if (list.Count >= capacity)
                throw new Exception("Capacity is full");

            list.Add(item);
        }

        public T Get(int index)
        {
            if (index >= list.Count)
                throw new Exception("Index out of range");

            return list[index];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
