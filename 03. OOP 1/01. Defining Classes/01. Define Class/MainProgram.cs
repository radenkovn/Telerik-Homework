namespace DefineClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class MainProgram
    {
        static void Main()
        {
            Console.WriteLine("GSM TEST:\n");
            foreach (var phone in GSMTest.PhonesArray)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine();
            }
            Console.WriteLine("Iphone Info only once:\n");
            Console.WriteLine(MobilePhone.Iphone4S);

            var test = new GSMCallHistoryTest();
        }
    }
}
