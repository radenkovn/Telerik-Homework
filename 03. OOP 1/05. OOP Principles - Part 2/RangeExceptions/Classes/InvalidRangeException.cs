namespace RangeExceptions.Classes
{
    using System;
    class InvalidRangeException<T> : Exception
    {
        private T start;
        private T end;
        public InvalidRangeException(T start, T end)
        {
            this.start = start;
            this.end = end;
        }
        public InvalidRangeException(T start, T end, string message)
            : base(message)
        {
            this.start = start;
            this.end = end;
        }
        public override string Message
        {
            get
            {
                return string.Format("Error: The value is outside of the range: {0} - {1}", this.start, this.end);
            }
        }
    }
}
