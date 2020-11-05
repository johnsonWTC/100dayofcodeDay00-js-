using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF13.Models
{
    public class Student
    {
        public int  studentID  { get; set; }
        public string studentName { get; set; }

        public int roomNumberID { get; set; }

        public RoomNumber roomNumber  { get; set; }


    }
}
