﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exam3.Models
{
    public class Employee
    {
        [Key]
        public long StudentId{ get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string PhoneNumber{ get; set; }
        public string Email{ get; set; }
    }
}
