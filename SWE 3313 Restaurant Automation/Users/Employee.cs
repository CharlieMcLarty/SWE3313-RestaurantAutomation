namespace SWE_3313_Restaurant_Automation.Users
{
    internal abstract class Employee
    {
        /// <summary>
        /// The ID number associated with this user
        /// </summary>
        protected int employeeID;
        /// <summary>
        /// The saved username for this user
        /// </summary>
        protected String? username;
        /// <summary>
        /// The saved password for this user
        /// </summary>
        protected String? password;


        /// <summary>
        /// Sets this user's username
        /// </summary>
        public void SetUsername(String Username)
        {
            this.username = Username;
        }
        /// <summary>
        /// Sets this user's password
        /// </summary>
        public void SetPassword(String Password)
        {
            this.password = Password;
        }
        /// <summary>
        /// Returns this user's stored password
        /// </summary>
        /// <returns></returns>
        public String GetPassword()
        {
            return password;
        }
        /// <summary>
        /// Returns this user's stored username
        /// </summary>
        public String GetUsername()
        {
            return username;
        }
    }
}
