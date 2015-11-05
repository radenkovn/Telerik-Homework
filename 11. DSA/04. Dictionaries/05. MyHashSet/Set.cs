namespace MyHashSet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using MyHashTable;

    public class Set<T> : IEnumerable<T>
    {
        private HashTable<T, T> table;

        public Set()
        {
            this.table = new HashTable<T, T>();
        }

        public int Count
        {
            get
            {
                return this.table.Count;
            }
        }

        public void Add(T value)
        {
            if (this.Contains(value))
            {
                return;
            }

            this.table.Add(value, value);
        }

        public T Find(T value)
        {
            return this.table.Find(value);
        }

        public bool Contains(T value)
        {
            return this.table.Contains(value);
        }

        public void Remove(T value)
        {
            this.table.Remove(value);
        }

        public void Clear()
        {
            this.table.Clear();
        }

        public Set<T> Union(Set<T> set)
        {
            var currentSet = new Set<T>();
            foreach (var item in this)
            {
                currentSet.Add(item);
            }

            foreach (var item in set)
            {
                currentSet.Add(item);
            }

            return currentSet;
        }

        public Set<T> Intersect(Set<T> set)
        {
            var currentSet = new Set<T>();
            foreach (var item in this)
            {
                if (!set.Contains(item))
                {
                    currentSet.Add(item);
                }
            }

            foreach (var item in set)
            {
                if (!this.Contains(item))
                {
                    currentSet.Add(item);
                }
            }

            return currentSet;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.table)
            {
                yield return item.Key;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Join(", ", this);
        }
    }
}
