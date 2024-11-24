using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples
{
    public class Student
    {
        public int Id { get; set; } // Primary Key
        public string ?  Name { get; set; } // Student Name
        public int Age { get; set; } // Student Age
        public double CGPA { get; set; } // Student CGPA
    }
}
