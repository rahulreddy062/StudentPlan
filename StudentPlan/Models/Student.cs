using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlan.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string StudentID{ get; set; }
        public string Family { get; set;}
        public string Given{ get; set; }
        public string Snumber{get; set;}
        public int Number919{ get; set; }
    }
}
