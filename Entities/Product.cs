using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clothesstore.Entities
{
    public class Product
    {
        public string id { get; set; }

        public string name { get; set; }

        public string brand { get; set; }

        public string thumbnail { get; set; }

        public List<string> pictures { get; set; }

        public string description { get; set; }

        public float price { get; set; }

        public float discountPrice { get; set; }

        public float discountPercent => (float)(price - ((price * discountPrice) / 100));

        public City city { get; set; }

        public Seller seller { get; set; }

        public string currency { get; set; }

        public float rating { get; set; }

    }
}
