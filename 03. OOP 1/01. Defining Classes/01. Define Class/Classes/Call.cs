
namespace DefineClasses
{
    using System;
    using System.Globalization;
    public class Call
    {
        private DateTime date;   
        private DateTime time;
        private string phoneNumber;
        private int seconds;
        public Call(string date, string time, string phoneNumber, int seconds)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            this.date = DateTime.ParseExact(date, "dd/MM", provider);
            this.time = DateTime.ParseExact(time, "H:mm", provider);
            this.phoneNumber = phoneNumber;
            this.seconds = seconds;
        }
        public DateTime Date { get { return this.date; } }
        public DateTime Time { get { return this.time; } }
        public string PhoneNumber { get { return this.phoneNumber; } }
        public int Seconds { get { return this.seconds; } }
        public override string ToString()
        {
            return string.Format("Date: {0}/{1}. Time: {2}:{3}. Phone number: {4}. Duration: {5} seconds.", this.date.Day, this.date.Month, this.time.Hour, this.time.Minute, this.phoneNumber, this.seconds);
        }
    }
}
