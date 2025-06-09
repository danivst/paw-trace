using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string City { get; set; }

        [Required]
        [StringLength(20)]
        public string Country { get; set; }

        public Location(string city, string country)
        {
            City = city;
            Country = country;
        }

        public override string ToString()
        {
            return $"{City}, {Country}";
        }
    }
}