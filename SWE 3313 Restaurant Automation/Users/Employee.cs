using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_3313_Project
{
    internal abstract class Employee
    {
        //5 digit 
        protected int employeeID;
        protected String? username;
        protected String? password;

        
        public void SetUsername(String Username)
        {
            this.username = Username;
        }
        public void SetPassword(String Password)
        {
            this.password = Password;
        }
        public String GetUsername()
        {
            return username;
        }
    }
}
