using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF12.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string studentName { get; set; }
        public int departmentID { get; set; }

        public List<Department> departments { get; set; }
    }
}
