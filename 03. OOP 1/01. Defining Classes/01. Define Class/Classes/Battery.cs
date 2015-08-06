namespace DefineClasses
{
    public class Battery
    {
        private string model;
        private int? idleH;
        private int? talkH;
        private BatteryType batteryType;
        public Battery()
            : this(null)
        {

        }
        public Battery(string model)
            : this(model, null, null)
        {

        }
        public Battery(string model, int? idleH, int? talkH)
        {
            this.model = model;
            this.idleH = idleH;
            this.talkH = talkH;
        }
        public string Model
        {
            get { return this.model; }
        }
        public int? IdleH
        {
            get { return this.idleH; }
        }
        public int? TalkH
        {
            get { return this.talkH; }
        }
        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
    }
    public enum BatteryType
    {
        LiIon, NiMH, NiCd, Ion
    }
}
