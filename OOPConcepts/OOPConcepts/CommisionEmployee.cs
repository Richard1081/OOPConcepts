using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    public class CommisionEmployee : Employee
    {
        public float CommisionPercentaje { get; set; }
        
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommisionPercentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t"+
                   $"Commision percentaje: {CommisionPercentaje:P2}\n\t"+
                   $"Sales...............: {Sales:C2}\n\t"+
                   $"Value to pay........: {GetValueToPay():C2}\n\t";
        }
    }
}
