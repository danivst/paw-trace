using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class LostAnimal
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public Gender Gender { get; set; }

        public string Color { get; set; }

        [Required]
        public Location Location { get; set; }

        [Required]
        public DateOnly DateLost { get; set; }

        [Required]
        public PetType Species { get; set; }

        [Required]
        public StatusType Status { get; set; }

        [Range(1, 99)]
        public int Age { get; set; }

        [StringLength(50)]
        public string? Breed { get; set; }

        [Range(0, 200)]
        public string? Description { get; set; }

        public byte[]? Image { get; set; }

        public override string ToString()
        {
            return $"{Id}.\n" + 
                   $"Name: {Name}\n" +
                   $"Age: {(Age == 0 ? "-" : Age.ToString())}\n" +
                   $"Gender: {Gender}\n" +
                   $"Color: {Color}\n" +
                   $"Location: {Location}\n" +
                   $"Date lost: {DateLost}\n" +
                   $"Species: {Species}\n" +
                   $"Breed: {(string.IsNullOrWhiteSpace(Breed) ? "-" : Breed)}\n" +
                   $"Description: {(string.IsNullOrWhiteSpace(Description) ? "-" : Description)}";
        }
    }
}
