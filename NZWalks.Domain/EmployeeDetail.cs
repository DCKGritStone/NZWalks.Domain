﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Domain
{
    
    public class EmployeeDetail
    {
        public int Id { get; set; }
        public string? Name { get; set; }    
        public string? Address { get; set; }

        public string? Designation { get; set; }
        public double Salary { get; set; }
        public string? Email { get; set; }

        public string? Phone { get; set; }

    }
}
