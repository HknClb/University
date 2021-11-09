using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Hafta4._1.Entities
{
    public class Video
    {
        public long ID { get; set; }

        public string Title { get; set; }

        public string Tag { get; set; }
        
        public bool Approve { get; set; }

        public Video(long ID, string Title, string Tag, bool Approve)
        {
            this.ID = ID;
            this.Title = Title;
            this.Tag = Tag;
            this.Approve = Approve;
        }
    }
}
