using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsServer.Models
{
    public class DB
    {
        public static List<Student> studentsList = new List<Student>
        {
            new Student{ id= 1, firstName= "a", lastName= "bbb",
            Gender=Gender.Female,BirthDate=new DateTime(2000,10,15),
                RegistrationDate=new DateTime(2020,01,01),StudentId="323245454" },
             new Student{ id= 2, firstName= "b", lastName= "aaa",
            Gender=Gender.Male,BirthDate=new DateTime(2001,01,01),
                RegistrationDate=new DateTime(2021,01,01),StudentId="454532323" }
        };
    }
}
