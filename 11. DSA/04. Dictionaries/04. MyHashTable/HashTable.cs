namespace MyHashTable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private const int DefaultCapacity = 16;
        private LinkedList<KeyValuePair<K, T>>[] lists;
        private HashSet<K> keys;
        private int count;
        private int capacity = DefaultCapacity;

        public HashTable()
        {
            this.lists = new LinkedList<KeyValuePair<K, T>>[this.capacity];
            this.keys = new HashSet<K>();
        }

        public int Count
        {
            get { return this.count; }
        }

        public HashSet<K> Keys
        {
            get
            {
                this.GenerateKeys();
                return this.keys;
            }
        }

        public T this[K key]
        {
            get
            {
                if (!this.Contains(key))
                {
                    throw new KeyNotFoundException("Your key was not found!");
                }

                return this.Find(key);
            }

            set
            {
                if (!this.Contains(key))
                {
                    throw new KeyNotFoundException("Your key was not found!");
                }

                var index = this.GetIndex(key);
                var list = this.lists[index];

                var pair = list.FirstOrDefault(x => x.Key.Equals(key));
                list.Remove(pair);
                var newPair = new KeyValuePair<K, T>(key, value);
                list.AddLast(newPair);
            }
        }

        public void Add(K key, T value)
        {
            if (this.Contains(key))
            {
                throw new InvalidOperationException("The dictionary contains the key!");
            }

            this.count++;
            if (this.count >= this.capacity * 3 / 4)
            {
                var oldLists = new LinkedList<KeyValuePair<K, T>>[this.count];
                for (int i = 0; i < this.count; i++)
                {
                    oldLists[i] = this.lists[i];
                }

                this.capacity *= 2;
                this.lists = new LinkedList<KeyValuePair<K, T>>[this.capacity];
                for (int i = 0; i < this.count; i++)
                {
                    this.lists[i] = oldLists[i];
                }
            }

            var index = this.GetIndex(key);
            if (this.lists[index] == null)
            {
                this.lists[index] = new LinkedList<KeyValuePair<K, T>>();
            }

            var currentList = this.lists[index];
            var pair = new KeyValuePair<K, T>(key, value);
            var node = new LinkedListNode<KeyValuePair<K, T>>(pair);
            currentList.AddLast(node);
        }

        public bool Contains(K key)
        {
            var index = this.GetIndex(key);
            var list = this.lists[index];
            if (list == null)
            {
                return false;
            }

            foreach (var pair in list)
            {
                if (pair.Key.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }

        public T Find(K key)
        {
            if (!this.Contains(key))
            {
                return default(T);
            }

            var index = this.GetIndex(key);
            var list = this.lists[index];

            foreach (var pair in list)
            {
                if (pair.Key.Equals(key))
                {
                    return pair.Value;
                }
            }

            return default(T);
        }

        public void Remove(K key)
        {
            if (!this.Contains(key))
            {
                return;
            }

            var index = this.GetIndex(key);
            var list = this.lists[index];

            var pair = list.FirstOrDefault(x => x.Key.Equals(key));
            list.Remove(pair);
            this.count--;
        }

        public void Clear()
        {
            this.count = 0;
            this.capacity = DefaultCapacity;
            this.lists = new LinkedList<KeyValuePair<K, T>>[this.capacity];
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var list in this.lists)
            {
                if (list != null)
                {
                    foreach (var pair in list)
                    {
                        yield return pair;
                    }
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private int GetIndex(K key)
        {
            var hash = key.GetHashCode();
            if (hash < 0)
            {
                hash *= -1;
            }

            return hash % this.capacity;
        }

        private void GenerateKeys()
        {
            var keys = new HashSet<K>();
            foreach (var list in this.lists)
            {
                if (list != null)
                {
                    foreach (var pair in list)
                    {
                        keys.Add(pair.Key);
                    }
                }
            }

            this.keys = keys;
        }
    }
}
