//Problem 11
namespace Version_Attribute
{
    using System;

    [Version(5.3)]
    class AtrTest
    {

        static void Main(string[] args)
        {
            Type type = typeof(AtrTest);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("This program's version is {0} ", attr.Version);
            }

        }
    }
    class VersionAttribute : Attribute
    {
        public double Version { get; set; }
        public VersionAttribute(double ver)
        {
            this.Version = ver;
        }
    }
}
