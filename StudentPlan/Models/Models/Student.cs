using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace StudentPlan.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId{ get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "Family")]
        public string Family { get; set;}

        [Required]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "Given")]
        public string Given{ get; set; }

        public string Snumber{get; set;}
        public int Number919{ get; set; }

        public ICollection<DegreePlan> DegreePlans { get; set; }
        public ICollection<StudentTerm> StudentTerms { get; set; }
    }
}
