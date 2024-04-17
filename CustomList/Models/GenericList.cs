using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList.Models
{
    public class GenericList<T>
    {
        public List<T> _values;
        public GenericList()
        {
            _values = new List<T>();
        }

        public void Add(T? item)
        {
            T[] values = new T[_values.Count + 1];

            for (int i = 0; i < _values.Count; i++)
            {
                values[i] = _values[i];
            }
            values[_values.Count] = item!;
            _values = values.ToList();

        }
        public T Find(Predicate<T> value)
        {
            foreach (T item in _values)
            {
                if (value(item))
                {
                    return item;
                }

            }
            return default(T);
        }

        public bool Remove(T item)
        {
            int index = _values.IndexOf(item);
            if (index >= 0)
            {
                _values.RemoveAt(index);
                return true;
            }
            return false;
        }

        public void RemoveAll(Predicate<T> match)
        {
            for (int i = _values.Count - 1; i >= 0; i--)
            {
                if (match(_values[i]))
                {
                    _values.RemoveAt(i);
                }
            }
        }

    }
}
