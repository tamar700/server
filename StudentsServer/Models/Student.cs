using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsServer.Models
{
    public enum Gender { Male,Female }
    public class Student
    {
        public int id { get; set; }

        public String StudentId { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime RegistrationDate { get; set; }

        public Gender Gender { get; set; }

    }
}
