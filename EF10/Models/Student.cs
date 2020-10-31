using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF10.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string studentName { get; set; }

        public int departmentID { get; set; }

        public Department department { get; set; }
    }
}
