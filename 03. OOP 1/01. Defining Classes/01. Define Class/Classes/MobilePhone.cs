namespace DefineClasses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class MobilePhone
    {
        private string manufacturer;
        private string model;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> phoneCallsList;
        private static string iphone4 = "Manufacturer: Apple\nModel: 4S\nPrice: 2000 EURO\nOwner: Bill Gates\nBattery Type: Li-Po\nDisplay Size: 3.5 inches\nDisplay Colors: 16M ";

        public MobilePhone(string manufacturer, string model)
            : this(manufacturer, model, null, null, new Battery(), new Display())
        {

        }
        public MobilePhone(string manufacturer, string model, decimal price)
            : this(manufacturer, model, price, null, new Battery(), new Display())
        {

        }
        public MobilePhone(string manufacturer, string model, decimal? price, string owner, Battery battery, Display display)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            this.phoneCallsList = new List<Call>();
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
        }
        public string Model
        {
            get { return this.model; }
        }
        public decimal? Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        public static string Iphone4S { get { return iphone4; } }
        public List<Call> PhoneCallsList { get { return this.phoneCallsList; } }
        public override string ToString()
        {

            return string.Format("Manufacturer: {0}\nModel: {1}\nPrice: {2}\nOwner: {3}\nBattery Type: {4}\nDisplay Size: {5}\nDisplay Colors: {6}", this.manufacturer, this.model, this.price, this.owner, this.battery.BatteryType, this.display.Size, this.display.ColorNumber);
        }
        public void AddCall(Call call)
        {
            this.phoneCallsList.Add(call);
        }
        public void DeleteCall(Call call)
        {
            this.phoneCallsList.Remove(call);
        }
        public void ClearCallList()
        {
            this.phoneCallsList.Clear();
        }
        public double PriceTotal(double pricePerMin)
        {
            double totalSum = 0;
            foreach (var phonecall in this.phoneCallsList)
            {
                totalSum += ((phonecall.Seconds / 60) + 1) * pricePerMin;
            }
            return totalSum;
        }
    }
}
