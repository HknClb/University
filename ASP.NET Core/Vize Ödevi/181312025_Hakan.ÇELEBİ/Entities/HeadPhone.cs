using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _181312025_Hakan.ÇELEBİ.Entities
{
    public class HeadPhone
    {
        public int ID { get; set; }
        public string TradeMark { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }
        public bool BlueTooth { get; set; }
        public double Price { get; set; }
        public string ReleaseYear { get; set; }

        public HeadPhone(int ID, string TradeMark, string ModelName, string Color, bool BlueTooth, double Price, string ReleaseYear)
        {
            this.ID = ID;
            this.TradeMark = TradeMark;
            this.ModelName = ModelName;
            this.Color = Color;
            this.BlueTooth = BlueTooth;
            this.Price = Price;
            this.ReleaseYear = ReleaseYear;
        }

    }
}
