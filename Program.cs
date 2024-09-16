using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тестирование работы
            List<Employee> employees = new List<Employee>(6);
            Employee employee0 = new Employee("Кукуев Алекс", "Начальник отдела");
            Employee employee1 = new Employee("Ророноа Зоро", "Охотник на пиратов");
            Worker worker0 = new Worker("Печкин Александр", 1250.0, 158.8);
            Worker worker1 = new Worker("Карапузов Адлет", 1310.5, 155.99);
            Manager manager0 = new Manager("Робинзон Дутов", 434343.0, 3499.09);
            Manager manager1 = new Manager("Попов Павел", 777000.055, 5847.76);
            //добавляем сотрудников
            employees.Add(employee0);
            employees.Add(employee1);
            employees.Add(worker0);
            employees.Add(worker1);
            employees.Add(manager0);
            employees.Add(manager1);
            //проверяем метод расчета зарплаты
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} имеет зарплату {employee.salaryСalculation()}.");
            }
        }
    }
}
