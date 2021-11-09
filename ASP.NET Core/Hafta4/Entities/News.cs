using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hafta4.Entities
{
    public class News
    {
        public long ID { get; set; }

        public string Title { get; set; }

        public bool Approve { get; set; }

        public News(long ID, string Title, bool Approve)
        {
            this.ID = ID;
            this.Title = Title;
            this.Approve = Approve;
        }
    }
}
