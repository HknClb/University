using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hafta4._1.Entities;

namespace Hafta4._1.Models
{
    public class EntityViewModel
    {
        public List<News> news { get; set; }
        public List<Video> video { get; set; }
        public string EntityTypeName { get; set; }

        //public EntityViewModel(List<News> news, List<Video> video, string EntityTypeName)
        //{
        //    this.news = news;
        //    this.video = video;
        //    this.EntityTypeName = EntityTypeName;
        //}

    }
}
