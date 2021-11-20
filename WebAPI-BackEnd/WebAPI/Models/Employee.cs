using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Employee
    {
        public int EmployeeId { set; get; }
        public string EmployeeName { set; get; }
        public string Department { set; get; }
        public string DateOfJoining { set; get; }
        public string PhotoFileName { set; get; }

    }
}
