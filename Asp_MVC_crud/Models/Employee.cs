﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp_MVC_crud.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}