using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom11.Models
{
    internal class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set;}

    }
}
