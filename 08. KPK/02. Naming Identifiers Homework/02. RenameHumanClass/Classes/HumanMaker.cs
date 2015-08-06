namespace RenameHumanClass.Classes
{
    using RenameHumanClass.Enums;
    class HumanMaker
    {
        public void MakeHuman(int age)
        {
            Human currentHuman = new Human();
            currentHuman.Age = age;
            if (age % 2 == 0)
            {
                currentHuman.Name = "Батката";
                currentHuman.Gender = Gender.Male;
            }
            else
            {
                currentHuman.Name = "Мацето";
                currentHuman.Gender = Gender.Female;
            }
        }
    }
}
