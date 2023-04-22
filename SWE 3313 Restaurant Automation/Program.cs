namespace SWE_3313_Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            InitializeEmployees();
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginPage());
             
        }

        public static void InitializeEmployees()
        {
            // Initialize employees
             Manager manager = new Manager();
            //manager id is 12345, password is Password123!
            List<Waiter> waiters = new List<Waiter>();
            //use first waiter for testing
            waiters.Add(new Waiter(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "waiter", "password", 11111));
            waiters.Add(new Waiter(new List<int>() { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }, "Pikachu921", "Thunderbolt5", 94473));
            waiters.Add(new Waiter(new List<int>() { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 }, "RogerM1998", "So%2j82", 15673));
        }
    }
}