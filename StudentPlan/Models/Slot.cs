using System;
using System.Collection.Generic;


namespace StudentPlan.Models
{
    public class Slot
    {
        public int SlotID { get; set; }
        public int DegreePlanID{ get; set;}
        public string CreditID {get; set; }
        public string Status{ get; set; }
        public int  DegreeTerm{get; set ;}


    }
}
