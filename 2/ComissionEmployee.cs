using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class ComissionEmployee
    {
        public float ComissionPorcentage { get; set; }
        public decimal Sales { get; set; }

        public decimal GetValueToPay()
        {
            return Sales * (decimal)ComissionPorcentage / 100;

        }


        public override string ToString()
        {
            return $" this is the comision :{ComissionPorcentage}  this are the sales{Sales :c2}  this is the comission : {GetValueToPay()}   ";
        }
  
    }
}
