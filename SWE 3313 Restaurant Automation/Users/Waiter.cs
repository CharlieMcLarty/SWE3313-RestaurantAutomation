using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_3313_Restaurant_Automation.Users
{
    internal class Waiter
    {
        List<int> assignedTables;
        List<int> dailyHoursWorked;

        public Waiter()
        {
            assignedTables = new List<int>();
            dailyHoursWorked = new List<int>();
        }
        public Waiter(List<int> assignedTables)
        {
            this.assignedTables = assignedTables;
            dailyHoursWorked = new List<int>();
        }
    }
}
