﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        public string name { get; set; }
        public bool IsActive { get; set; }        
    }
}