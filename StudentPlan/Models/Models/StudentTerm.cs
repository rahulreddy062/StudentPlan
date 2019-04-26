
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace StudentPlan.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermId{ get; set; }

        // public int StudentId { get; set;}
        public int Term { get; set; }
        //public DegreePlan DegreePlan { get; set; }

       
      

        [Required]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "Abbreviation")]
        public string TermAbbr { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "Name")]
        public string  TermName {get; set ;}

        public int NoOfCoursesTaken{get; set;}

        public int DegreePlanId { get; set; }

        //public Student Student { get; set; }
        public DegreePlan DegreePlan { get; set; }

        public ICollection<Slot> Slots { get; set; }
        public ICollection<Credit> Credits { get; set; }


    }
}