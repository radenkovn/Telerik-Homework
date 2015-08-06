namespace Generic
{
    using System;
    using System.Collections.Generic;
    class GenericList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private T[] myArr;
        private const int initialCap = 4;
        private int count;
        private int capacity;
        public int Count { get { return this.count; } }
        public int Capacity { get { return this.capacity; } }
        public GenericList()
        {
            this.count = 0;
            this.capacity = initialCap;
            this.myArr = new T[this.capacity];
        }
        //Problem 6
        public void Add(T item)
        {
            if (this.count == this.capacity)
            {
                this.capacity *= 2;
                var oldArray = this.myArr;
                this.myArr = new T[this.capacity];
                Array.Copy(oldArray, this.myArr, this.count);
            }
            this.myArr[this.count] = item;
            ++this.count;
        }
        public T Select(int index)
        {
            if (index > this.count)
            {
                throw new IndexOutOfRangeException("The index was out of range");
            }
            return this.myArr[index];
        }
        public void Remove(int index)
        {
            if (index > this.count)
            {
                throw new IndexOutOfRangeException("The index was out of range");
            }
            var oldArray = this.myArr;
            this.myArr = new T[this.capacity];
            for (int i = 0; i < index; i++)
            {
                myArr[i] = oldArray[i];
            }
            for (int i = index; i < this.count; i++)
            {
                myArr[i] = oldArray[i + 1];
            }
            --this.count;
        }
        public void Insert(T item, int index)
        {
            if (index > this.count)
            {
                throw new IndexOutOfRangeException("The index was out of range");
            }
            if (this.count == this.capacity)
            {
                this.capacity *= 2;
                var oldItems = this.myArr;
                this.myArr = new T[this.capacity];
                Array.Copy(oldItems, this.myArr, this.count);
            }
            ++this.count;

            var oldArray = this.myArr;
            this.myArr = new T[this.capacity];
            for (int i = 0; i < index; i++)
            {
                myArr[i] = oldArray[i];
            }
            myArr[index] = item;
            for (int i = index + 1; i < this.count; i++)
            {
                myArr[i] = oldArray[i - 1];
            }
        }
        public void Clear()
        {
            this.count = 0;
            this.capacity = initialCap;
            this.myArr = new T[this.capacity];
        }
        public int IndexOf(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.myArr[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }
        public override string ToString()
        {
            var resultArr = new T[this.count];
            Array.Copy(this.myArr, resultArr, this.count);
            return string.Join(", ", resultArr);
        }
        public T Min()
        {
            if (this.count > 0)
            {
                T currentMin = this.myArr[0];
                for (int i = 1; i < this.count; i++)
                {
                    if (this.myArr[i].CompareTo(currentMin) < 0)
                    {
                        currentMin = this.myArr[i];
                    }
                }
                return currentMin;
            }
            else
            {
                throw new IndexOutOfRangeException("Your array is empty");
            }
        }
        public T Max()
        {
            if (this.count > 0)
            {
                T currentMin = this.myArr[0];
                for (int i = 1; i < this.count; i++)
                {
                    if (this.myArr[i].CompareTo(currentMin) > 0)
                    {
                        currentMin = this.myArr[i];
                    }
                }
                return currentMin;
            }
            else
            {
                throw new IndexOutOfRangeException("Your array is empty");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.count; i++)
            {
                var item = this.myArr[i];
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
