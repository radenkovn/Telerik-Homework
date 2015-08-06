namespace StudentClass
{
    using System;

    using StudentClass.Classes;
    using StudentClass.Classes.Enums;
    class StartingPoint
    {
        static void Main()
        {
            Student pesho = new Student("Pesho", "Petrov", "Peshov", 59599595523, "Sofia, 5", "08885599595", "pesho@abv.bg", 3, Specialties.ElectricalEngineering, Universities.SofiaUni, Faculties.Math);
            Student ivan = new Student("Ivan", "Ivanchev", "Ivanov", 59587294523, "Plovdiv, 123", "0888737372", "vanio@abv.bg", 3, Specialties.English, Universities.PlovdivUni, Faculties.Linguistics);
            Student peshocopy = (Student)pesho.Clone();
            Console.WriteLine("ivan                       {0}", ivan);
            Console.WriteLine("pesho                      {0}", pesho);
            Console.WriteLine("peshocopy                  {0}", peshocopy);
            Console.WriteLine("pesho.CompareTo(ivan)      {0}", pesho.CompareTo(ivan));
            Console.WriteLine("pesho.CompareTo(peshocopy) {0}", pesho.CompareTo(peshocopy));
            Console.WriteLine("pesho == peshocopy         {0}", pesho == peshocopy);
            Console.WriteLine("pesho != peshocopy         {0}", pesho != peshocopy);
        }
    }
}
