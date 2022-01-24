﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstdemo3.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Location { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
