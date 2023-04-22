using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_3313_Project
{
    internal class Waiter : Employee
    {
        List<int> assignedTables;
        List<int> dailyHoursWorked;

        public Waiter()
        {
            assignedTables = new List<int>();
            dailyHoursWorked = new List<int>();
            employeeID = 0;
            username = "undefined";
            password = "password";
        }
        public Waiter(List<int> assignedTables, String username, String password, int ID)
        {
            this.assignedTables = assignedTables;
            dailyHoursWorked = new List<int>();
            this.username = username;
            this.password = password;
            this.employeeID = ID;
            AddWaiterToFile();
        }

        public void AddWaiterToFile()
        {
            //Adds waiter info to txt file if it doesnt exist already
            string waiterInfo = $"{employeeID},{password}";
            string[] fileLines = File.ReadAllLines("WaiterLogin.txt");
            bool waiterExists = false;
            foreach (string line in fileLines)
            {
                if (line == waiterInfo)
                {
                    waiterExists = true;
                    break;
                }
            }
            if (!waiterExists)
            {
                using (StreamWriter writer = File.AppendText("WaiterLogin.txt"))
                {
                    // Adds waiter information to txt file for login access
                    writer.WriteLine(waiterInfo);
                }
            }
        }
    }
}
