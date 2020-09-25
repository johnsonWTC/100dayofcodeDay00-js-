using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebAPI4.Models
{
    public class EmployeeModel
    {
        public int Empid { get; set; }
        public string EmName { get; set; }
        public string Empemail { get; set; }
        public string Emplocation { get; set; }
        public string Empdesgnation { get; set; }

    }
}