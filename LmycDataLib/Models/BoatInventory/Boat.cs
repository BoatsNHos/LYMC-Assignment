using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using LmycDataLib.Models;

namespace LmycDataLib.Models.BoatInventory
{
    public class Boat
    {
        [Key]
        public int BoatId { get; set; }
        public string BoatName { get; set; }
        public string Picture { get; set; }
        public int LengthInFeet { get; set; }
        public string Make { get; set; }
        public string Year { get; set; }
        public string Record { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; }
        [ForeignKey("User")]
        public string CreatedBy { get; set; }
        public ApplicationUser User { get; set; }
    }
}