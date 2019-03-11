using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlan.Models
{
    public class DegreeRequirement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID{ get; set;}
        public int DegreeID{ get; set; }
       public int CreditID{get; set;}
    }
}
