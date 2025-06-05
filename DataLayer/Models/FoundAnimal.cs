using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class FoundAnimal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }

        [Required]
        public DateOnly DateFound { get; set; }

        [Required]
        public PetType Species { get; set; }

        [Required]
        public StatusType Status { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Range(1, 99)]
        public int Age { get; set; }

        [StringLength(50)]
        public string Breed { get; set; }

        [Range(0, 200)]
        public int Description { get; set; }

        public byte[] Image { get; set; }
    }
}
