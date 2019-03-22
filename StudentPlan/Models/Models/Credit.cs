using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StudentPlan.Models
{
    public class Credit{
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Requirement Id")]
        public int CreditId { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Abbreviation")]
        public string CreditAbv { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Name")]
        public string CreditName { get; set; }

        [Display(Name = "Is Offered in Summer?")]
        public int IsSummer { get; set; } = 1;

        [Display(Name = "In Spring?")]
        public int IsSpring { get; set; } = 1;

        [Display(Name = "In Fall?")]
        public int IsFall { get; set; } = 1;
    }
}