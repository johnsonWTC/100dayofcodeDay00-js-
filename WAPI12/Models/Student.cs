﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAPI12.Models
{
    public class Student
    {
        public int studentID { get; set; }

        public string studentName { get; set; }

        public int FacultyID { get; set; }
        public Faculty faculty { get; set; }
    }
}
