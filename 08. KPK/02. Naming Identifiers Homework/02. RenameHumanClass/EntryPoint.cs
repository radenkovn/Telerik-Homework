namespace RenameHumanClass
{
    using System;
    using RenameHumanClass.Classes;
    using RenameHumanClass.Enums;
    class EntryPoint
    {
        static void Main()
        {
            var humanMaker = new HumanMaker();
            humanMaker.MakeHuman(15);
        }
    }
}
