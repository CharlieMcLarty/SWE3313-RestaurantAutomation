using SWE_3313_Project;
using SWE_3313_Restaurant_Automation.Users;

namespace SWE_3313_Restaurant_Automation
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

        static void InitializeEmployees()
        {
            Manager manager = new Manager();
        }
    }
}