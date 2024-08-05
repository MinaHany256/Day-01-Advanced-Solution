using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Salary { get; set; }


        public Employee(int id, int salary, string? name)
        {
            Id = id;
            Salary = salary;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Id} , {Name} , {Salary}";
        }

        public override bool Equals(object? obj)
        {
            //Employee? other = (Employee?)obj; // Explicit Casting  (Unsafe)

            Employee? other = obj as Employee;

            if (other == null) return false;

            return this.Id.Equals(other.Id) && (this.Name?.Equals(other.Name) ?? (other.Name == null ? true : false)) && this.Salary.Equals(other.Salary) ;
        }

        public override int GetHashCode()
        {
            int hashValue = 11;
            hashValue = (hashValue * 7) + Id.GetHashCode();
            hashValue = (hashValue * 7) + Name?.GetHashCode() ?? default(int);
            hashValue = (hashValue * 7) + Salary.GetHashCode();
            return hashValue;

            //return this.Id.GetHashCode() ^ this.Name?.GetHashCode() ?? default(int) ^ this.Salary.GetHashCode();
            //return this.Id.GetHashCode() + this.Name?.GetHashCode() ?? default(int) + this.Salary.GetHashCode();
        }

    }
}
