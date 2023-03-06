using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    public class HourlyEmployee : Employee
    {
        public float Hours { get; set; }

        public decimal HourValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HourValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Hours...............: {Hours:N2}\n\t" +
                   $"Hour value..........: {HourValue:C2}\n\t" +
                   $"Value to pay........: {GetValueToPay():C2}\n\t";
        }
    }
}
