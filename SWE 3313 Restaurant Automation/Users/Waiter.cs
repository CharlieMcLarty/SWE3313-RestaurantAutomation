namespace SWE_3313_Project
{
    internal class Waiter : Employee
    {
        public List<int> assignedTables;
        List<int> dailyHoursWorked;
        bool canRefund;
        public List<TableObject> tableList;

        public Waiter()
        {
            assignedTables = new List<int>();
            dailyHoursWorked = new List<int>();
            employeeID = 0;
            username = "undefined";
            password = "password";
            canRefund = false;
        }
        public Waiter(List<int> assignedTables, String username, String password, int ID)
        {
            this.assignedTables = assignedTables;
            dailyHoursWorked = new List<int>();
            this.username = username;
            this.password = password;
            this.employeeID = ID;
            AddWaiterToFile();
            canRefund = false;
            tableList = new List<TableObject>();
        }

        //Adds waiter id and password to file
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

        //Removes waiter id and password from file
        public void RemoveWaiterFromFile()
        {
            // Open the text file for reading
            using (StreamReader reader = new StreamReader("WaiterLogin.txt"))
            {
                // Create a temporary file to write the updated contents to
                using (StreamWriter writer = new StreamWriter("LoginInfo.tmp"))
                {
                    string line;

                    // Read each line from the file
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into its components
                        string[] parts = line.Split(',');

                        // Check if the userID matches
                        if (parts[0] != employeeID.ToString())
                        {
                            // Write the line to the temporary file
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            //Replace original file with temporary file
            File.Delete("WaiterLogin.Txt");
            File.Move("LoginInfo.tmp", "WaiterLogin.txt");
        }

        public void setRefundPermission(bool canRefund)
        {
            this.canRefund = canRefund;
        }
    }
}
