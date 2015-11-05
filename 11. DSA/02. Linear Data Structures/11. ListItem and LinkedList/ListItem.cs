namespace _11.ListItem_and_LinkedList
{
    public class ListItem<T>
    {
        public T Value { get; set; }

        public ListItem<T> NextItem { get; set; }
    }
}
