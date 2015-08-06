namespace RefactoringStatements
{
    using System;
    using RefactoringStatements.Classes;
    class EntryPoint
    {
        static void Main()
        {
            //First Part of the Problem
            Potato potato = new Potato();
            var potatoIsValid = potato != null;
            var potatoIsCookable = potatoIsValid && !(potato.HasNotBeenPeeled || potato.IsRotten);
            if (potatoIsCookable)
            {
                Cook(potato);
            }

            //Second Part of the Problem
            var x = 5;
            var MIN_X = 0;
            var MAX_X = 10;
            var xIsValid = x >= MIN_X && x <= MAX_X;

            var y = 9;
            var MAX_Y = 15;
            var MIN_Y = 5;
            var yIsValid = MAX_Y >= y && MIN_Y <= y;

            var cellIsVisitable = false;//Or some logic
            
            var coordinatesAreValid = xIsValid && yIsValid && cellIsVisitable;

            if (coordinatesAreValid)
            {
                VisitCell();
            }

        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }
    }
}
