using System.ComponentModel.DataAnnotations;

namespace mvcICE4.Models
{
    public class PetInformation
    {
        public int Id { get; set; }

        [Display(Name = "Pet Name")]
        public required string Name { get; set; }
        [Display(Name = "Pet Image")]
        public required string PetImage { get; set; }

        [Display(Name = "Pet Age")]
        public int Age { get; set; }

        [Display(Name = "Pet Breed")]
        public required string Breed { get; set; }

        [Display(Name = "Adoption Status")]
        public bool AdoptionStatus { get; set; }
    }
}
