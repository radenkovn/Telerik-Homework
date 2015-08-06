namespace RenameClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using RenameClass.Classes;
    class EntryPoint
    {
        public static void Main()
        {
            var boolWriter = new BoolToStringWriter();
            boolWriter.WriteBoolOnConsole(true);
        }
    }
}
