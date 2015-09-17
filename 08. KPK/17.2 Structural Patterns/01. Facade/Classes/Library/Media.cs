namespace Facade.Classes.Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Media
    {
        public Media(string name, MediaType type)
        {
            this.Name = name;
            this.Type = type;
        }
        public string Name { get; set; }
        public MediaType Type { get; set; }
        public Media Clone()
        {
            return new Media(this.Name, this.Type);
        }
    }
}
