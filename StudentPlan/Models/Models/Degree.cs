using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlan.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Degree ID")]
        public int DegreeId{ get; set; }

        [Required]
        [StringLength(6, MinimumLength = 3)]
        [Display(Name = "Abbreviation")]
        public string DegreeAbbr{ get; set;}

        [Required]
        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Name")]
        public string DegreeName { get; set; }
        public ICollection<Credit> Credits { get; set; }

    }
}
