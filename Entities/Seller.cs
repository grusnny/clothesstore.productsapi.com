using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clothesstore.Entities
{
    public class Seller
    {
        [Key]
        public string seller_id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }

    }
}
