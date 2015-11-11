namespace _01.Priority_Queue
{
    using System;
    using System.Collections.Generic;
    //          Taken from Wikipedia:
    //
    //              Max-Heapify (A, i):
    //              left ← 2*i  // ← means "assignment"
    //              right ← 2*i + 1
    //              largest ← i

    //              if left ≤ heap_length[A] and A[left] > A[largest] then:
    //                  largest ← left
    //              if right ≤ heap_length[A] and A[right] > A[largest] then:
    //                  largest ← right

    //              if largest ≠ i then:
    //                  swap A[i] and A[largest]
    //                  Max-Heapify(A, largest)



    //              Build-Max-Heap (A):
    //              heap_length[A] ← length[A]

    //              for each index i from floor(length[A]/2) downto 1 do:
    //                  Max-Heapify(A, i)


    public class MyPriorityQueue<T> : IEnumerable<T>
        where T : IComparable<T>
    {

        private List<T> heap;

        public MyPriorityQueue()
        {
            this.heap = new List<T>();
            this.heap.Add(default(T));
        }

        public int Count
        {
            get
            {
                if (this.heap.Count == 1)
                {
                    return 0;
                }

                return this.heap.Count;

            }
        }

        public T ExtractMax()
        {
            if (this.Count == 0)
            {
                throw new IndexOutOfRangeException();
            }

            var max = this.heap[1];
            var valueToReplace = this.heap[this.Count - 1];

            var currentList = this.heap;
            currentList[1] = valueToReplace;
            var listToReplace = new List<T>();
            for (int i = 0; i < this.Count - 1; i++)
            {
                listToReplace.Add(currentList[i]);
            }
            this.heap = listToReplace;
            this.BuildMaxHeap();
            return max;
        }

        public void Insert(T element)
        {
            this.heap.Add(element);
            this.BuildMaxHeap();
        }

        private void Heapify(int i)
        {
            var left = 2 * i;
            var right = 2 * i + 1;
            var largest = i;
            if (left <= this.Count - 1 && this.heap[left].CompareTo(this.heap[largest]) > 0)
            {
                largest = left;
            }
            if (right <= this.Count - 1 && this.heap[right].CompareTo(this.heap[largest]) > 0)
            {
                largest = right;
            }

            if (largest != i)
            {
                var oldValue = this.heap[i];
                this.heap[i] = this.heap[largest];
                this.heap[largest] = oldValue;
                this.Heapify(largest);
            }
        }

        private void BuildMaxHeap()
        {
            var length = this.Count;

            for (int i = length - 1; i >= 1; i--)
            {
                this.Heapify(i);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 1; i < this.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine();
                }
                yield return this.heap[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
