using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafta3.Models
{
    public class ModelsLists
    {
        public int ID { get; set; }

        public string SchoolNumber { get; set; }

        public string Name { get; set; }

        public string SchoolName { get; set; }

        public string Country { get; set; }

        public ModelsLists(int ID, string SchoolNumber, string Name, string SchoolName, string Country)
        {
            this.ID = ID;
            this.SchoolNumber = SchoolNumber;
            this.Name = Name;
            this.SchoolName = SchoolName;
            this.Country = Country;
        }
    }
}
