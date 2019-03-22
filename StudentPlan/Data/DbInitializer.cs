using System;
using System.Linq;
using StudentPlan.Models;

namespace StudentPlan.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any students.
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degree already exist");   // DB has been seeded
            }
            else
            {
                var degrees = new Degree[]
                {
                new Degree { DegreeId=1,DegreeAbbr="ACS+2",  DegreeName ="MS ACS+2"},
                new Degree { DegreeId=2,DegreeAbbr="ACS+DB", DegreeName ="MS ACS+DB"},
                     new Degree { DegreeId=3,DegreeAbbr="ACS+NF", DegreeName ="MS ACS+NF"},
                     new Degree { DegreeId=4,DegreeAbbr="ACS", DegreeName ="ACS"}

                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");

                foreach (Degree s in degrees)
                {
                    context.Degrees.Add(s);
                }
                context.SaveChanges();
            }



            if (context.Credits.Any())
            {
                Console.WriteLine("Degree already exist");   // DB has been seeded
            }
            else
            {
                var credits = new Credit[]
                {
             new Credit{CreditId =460 , CreditAbv ="DB" , CreditName ="Database" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditId =356 , CreditAbv ="NF" , CreditName ="Network Fundamentals" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditId =542 , CreditAbv ="542" , CreditName ="OOP" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditId =563 , CreditAbv ="563" , CreditName ="Web Apps ", IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditId =560 , CreditAbv ="560 ", CreditName ="Advanced Databases" , IsSummer =1, IsSpring =1 , IsFall = 1},
             new Credit{CreditId =664 , CreditAbv ="664-UX" , CreditName ="User Experince Design" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditId =618 , CreditAbv ="618-PM ", CreditName ="ProjectManagement" , IsSummer =1, IsSpring =0 , IsFall = 0},
             new Credit{CreditId =555 , CreditAbv ="555-NS" , CreditName ="Network Security" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditId =691 , CreditAbv ="691-GDP1" , CreditName ="GDP1" , IsSummer =1, IsSpring =1 , IsFall = 1},
             new Credit{CreditId =692 , CreditAbv ="692-GDP2 ", CreditName ="GDP2" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditId =64 , CreditAbv ="Mobile" , CreditName ="643 or 644 Mobile" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditId =10 , CreditAbv ="E1" , CreditName ="Elective1" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditId =20 , CreditAbv ="E2" , CreditName ="Elective2" , IsSummer =0, IsSpring =1 , IsFall = 1},
                };

                foreach (Credit i in credits)
                {
                    context.Credits.Add(i);
                }
                context.SaveChanges();
            }



            if (context.Students.Any())
            {
                Console.WriteLine("Degree already exist");   // DB has been seeded
            }
            else
            {
                var students = new Student[]
                {
                new Student { StudentId= 533620,     Family ="Devineni", Given="Sandeep" , Snumber ="S533620" , Number919 = 919572432
                },
                    new Student { StudentId= 533901,     Family ="Dayam", Given="Rahul" , Snumber ="S533901" , Number919 = 919571516
                    },
                    new Student { StudentId= 533978,     Family ="Vagicherla", Given="Sampath" , Snumber ="S533978" , Number919 = 919575632
                    },
                    new Student { StudentId= 533979,     Family ="Veeramachaneni", Given="Subhash" , Snumber ="S533979" , Number919 = 919570258
                    },


                };

                foreach (Student d in students)
                {
                    context.Students.Add(d);
                }
                context.SaveChanges();
            }


            if (context.DegreeRequirements.Any())
            {
                Console.WriteLine("Degree already exist");   // DB has been seeded
            }
            else
            {
                var degreerequirements = new DegreeRequirement[]
                {
        new DegreeRequirement{Id=1 ,  DegreeId=2 ,CreditId=460},
        new DegreeRequirement{Id=2,  DegreeId=2 ,CreditId=542},
        new DegreeRequirement{Id=3,  DegreeId=2 ,CreditId=563},
        new DegreeRequirement{Id=4,  DegreeId=2 ,CreditId=560},
        new DegreeRequirement{Id=5,  DegreeId=2 ,CreditId=664},
        new DegreeRequirement{Id=6,  DegreeId=2 ,CreditId=618},
        new DegreeRequirement{Id= 7,  DegreeId=2 ,CreditId=555},
        new DegreeRequirement{Id=8,  DegreeId=2 ,CreditId=691},
        new DegreeRequirement{Id=9,  DegreeId=2 ,CreditId=692},
        new DegreeRequirement{Id=10,  DegreeId=2 ,CreditId=64},
        new DegreeRequirement{Id=11,  DegreeId=2 ,CreditId=10},
        new DegreeRequirement{Id=12,  DegreeId=2 ,CreditId=20},


                };

                foreach (DegreeRequirement c in degreerequirements)
                {
                    context.DegreeRequirements.Add(c);
                }
                context.SaveChanges();
            }


            if (context.DegreePlans.Any())
            {
                Console.WriteLine("Degree already exist");   // DB has been seeded
            }
            else
            {
                var degreeplans = new DegreePlan[]
                {
new DegreePlan{DegreePlanId=7251 ,  StudentId=533901 ,DegreePlanAbbrev="Super Fast" ,DegreePlanName="As fast as I can ",DegreeId=2},
new DegreePlan{DegreePlanId=7252 ,  StudentId=533901 ,DegreePlanAbbrev="Slow and Easy" ,DegreePlanName="Take a summer off",DegreeId=2},
new DegreePlan{DegreePlanId=7253 ,  StudentId=533620 ,DegreePlanAbbrev="Super Fast" ,DegreePlanName="As fast as I can" ,DegreeId=2},
new DegreePlan{DegreePlanId=7254 ,  StudentId=533620 ,DegreePlanAbbrev="Slow and Easy" ,DegreePlanName="Take a summer off" ,DegreeId=2},
new DegreePlan{DegreePlanId=7255 ,  StudentId=533979 ,DegreePlanAbbrev="Super Fast" ,DegreePlanName="As fast as I can" ,DegreeId=2},
new DegreePlan{DegreePlanId=7256 ,  StudentId=533979 ,DegreePlanAbbrev="Slow and Easy" ,DegreePlanName="Take a summer off",DegreeId=2},
new DegreePlan{DegreePlanId=7257 ,  StudentId=533978 ,DegreePlanAbbrev="Super Fast" ,DegreePlanName="As fast as I can ",DegreeId=2},
new DegreePlan{DegreePlanId=7258 ,  StudentId=533978 ,DegreePlanAbbrev="Slow and Easy"  ,DegreePlanName="Take a summer off",DegreeId=2},

                };

                foreach (DegreePlan ci in degreeplans)
                {
                    context.DegreePlans.Add(ci);
                }
                context.SaveChanges();
            }

            if (context.Slots.Any())
            {
                Console.WriteLine("Slots already exist");   // DB has been seeded
            }
            else
            {
                var slots = new Slot[]
                {


            new Slot { SlotId = 1, DegreePlanId = 7251, DegreeTerm = 1, CreditId = 460, Status = "C" },
new Slot { SlotId = 2, DegreePlanId = 7251, DegreeTerm = 1, CreditId = 542, Status = "C" },
new Slot { SlotId = 3, DegreePlanId = 7251, DegreeTerm = 1, CreditId = 563, Status = "C" },
new Slot { SlotId = 4, DegreePlanId = 7251, DegreeTerm = 2, CreditId = 560, Status = "A" },
new Slot { SlotId = 5, DegreePlanId = 7251, DegreeTerm = 2, CreditId = 64, Status = "A" },
new Slot { SlotId = 6, DegreePlanId = 7251, DegreeTerm = 2, CreditId = 555, Status = "A" },
new Slot { SlotId = 7, DegreePlanId = 7251, DegreeTerm = 3, CreditId = 691, Status = "P" },
new Slot { SlotId = 8, DegreePlanId = 7251, DegreeTerm = 3, CreditId = 10, Status = "P"},
new Slot { SlotId = 9, DegreePlanId = 7251, DegreeTerm = 3, CreditId = 618, Status = "P" },
new Slot { SlotId = 10, DegreePlanId = 7251, DegreeTerm = 4, CreditId = 20, Status = "P" },
new Slot { SlotId = 11, DegreePlanId = 7251, DegreeTerm = 4, CreditId = 692, Status = "P" },
new Slot { SlotId = 12, DegreePlanId = 7251, DegreeTerm = 4, CreditId = 664, Status = "P" },
                };

                foreach (Slot ci in slots)
                {
                    context.Slots.Add(ci);
                }
                context.SaveChanges();
            }



            if (context.StudentTerms.Any())
            {
                Console.WriteLine("Degree already exist");   // DB has been seeded
            }
            else
            {
                var studentterms = new StudentTerm[]
                {
new  StudentTerm{StudentTermId =1 , DegreePlanId =7251 , Term =1, TermAbbr ="F18" , TermName =" Fall2018", NoOfCoursesTaken = 4},
new  StudentTerm{StudentTermId =2 ,  DegreePlanId =7251 , Term =2, TermAbbr ="s19 ", TermName = "Spring2019", NoOfCoursesTaken = 3},
new  StudentTerm{StudentTermId =3 ,  DegreePlanId =7251 , Term =3, TermAbbr ="Su19" , TermName = "Summer2019",NoOfCoursesTaken = 0},
new  StudentTerm{StudentTermId =4 ,  DegreePlanId =7251 , Term =4, TermAbbr ="F19" , TermName = "Fall2019",NoOfCoursesTaken = 3},
new  StudentTerm{StudentTermId =5 ,  DegreePlanId =7251 , Term =5, TermAbbr ="s20" , TermName =" Spring2020",NoOfCoursesTaken = 2},
new  StudentTerm{StudentTermId =6 , DegreePlanId =7253 , Term =1, TermAbbr ="F19 ", TermName = "Fall2019",NoOfCoursesTaken = 4},
new  StudentTerm{StudentTermId =7 ,  DegreePlanId =7253 , Term =2, TermAbbr ="s20 ", TermName = "Spring2020",NoOfCoursesTaken = 3},
new  StudentTerm{StudentTermId =8 ,  DegreePlanId =7253 , Term =3, TermAbbr ="Su20" , TermName = "Summer2020",NoOfCoursesTaken = 2},
new  StudentTerm{StudentTermId =9 ,  DegreePlanId =7253 , Term =4, TermAbbr ="F20 ", TermName =" Fall2020",NoOfCoursesTaken = 2},
new  StudentTerm{StudentTermId =10 ,  DegreePlanId =7253 , Term =5, TermAbbr ="S21" , TermName = "Spring2021",NoOfCoursesTaken = 2},
new  StudentTerm{StudentTermId =11 ,  DegreePlanId =7254 , Term =1, TermAbbr ="S19" , TermName = "Spring2019",NoOfCoursesTaken = 4},
new  StudentTerm{StudentTermId =12 ,  DegreePlanId =7254 , Term =2, TermAbbr ="Su19" , TermName = "Summer2019",NoOfCoursesTaken = 0},
new  StudentTerm{StudentTermId =13 ,  DegreePlanId =7254 , Term =3, TermAbbr ="F19" , TermName = "Fall2019",NoOfCoursesTaken = 3},
new  StudentTerm{StudentTermId =14 ,  DegreePlanId =7254 , Term =4, TermAbbr ="S20" , TermName = "Spring2020",NoOfCoursesTaken = 3},
new  StudentTerm{StudentTermId =15 ,  DegreePlanId =7254 , Term =5, TermAbbr ="Su20 ", TermName = "Summer2020",NoOfCoursesTaken = 3},

                };

                foreach (StudentTerm e in studentterms)
                {

                    context.StudentTerms.Add(e);
                }
                context.SaveChanges();

            }
        }
    }
}

