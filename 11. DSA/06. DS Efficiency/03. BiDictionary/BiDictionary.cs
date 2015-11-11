namespace _03.BiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;


    public class BiDictionary<K1, K2, T>
        where T : IComparable<T>
    {
        private MultiDictionary<K1, T> firstKeyDict;
        private MultiDictionary<K2, T> secondKeyDict;

        public BiDictionary()
        {
            this.firstKeyDict = new MultiDictionary<K1, T>(true);
            this.secondKeyDict = new MultiDictionary<K2, T>(true);
        }

        public void Add(K1 key1, K2 key2, T value)
        {
            this.firstKeyDict.Add(key1, value);
            this.secondKeyDict.Add(key2, value);
        }

        public ICollection<T> this[K1 key1]
        {
            get { return this.firstKeyDict[key1]; }
        }

        public ICollection<T> this[K2 key2]
        {
            get { return this.secondKeyDict[key2]; }
        }

        public ICollection<T> this[K1 key1, K2 key2]
        {
            //No repeating values
            //get { return this.firstKeyDict[key1].Intersect(this.secondKeyDict[key2]).ToList(); }

            //Repeating values
            get { return firstKeyDict[key1].Where(i => secondKeyDict[key2].Contains(i)).ToList(); }

        }
    }
}
