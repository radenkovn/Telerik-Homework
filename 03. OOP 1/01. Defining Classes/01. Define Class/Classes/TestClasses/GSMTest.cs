namespace DefineClasses
{
    public class GSMTest
    {
        private static MobilePhone phone1 = new MobilePhone("Apple", "iPhone 4", 953.44m);
        private static MobilePhone phone2 = new MobilePhone("Sony", "Xperia", 553.24m);
        private static MobilePhone phone3 = new MobilePhone("Nokia", "3310", 19.99m, "Bai Toshko", new Battery("C238239", 43, 10), new Display("0.5 inches", 2));
        private static MobilePhone phone4 = new MobilePhone("Samsung", "Galaxy 3");
        private static MobilePhone[] phonesArray = new MobilePhone[]{phone1, phone2, phone3, phone4};
        public static MobilePhone[] PhonesArray { get { return phonesArray; } }
    }
}
