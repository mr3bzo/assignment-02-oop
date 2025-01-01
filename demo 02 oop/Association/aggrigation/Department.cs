using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Association.Aggraction
{
    internal class Department
    {
        public int code { get; set; }
        public required string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
