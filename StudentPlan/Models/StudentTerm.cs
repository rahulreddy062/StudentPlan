using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlan.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermID{ get; set; }
        public string StudentID { get; set;}
        public int DegreePlanID{get; set;}
        public int Term{ get; set; }
        public string TermAbbr { get; set; }
        public string  TermName {get; set ;}
        public int NoOfCoursesTaken{get; set;}


    }
}