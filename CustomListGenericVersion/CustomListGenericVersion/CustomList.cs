using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListGenericVersion
{
    public class CustomList<T>
    {
        public T[] _items;
        public int Count;
        public CustomList()
        {
            _items = new T[0];
            Count = 0;
        }

        private void Resize()
        {
            int newCapacity = _items.Length == 0 ? 4 : _items.Length * 2;
            T[] newArr = new T[newCapacity];
            Array.Copy(_items, newArr, _items.Length);
            _items = newArr;
        }
        


         public void GetAll() { 
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_items[i]);
            }
        }
        public void Add(T item)
        {
            if (Count == _items.Length)
            {
                Resize();
            }

            _items[Count] = item;
            Count++;
        }

        public void AddRange(params T[] array)
        {
            foreach (T item in array)
            {
                Add(item);
            }
        }

        public void Insert(int index, T item)
        {
            if (Count == _items.Length)
            {
                Resize();
            }

            for (int i = Count; i > index; i--)
            {
                _items[i] = _items[i - 1];
            }
            _items[index] = item;
            Count++;
        }
        public void InsertRange(int index, params T[] array)
        {
            foreach (T item in array)
            {
                Insert(index, item);
                index++;
            }
        }

        public void Remove(T item)
        {
            int index = Array.IndexOf(_items, item, 0, Count);
            if (index >= 0)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    _items[i] = _items[i + 1];
                }
                _items[Count - 1] = default(T);
                Count--;
            }
        }
        public void RemoveAt(int index)
        {
            if (index > 0 && index < Count)
            {
                for (int i = index; i < Count - 1; i++)
                {
                    _items[i] = _items[i + 1];
                }
                _items[Count - 1] = default(T);
                Count--;
            }
        }
        public void Clear()
        {
            Count = 0;
        }
    }

}

