namespace DefineClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class GSMCallHistoryTest
    {
        private MobilePhone phone;
        public GSMCallHistoryTest()
        {
            Console.WriteLine("\nGSM CALL HISTORY TEST");
            Console.WriteLine();
            this.phone = new MobilePhone("Nokia", "3310", 19.99m, "Bai Toshko", new Battery("C238239", 43, 10), new Display("0.5 inches", 2));
            Call call1 = new Call("04/10", "23:23", "01289390218", 2525);
            Call call2 = new Call("15/09", "4:44", "01892338585", 60123);
            Call call3 = new Call("01/04", "5:25", "0129393589", 5552);
            Call call4 = new Call("05/12", "17:15", "023048848", 12351);
            Call call5 = new Call("31/08", "18:59", "084848321", 494559);
            this.phone.PhoneCallsList.Add(call1);
            this.phone.PhoneCallsList.Add(call2);
            this.phone.PhoneCallsList.Add(call3);
            this.phone.PhoneCallsList.Add(call4);
            this.phone.PhoneCallsList.Add(call5);
            foreach (var call in this.phone.PhoneCallsList)
            {
                Console.WriteLine(call.ToString());
            }
            Console.WriteLine();
            double price = 0.37;
            Console.WriteLine("The TOTAL PRICE IS: {0}", this.phone.PriceTotal(price));
            Console.WriteLine();
            this.phone.PhoneCallsList.Remove(call5);
            Console.WriteLine("REMOVED THE LARGEST ONE");
            Console.WriteLine("The TOTAL PRICE IS: {0}", this.phone.PriceTotal(price));
            Console.WriteLine();
            this.phone.ClearCallList();
            Console.WriteLine("CLEARED LIST");
            Console.WriteLine("The TOTAL PRICE IS: {0}", this.phone.PriceTotal(price));
            Console.WriteLine();


        }
        public MobilePhone Phone { get { return this.phone; } set { this.phone = value; } }
    }
}
