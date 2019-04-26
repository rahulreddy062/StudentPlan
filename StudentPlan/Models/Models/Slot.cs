using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPlan.Models
{
    public class Slot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotId { get; set; }

        [ForeignKey("DegreePlanId")]
        public int DegreePlanId{ get; set;}

        public int DegreeTerm { get; set; }

        public int CreditId {get; set; }

        [Required]
        [StringLength(8, MinimumLength = 1)]
        [Display(Name = "Status")]
        public string Status{ get; set; }

        public DegreePlan DegreePlan { get; set; }
        public Credit Credit { get; set; }
        public StudentTerm StudentTerm { get; set; }   

    }
}
