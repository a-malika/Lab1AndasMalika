using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    //Класс Worker:
    public class Worker : Employee
    {
        public double RatePerHour { get; set; }
        public double Hours { get; set; }
        public Worker(string name, double ratePerHour, double hours) : base(name, "Работник")
        {
            RatePerHour = ratePerHour;
            Hours = hours;
        }
        public override double salaryСalculation()
        {
            return RatePerHour * Hours;
        }
    }
}
