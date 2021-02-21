using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clothesstore.Entities
{
    public class City
    {
        [Key]
        public string name { get; set; }

        public string city_code { get; set; }

    }
}
