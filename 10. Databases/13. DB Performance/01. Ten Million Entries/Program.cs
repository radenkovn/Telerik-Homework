namespace _01.Ten_Million_Entries
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var letters = "qwertyuiop";

            var random = new Random();
            var db = new SampleHWEntities();
            for (int i = 0; i < 8800000; i++)
            {
                var date = DateTime.Now.AddDays(random.Next(1, (int)(i / 47 + 1)));

                var entityToAdd = new FirstTable
                {
                    date = date,
                    text = letters.Substring(0, (i + letters.Length) % letters.Length)
                };
                db.FirstTables.Add(entityToAdd);

                if (i % 100 == 0)
                {
                    db.SaveChanges();
                    db.Dispose();
                    db = new SampleHWEntities();
                }

            }

        }
    }
}
