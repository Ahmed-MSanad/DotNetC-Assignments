using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.MyListMethods
{
    public class CustomList<T>
    {
        private T[] items;

        public CustomList(T[] _items) {
            items = _items;
        }

        public bool Exists(Predicate<T> predicate)
        {
            foreach (T item in items)
            {
                if (predicate.Invoke(item))
                    return true;
            }
            return false;
        }

        public T Find(Predicate<T> predicate)
        {
            foreach(T item in items)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default(T);
        }


        public List<T> FindAll(Predicate<T> predicate)
        {
            List<T> result = new List<T>();
            foreach (T item in items)
            {
                if (predicate.Invoke(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }


        public int FindIndex(Predicate<T> predicate)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (predicate(items[i]))
                    return i;
            }
            return -1;
        }
    

        public T FindLast(Predicate<T> predicate)
        {
            for(int i = items.Length - 1; i >= 0; i--)
            {
                if (predicate(items[i]))
                    return items[i];
            }
            return default(T);
        }

        public int FindLastIndex(Predicate<T> predicate) { 
            for(int i = items.Length-1; i >= 0; i--)
            {
                if (predicate.Invoke(items[i]))
                    return i;
            }
            return -1;
        }

        
        public void ForEach(Action<T> action)
        {
            foreach (T item in items)
                action.Invoke(item);
        }


        public bool TrueForAll(Predicate<T> predicate)
        {
            foreach(T item in items)
            {
                if(!predicate.Invoke(item))
                    return false;
            }
            return true;
        }

    }
}
