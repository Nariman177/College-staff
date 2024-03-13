using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TJ_16
{
    internal class Programs
    {
        class Employee
        {
            public Employee(string name)
            {
                this.Name = name;
            }
            protected string Name;
            public string name
            {
                get { return this.Name; }
            }
            virtual public void CalculatePay()
            {
                Console.WriteLine("Employee.CalculatePay вызвана для {0}", name);
            }

        }
        class ContractEmployee : Employee
        {
            public ContractEmployee(string name): base(name)
            {

            }
            public override void CalculatePay()
            {
                Console.WriteLine("ContractEmployee.CalculatePay вызвана для {0}", name);
            }
        }
        class SalariedEmployee : Employee
        {
            public SalariedEmployee(string name) : base(name)
            {

            }
            public override void CalculatePay()
            {
                Console.WriteLine("SalariedEmployee.CalculatePay вызвана для {0}", name);
            }
        }
        class Poly2App
        {
            protected Employee[] employees;
            public void LoadEmployees()
            {
                employees = new Employee[2];
                employees[0] = new ContractEmployee("Alex Rubinov");
                employees[1] = new SalariedEmployee("Rubinov Alah");
            }
            public void Rasher()
            {
                foreach(Employee emp in employees)
                    emp.CalculatePay();
            }
        }
       
        static void Main(string[] args)
        {
            Poly2App app = new Poly2App();
            app.LoadEmployees();
            app.Rasher();


        }
    }
}
