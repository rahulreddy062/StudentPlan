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
                new Degree { DegreeID=1,DegreeAbbr="ACS+2",  DegreeName ="MS ACS+2"},
                new Degree { DegreeID=2,DegreeAbbr="ACS+DB", DegreeName ="MS ACS+DB"},
                     new Degree { DegreeID=3,DegreeAbbr="ACS+NF", DegreeName ="MS ACS+NF"},
                     new Degree { DegreeID=4,DegreeAbbr="ACS", DegreeName ="ACS"}

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
             new Credit{CreditID =460 , CreditAbv ="DB" , CreditName ="Database" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =356 , CreditAbv ="NF" , CreditName ="Network Fundamentals" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =542 , CreditAbv ="542" , CreditName ="OOP" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =563 , CreditAbv ="563" , CreditName ="Web Apps ", IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =560 , CreditAbv ="560 ", CreditName ="Advanced Databases" , IsSummer =1, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =664 , CreditAbv ="664-UX" , CreditName ="User Experince Design" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =618 , CreditAbv ="618-PM ", CreditName ="ProjectManagement" , IsSummer =1, IsSpring =0 , IsFall = 0},
             new Credit{CreditID =555 , CreditAbv ="555-NS" , CreditName ="Network Security" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =691 , CreditAbv ="691-GDP1" , CreditName ="GDP1" , IsSummer =1, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =692 , CreditAbv ="692-GDP2 ", CreditName ="GDP2" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =64 , CreditAbv ="Mobile" , CreditName ="643 or 644 Mobile" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =10 , CreditAbv ="E1" , CreditName ="Elective1" , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =20 , CreditAbv ="E2" , CreditName ="Elective2" , IsSummer =0, IsSpring =1 , IsFall = 1},
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
                new Student { StudentID= "S533620",     Family ="Devineni", Given="Sandeep" , Snumber ="S533620" , Number919 = 919572432
                },
                    new Student { StudentID= "S533901",     Family ="Dayam", Given="Rahul" , Snumber ="S533901" , Number919 = 919571516
                    },
                    new Student { StudentID= "S533978",     Family ="Vagicherla", Given="Sampath" , Snumber ="S533978" , Number919 = 919575632
                    },
                    new Student { StudentID= "S533979",     Family ="Veeramachaneni", Given="Subhash" , Snumber ="S533979" , Number919 = 919570258
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
        new DegreeRequirement{ID=1 ,  DegreeID=2 ,CreditID=460},
        new DegreeRequirement{ID=2,  DegreeID=2 ,CreditID=542},
        new DegreeRequirement{ID=3,  DegreeID=2 ,CreditID=563},
        new DegreeRequirement{ID=4,  DegreeID=2 ,CreditID=560},
        new DegreeRequirement{ID=5,  DegreeID=2 ,CreditID=664},
        new DegreeRequirement{ID=6,  DegreeID=2 ,CreditID=618},
        new DegreeRequirement{ID= 7,  DegreeID=2 ,CreditID=555},
        new DegreeRequirement{ID=8,  DegreeID=2 ,CreditID=691},
        new DegreeRequirement{ID=9,  DegreeID=2 ,CreditID=692},
        new DegreeRequirement{ID=10,  DegreeID=2 ,CreditID=64},
        new DegreeRequirement{ID=11,  DegreeID=2 ,CreditID=10},
        new DegreeRequirement{ID=12,  DegreeID=2 ,CreditID=20},


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
new DegreePlan{DegreePlanID=7251 ,  StudentID=533901 ,DegreePlanAbbrev="Super Fast" ,DegreePlanName="As fast as I can ",DegreeID=2},
new DegreePlan{DegreePlanID=7252 ,  StudentID=533901 ,DegreePlanAbbrev="Slow and Easy" ,DegreePlanName="Take a summer off",DegreeID=2},
new DegreePlan{DegreePlanID=7253 ,  StudentID=533620 ,DegreePlanAbbrev="Super Fast" ,DegreePlanName="As fast as I can" ,DegreeID=2},
new DegreePlan{DegreePlanID=7254 ,  StudentID=533620 ,DegreePlanAbbrev="Slow and Easy" ,DegreePlanName="Take a summer off" ,DegreeID=2},
new DegreePlan{DegreePlanID=7255 ,  StudentID=533979 ,DegreePlanAbbrev="Super Fast" ,DegreePlanName="As fast as I can" ,DegreeID=2},
new DegreePlan{DegreePlanID=7256 ,  StudentID=533979 ,DegreePlanAbbrev="Slow and Easy" ,DegreePlanName="Take a summer off",DegreeID=2},
new DegreePlan{DegreePlanID=7257 ,  StudentID=533978 ,DegreePlanAbbrev="Super Fast" ,DegreePlanName="As fast as I can ",DegreeID=2},
new DegreePlan{DegreePlanID=7258 ,  StudentID=533978 ,DegreePlanAbbrev="Slow and Easy"  ,DegreePlanName="Take a summer off",DegreeID=2},

                };

                foreach (DegreePlan ci in degreeplans)
                {
                    context.DegreePlans.Add(ci);
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
new  StudentTerm{StudentTermID =1 , StudentID ="S533725", DegreePlanID =7251 , Term =1, TermAbbr ="F18" , TermName =" Fall2018", NoOfCoursesTaken = 4},
new  StudentTerm{StudentTermID =2 , StudentID ="S533725", DegreePlanID =7251 , Term =2, TermAbbr ="s19 ", TermName = "Spring2019", NoOfCoursesTaken = 3},
new  StudentTerm{StudentTermID =3 , StudentID ="S533725" , DegreePlanID =7251 , Term =3, TermAbbr ="Su19" , TermName = "Summer2019",NoOfCoursesTaken = 0},
new  StudentTerm{StudentTermID =4 , StudentID ="S533725" , DegreePlanID =7251 , Term =4, TermAbbr ="F19" , TermName = "Fall2019",NoOfCoursesTaken = 3},
new  StudentTerm{StudentTermID =5 , StudentID ="S533725" , DegreePlanID =7251 , Term =5, TermAbbr ="s20" , TermName =" Spring2020",NoOfCoursesTaken = 2},
new  StudentTerm{StudentTermID =6 , StudentID ="S534049" , DegreePlanID =7253 , Term =1, TermAbbr ="F19 ", TermName = "Fall2019",NoOfCoursesTaken = 4},
new  StudentTerm{StudentTermID =7 , StudentID ="S534049" , DegreePlanID =7253 , Term =2, TermAbbr ="s20 ", TermName = "Spring2020",NoOfCoursesTaken = 3},
new  StudentTerm{StudentTermID =8 , StudentID ="S534049" , DegreePlanID =7253 , Term =3, TermAbbr ="Su20" , TermName = "Summer2020",NoOfCoursesTaken = 2},
new  StudentTerm{StudentTermID =9 , StudentID ="S534049", DegreePlanID =7253 , Term =4, TermAbbr ="F20 ", TermName =" Fall2020",NoOfCoursesTaken = 2},
new  StudentTerm{StudentTermID =10 , StudentID ="S534049", DegreePlanID =7253 , Term =5, TermAbbr ="S21" , TermName = "Spring2021",NoOfCoursesTaken = 2},
new  StudentTerm{StudentTermID =11 , StudentID ="S533726" , DegreePlanID =7254 , Term =1, TermAbbr ="S19" , TermName = "Spring2019",NoOfCoursesTaken = 4},
new  StudentTerm{StudentTermID =12 , StudentID = "S533726" , DegreePlanID =7254 , Term =2, TermAbbr ="Su19" , TermName = "Summer2019",NoOfCoursesTaken = 0},
new  StudentTerm{StudentTermID =13 , StudentID ="S533726"  , DegreePlanID =7254 , Term =3, TermAbbr ="F19" , TermName = "Fall2019",NoOfCoursesTaken = 3},
new  StudentTerm{StudentTermID =14 , StudentID ="S533726" , DegreePlanID =7254 , Term =4, TermAbbr ="S20" , TermName = "Spring2020",NoOfCoursesTaken = 3},
new  StudentTerm{StudentTermID =15 , StudentID ="S533726"  , DegreePlanID =7254 , Term =5, TermAbbr ="Su20 ", TermName = "Summer2020",NoOfCoursesTaken = 3},

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

