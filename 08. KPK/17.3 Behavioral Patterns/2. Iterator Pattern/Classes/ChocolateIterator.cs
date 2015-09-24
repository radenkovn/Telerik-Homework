namespace Iterator.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Iterator.Interfaces;

    public class ChocolateIterator : IIterator
    {
        private readonly Chocolate chocolate;

        private int currentProperty = 0;
        public ChocolateIterator(Chocolate chocolate)
        {
            this.chocolate = chocolate;
        }

        public void Next()
        {
            this.currentProperty++;
        }

        public bool IsDone()
        {
            return (this.currentProperty >= chocolate.PropertyCount);
        }

        public object CurrentItem()
        {
            return chocolate[currentProperty];
        }
    }
}
