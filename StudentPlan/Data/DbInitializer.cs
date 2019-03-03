using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ContosoUniversity.Models;

namespace StudentPlan.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any students.
            if (context.Degreess.Any())
            {
                Console.WriteLine("Degree already exist");   // DB has been seeded
            }

            var degrees = new Degree[]
            {
                new Degree { DegreeID=1,DegreeAbbr=" ACS+2",
                    DegreeName ="MS ACS+2"},
                new Degree { DegreeID=2,DegreeAbbr=" ACS+DB",
                    DegreeName ="MS ACS+DB"},
                     new Degree { DegreeID=1,DegreeAbbr=" ACS+NF",
                    DegreeName ="MS ACS+NF"},
                     new Degree { DegreeID=1,DegreeAbbr=" ACS",
                    DegreeName ="ACS"},
               
            };
            Console.WriteLine($"Inserted {degrees.Length} new degrees.");

            foreach (Degree in degrees)
            {
                context.Degrees.Add(s);
            }
            context.SaveChanges();

            var credits = new Credit[]
            {
             new Credit{CreditID =460 , CreditAbv =DB , CreditName =Database , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =356 , CreditAbv =NF , CreditName =Network Fundamentals , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =542 , CreditAbv =542 , CreditName =OOP , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =563 , CreditAbv =563 , CreditName =Web Apps , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =560 , CreditAbv =560 , CreditName =Advanced Databases , IsSummer =1, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =664 , CreditAbv =664-UX , CreditName =User Experince Design , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =618 , CreditAbv =618-PM , CreditName =ProjectManagement , IsSummer =1, IsSpring =0 , IsFall = 0},
             new Credit{CreditID =555 , CreditAbv =555-NS , CreditName =Network Security , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =691 , CreditAbv =691-GDP1 , CreditName =GDP1 , IsSummer =1, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =692 , CreditAbv =692-GDP2 , CreditName =GDP2 , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =64 , CreditAbv =Mobile , CreditName =643 or 644 Mobile , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =10 , CreditAbv =E1 , CreditName =Elective1 , IsSummer =0, IsSpring =1 , IsFall = 1},
             new Credit{CreditID =20 , CreditAbv =E2 , CreditName =Elective2 , IsSummer =0, IsSpring =1 , IsFall = 1},
            };

            foreach (Credit i in credits)
            {
                context.credits.Add(i);
            }
            context.SaveChanges();

            var students = new Student[]
            {
                new Student { StudentID= "S533620",     Family ="Devineni", Given="Sandeep" , Snumber ="S533620" , 919 = 919572432,
                    ),
                    new Student { StudentID= "S533901",     Family ="Dayam", Given="Rahul" , Snumber ="S533901" , 919 = 919571516,
                    ),
                    new Student { StudentID= "S533978",     Family ="Vagicherla", Given="Sampath" , Snumber ="S533978" , 919 = 919575632,
                    ),
                    new Student { StudentID= "S533979",     Family ="Veeramachaneni", Given="Subhash" , Snumber ="S533979" , 919 = 919570258,
                    ),
                    
                 
            };

            foreach (Student d in Students)
            {
                context.Students.Add(d);
            }
            context.SaveChanges();

            var degreerequirements = new DegreeRequirement[]
            {
        new DegreeRequirement{DegreeCreditID=1 ,  DegreeID=2 ,CreditID=460},
        new DegreeRequirement{DegreeCreditID=2,  DegreeID=2 ,CreditID=542},
        new DegreeRequirement{DegreeCreditID=2,  DegreeID=2 ,CreditID=563},
        new DegreeRequirement{DegreeCreditID=2,  DegreeID=2 ,CreditID=560},
        new DegreeRequirement{DegreeCreditID=2,  DegreeID=2 ,CreditID=664},
        new DegreeRequirement{DegreeCreditID=2,  DegreeID=2 ,CreditID=618},
        new DegreeRequirement{DegreeCreditID= 2,  DegreeID=2 ,CreditID=555},
        new DegreeRequirement{DegreeCreditID=2,  DegreeID=2 ,CreditID=691},
        new DegreeRequirement{DegreeCreditID=2,  DegreeID=2 ,CreditID=692},
        new DegreeRequirement{DegreeCreditID=2,  DegreeID=2 ,CreditID=64},
        new DegreeRequirement{DegreeCreditID=2,  DegreeID=2 ,CreditID=10},
        new DegreeRequirement{DegreeCreditID=2,  DegreeID=2 ,CreditID=20},


            };

            foreach (DegreeRequirement c in degreerequirements)
            {
                context.DegreeRequirements.Add(c);
            }
            context.SaveChanges();
            var degreeplans = new DegreePlan[]
            {
new DegreePlan{DegreePlanID=7251 ,  StudentID=533901 ,DegreePlanAbbrev=Super Fast ,DegreePlanName=As fast as I can ,DegreeID=2},
new DegreePlan{DegreePlanID=7252 ,  StudentID=533901 ,DegreePlanAbbrev=Slow and Easy ,DegreePlanName=Take a summer off,DegreeID=2},
new DegreePlan{DegreePlanID=7253 ,  StudentID=533620 ,DegreePlanAbbrev=Super Fast ,DegreePlanName=As fast as I can ,DegreeID=2},
new DegreePlan{DegreePlanID=7254 ,  StudentID=533620 ,DegreePlanAbbrev=Slow and Easy ,DegreePlanName=Take a summer off ,DegreeID=2},
new DegreePlan{DegreePlanID=7255 ,  StudentID=533979 ,DegreePlanAbbrev=Super Fast ,DegreePlanName=As fast as I can ,DegreeID=2},
new DegreePlan{DegreePlanID=7256 ,  StudentID=533979 ,DegreePlanAbbrev=Slow and Easy ,DegreePlanName=Take a summer off,DegreeID=2},
new DegreePlan{DegreePlanID=7257 ,  StudentID=533978 ,DegreePlanAbbrev=Super Fast ,DegreePlanName=As fast as I can ,DegreeID=2},
new DegreePlan{DegreePlanID=7258 ,  StudentID=533978 ,DegreePlanAbbrev=Slow and Easy  ,DegreePlanName=Take a summer off,DegreeID=2},

            };

            foreach (DegreePlan ci in degreeplans)
            {
                context.DegreePlans.Add(ci);
            }
            context.SaveChanges();

            var studentterms = new StudentTerm[]
            {
new  StudentTerm{StudentTermID =1 , StudentID =533725 , DegreePlanID =7251 , Term =1, TermAbbr =F18 , TermName = Fall2018,No.OfCoursesTaken = 4},
new  StudentTerm{StudentTermID =2 , StudentID =533725 , DegreePlanID =7251 , Term =2, TermAbbr =s19 , TermName = Spring2019,No.OfCoursesTaken = 3},
new  StudentTerm{StudentTermID =3 , StudentID =533725 , DegreePlanID =7251 , Term =3, TermAbbr =Su19 , TermName = Summer2019,No.OfCoursesTaken = 0},
new  StudentTerm{StudentTermID =4 , StudentID =533725 , DegreePlanID =7251 , Term =4, TermAbbr =F19 , TermName = Fall2019,No.OfCoursesTaken = 3},
new  StudentTerm{StudentTermID =5 , StudentID =533725 , DegreePlanID =7251 , Term =5, TermAbbr =s20 , TermName = Spring2020,No.OfCoursesTaken = 2},
new  StudentTerm{StudentTermID =6 , StudentID =534049 , DegreePlanID =7253 , Term =1, TermAbbr =F19 , TermName = Fall2019,No.OfCoursesTaken = 4},
new  StudentTerm{StudentTermID =7 , StudentID =534049 , DegreePlanID =7253 , Term =2, TermAbbr =s20 , TermName = Spring2020,No.OfCoursesTaken = 3},
new  StudentTerm{StudentTermID =8 , StudentID =534049 , DegreePlanID =7253 , Term =3, TermAbbr =Su20 , TermName = Summer2020,No.OfCoursesTaken = 2},
new  StudentTerm{StudentTermID =9 , StudentID =534049 , DegreePlanID =7253 , Term =4, TermAbbr =F20 , TermName = Fall2020,No.OfCoursesTaken = 2},
new  StudentTerm{StudentTermID =10 , StudentID =534049 , DegreePlanID =7253 , Term =5, TermAbbr =S21 , TermName = Spring2021,No.OfCoursesTaken = 2},
new  StudentTerm{StudentTermID =11 , StudentID =533726 , DegreePlanID =7254 , Term =1, TermAbbr =S19 , TermName = Spring2019,No.OfCoursesTaken = 4},
new  StudentTerm{StudentTermID =12 , StudentID =533726 , DegreePlanID =7254 , Term =2, TermAbbr =Su19 , TermName = Summer2019,No.OfCoursesTaken = 0},
new  StudentTerm{StudentTermID =13 , StudentID =533726 , DegreePlanID =7254 , Term =3, TermAbbr =F19 , TermName = Fall2019,No.OfCoursesTaken = 3},
new  StudentTerm{StudentTermID =14 , StudentID =533726 , DegreePlanID =7254 , Term =4, TermAbbr =S20 , TermName = Spring2020,No.OfCoursesTaken = 3},
new  StudentTerm{StudentTermID =15 , StudentID =533726 , DegreePlanID =7254 , Term =5, TermAbbr =Su20 , TermName = Summer2020,No.OfCoursesTaken = 3},

            };

            foreach (StudentTerm e in studentterms)
            {
                
                    context.StudentTerms.Add(e);
            }
            context.SaveChanges();
            
    }
}