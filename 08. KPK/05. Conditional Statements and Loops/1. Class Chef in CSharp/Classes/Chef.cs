namespace ClassChefExercise.Classes
{
    using System;

    public class Chef
    {
        private Bowl GetBowl()
        {
            throw new NotImplementedException();
        }
        private Carrot GetCarrot()
        {
            throw new NotImplementedException();
        }
        private void Cut(Vegetable potato)
        {
            throw new NotImplementedException();
        }
        public void Cook()
        {
            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);

            Bowl bowl = GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private void Cut(Carrot carrot)
        {
            throw new NotImplementedException();
        }

        private void Cut(Potato potato)
        {
            throw new NotImplementedException();
        }

        private void Peel(Carrot carrot)
        {
            throw new NotImplementedException();
        }

        private void Peel(Potato potato)
        {
            throw new NotImplementedException();
        }
        private Potato GetPotato()
        {
            throw new NotImplementedException();
        }
    }
}