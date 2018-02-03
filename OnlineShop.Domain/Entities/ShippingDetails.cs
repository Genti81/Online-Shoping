using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter an address")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Enter a city name")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter a place(ort) with zip")]
        public string Place { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Enter a country name")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
