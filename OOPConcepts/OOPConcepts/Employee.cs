﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    public  abstract class Employee
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public Date? BirthDate { get; set; }
        
        public Date? HiringDate { get; set; }
        
        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id}\t{FirstName} {LastName}\n\t" +
                   $"Birth day...........: {BirthDate}\n\t" +
                   $"Hiring day..........: {HiringDate}\n\t"+
                   $"Is active...........: {IsActive}";
        }
    }
}
