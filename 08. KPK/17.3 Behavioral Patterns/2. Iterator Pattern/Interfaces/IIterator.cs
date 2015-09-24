namespace Iterator.Interfaces
{
    public interface IIterator
    {
        void Next();

        bool IsDone();

        object CurrentItem();
    }
}
