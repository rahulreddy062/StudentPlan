using System;
using System.Collection.Generic;


namespace StudentPlan.Models
{
    public class DegreePlan
    {
        public int DegreePlanID{ get; set; }
        public int StudentID{ get; set;}
        public string DegreePlanAbbrev { get; set; }
        public string DegreePlanName{get; set;}
        public int DegreeID { get; set; }
    }
}
