﻿using CleanArchitecture.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.AppEntities
{
    public class Company : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string IdentityNumber { get; set; }
        public string TaxDepartment { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
