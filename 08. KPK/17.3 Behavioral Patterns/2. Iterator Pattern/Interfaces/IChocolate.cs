namespace Iterator.Interfaces
{
    public interface IChocolate
    {
        string this[int index]
        {
            get;
        }

        IIterator CreateIterator();

    }
}
