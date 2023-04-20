using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_3313_Restaurant_Automation.Users
{
    internal abstract class Employee
    {
        protected int EmployeeID;
        protected String? Username;
        protected String? Password;

        
        public void SetUsername(String Username)
        {
            this.Username = Username;
        }
        public void SetPassword(String Password)
        {
            this.Password = Password;
        }
        public String GetPassword()
        {
            return Password;
        }
        public String GetUsername()
        {
            return Username;
        }
    }
}
