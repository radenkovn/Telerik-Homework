namespace _01.Northwind_tasks
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;
    using System.Data.Linq;


    //I hope this is enough!
    public class ExtendedEmployee : Employee
    {
        public EntitySet<Territory> GetTerritories()
        {
            var entities = new EntitySet<Territory>();
            foreach (var territory in this.Territories)
            {
                entities.Add(territory);
            }
            return entities;
        }
    }
}
