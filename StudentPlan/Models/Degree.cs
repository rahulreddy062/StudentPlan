using System;
using System.Collection.Generic;


namespace StudentPlan.Models
{
    public class Degree
    {
        public int DegreeID{ get; set; }
        public string DegreeAbbreviation { get; set;}
        public string DegreeName { get; set; }
        public int NumberOfTerms { get; set; }
    }
}
