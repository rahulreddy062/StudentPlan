using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlan.Models
{
    public class DegreePlan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanID{ get; set; }
        public int StudentID{ get; set;}
        public string DegreePlanAbbrev { get; set; }
        public string DegreePlanName{get; set;}
        public int DegreeID { get; set; }
    }
}
