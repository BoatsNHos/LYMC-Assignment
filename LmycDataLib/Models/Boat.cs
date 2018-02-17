using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmycDataLib.Models
{
    public class Boat
    {
        [Key]
        public int BoatId { get; set; }

        [Required(ErrorMessage = "A name is required")]
        [Display(Name = "Name")]
        public string BoatName { get; set; }

        [Required(ErrorMessage = "A picture url is required")]
        public string Picture { get; set; }
        [Required(ErrorMessage = "Length is required")]
        [Display(Name = "Length In Feet")]
        public int LengthInFeet { get; set; }

        [Required(ErrorMessage = "A make is required")]
        public string Make { get; set; }

        [Required(ErrorMessage = "A year is required")]
        public string Year { get; set; }

        [Required(ErrorMessage = "A record is required")]
        public string Record { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Register Date")]
        public DateTime CreationDate { get; set; }

        [ForeignKey("User")]
        [ScaffoldColumn(false)]
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public ApplicationUser User { get; set; }
    }
}
