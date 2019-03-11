using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlan.Models
{
    public class Degree
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeID{ get; set; }
        public string DegreeAbbr{ get; set;}
        public string DegreeName { get; set; }
        
    }
}
