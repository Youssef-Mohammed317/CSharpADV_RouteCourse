using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee
    {
        public Employee(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} \t Name:{Name} \t Salary:{Salary:c}";
        }

        public override bool Equals(object? obj)
        {
            if(obj is Employee emp)
                return emp.Id == Id && emp.Name.ToLower() == Name.ToLower() && emp.Salary == Salary;
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }

    }
}
