namespace DefineClasses
{
    public class Display
    {
        private string size;
        private uint? colorNumber;
        public Display()
            : this(null, null)
        {

        }
        public Display(string size, uint? colorNumber)
        {
            this.size = size;
            this.colorNumber = colorNumber;
        }
        public string Size
        {
            get { return this.size; }
        }
        public uint? ColorNumber
        {
            get { return this.colorNumber; }
        }

    }
}
