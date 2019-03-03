using System;
using System.Collection.Generic;


namespace StudentPlan.Models
{
    public class Credit{
        public int CreditID { get; set; }
        public string CreditAbb { get; set; }
        public string CreditName { get; set; }
        public int ISSummer { get; set; }
        public int ISSpring { get; set; }
        public int ISFall { get; set ;}
    }
}