using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_3313_Restaurant_Automation.Users
{
    internal class Manager : Employee
    {
        public Manager()
        {
            EmployeeID = 12345;
            Username = "Doug Smith";
            Password = "password123!";
        }
       
    }
}
