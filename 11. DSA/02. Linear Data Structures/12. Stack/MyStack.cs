namespace _12.Stack
{
    using System.Collections;
    using System.Collections.Generic;

    public class MyStack<T> : IEnumerable<T>
    {
        private T[] values;
        private int capacity;
        private int count;

        public MyStack()
        {
            this.count = 0;
            this.capacity = 4;
            this.values = new T[this.capacity];
        }

        public void Push(T value)
        {
            if (this.count >= this.capacity * 3 / 4)
            {
                var oldValues = new T[this.capacity];
                for (int i = 0; i < this.count; i++)
                {
                    oldValues[i] = this.values[i];
                }
                this.capacity *= 2;
                this.values = new T[this.capacity];
                for (int i = 0; i < this.count; i++)
                {
                    this.values[i] = oldValues[i];
                }

            }
            this.values[this.count] = value;
            this.count++;
        }

        public T Pop()
        {
            //TODO Make the array Smaller
            var value = this.values[this.count];
            this.count--;
            return value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.count; i++)
            {
                yield return this.values[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
