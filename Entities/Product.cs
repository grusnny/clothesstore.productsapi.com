using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Clothesstore.Entities
{
    public class Product
    {
        [Key]
        public string product_id { get; set; }

        public string name { get; set; }

        public string brand { get; set; }

        public string thumbnail { get; set; }

        public List<FilePath> pictures { get; set; }

        public string description { get; set; }

        public float price { get; set; }

        public float discountPrice { get; set; }

        public float discountPercent => (float)(price - ((price * discountPrice) / 100));

        [ForeignKey("City")]
        public string city_code { get; set; }
        public City city { get; set; }

        [ForeignKey("Seller")]
        public string seller_id { get; set; }
        public Seller seller { get; set; }

        public string currency { get; set; }

        public float rating { get; set; }

    }
}
