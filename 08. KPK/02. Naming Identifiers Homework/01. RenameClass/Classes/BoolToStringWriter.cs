namespace RenameClass.Classes
{
    using System;
    public class BoolToStringWriter
    {
        private const int MaxCount = 6;
        //Alternative version:
        //private const int MAX_COUNT = 6;
        public void WriteBoolOnConsole(bool promenliva)
        {
            string promenlivaKatoString = promenliva.ToString();
            Console.WriteLine(promenlivaKatoString);
        }
    }

}