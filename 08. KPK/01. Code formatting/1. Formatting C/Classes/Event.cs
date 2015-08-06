namespace FormattingC.Classes
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int orderedByDate = this.date.CompareTo(other.date);
            int orderedByTitle = this.title.CompareTo(other.title);
            int orderedByLocation = this.location.CompareTo(other.location);
            if (orderedByDate == 0)
            {
                if (orderedByTitle == 0)
                {
                    return orderedByLocation;
                }
                else
                {
                    return orderedByTitle;
                }
            }
            else
            {
                return orderedByDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);
            if (this.location != null && this.location != string.Empty)
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}
