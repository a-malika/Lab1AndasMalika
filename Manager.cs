using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    //Класс Manager:
    public class Manager : Employee
    {
        public double FixedPrice { get; set; }
        public double Bonus { get; set; }
        public Manager(string name, double fixedPrice, double bonus) : base(name, "Менеджер")
        {
            FixedPrice = fixedPrice;
            Bonus = bonus;
        }
        public override double salaryСalculation()
        {
            return FixedPrice + Bonus;
        }
    }
}
