using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlan.Models
{
    public class DegreeRequirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set;}

        [ForeignKey("DegreeId")]
        public int DegreeId{ get; set; }

        [ForeignKey("CreditId")]
        public int CreditId{get; set;}

        public Degree Degree { get; set; }
        public Credit Credit { get; set; }
    }
}
