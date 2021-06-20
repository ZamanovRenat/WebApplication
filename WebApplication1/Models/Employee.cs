using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeSurName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeePatronymic { get; set; }
        public string Department { get; set; }

        public string DateOfJoining { get; set; }

        public string PhotoFileName { get; set; }
    }
}
