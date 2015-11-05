namespace _01.Positive_Integer_Numbers
{
    using System.Collections.Generic;

    public class Sequence
    {
        private ICollection<int> numbers;

        public Sequence()
        {
            this.numbers = new List<int>();
        }

        public void Add(int number)
        {
            this.numbers.Add(number);
        }

        public int Sum()
        {
            var sum = 0;
            foreach (var number in this.numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int Average()
        {
            var sum = this.Sum();
            return sum / this.numbers.Count;
        }
    }
}
