namespace _13.Queue
{
    using System.Collections;
    using System.Collections.Generic;

    public class MyQueue<T> : IEnumerable<T>
    {
        private T[] values;
        private int capacity;
        private int count;

        public MyQueue()
        {
            this.count = 0;
            this.capacity = 4;
            this.values = new T[this.capacity];
        }

        public void Enqueue(T value)
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

            var currentValues = new T[this.count + 1];
            for (int i = 0; i < this.count; i++)
            {
                currentValues[i] = this.values[i];
            }
            this.values = new T[this.capacity];
            for (int i = 0; i < this.count; i++)
            {
                this.values[i + 1] = currentValues[i];
            }

            this.values[0] = value;

            this.count++;
        }

        public T Dequeue()
        {
            var value = this.values[0];

            var oldValues = new T[this.capacity - 1];
            for (int i = 1; i < this.count; i++)
            {
                oldValues[i - 1] = this.values[i];
            }
            this.values = new T[this.capacity];
            for (int i = 0; i < this.count; i++)
            {
                this.values[i] = oldValues[i];
            }

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
