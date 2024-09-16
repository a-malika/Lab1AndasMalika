using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    //Класс Employee
    public class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Position { get; set; }
        private static int id_counter = 0;
        public Employee(string name, string position)
        {
            Name = name;
            ID = id_counter++;
            Position = position;
        }
        public virtual double salaryСalculation()
        {
            return 200000.0;
        }
    }
}
