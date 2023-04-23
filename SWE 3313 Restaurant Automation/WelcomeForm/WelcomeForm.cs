using SWE_3313_Restaurant_Automation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SWE_3313_Project
{
    public partial class WelcomeForm : Form
    {
        
        public WelcomeForm()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#733635");
        }
        public static Dictionary<string, Color> ButtonColors { get; set; } = new Dictionary<string, Color>()
        {
            { "button1", Color.Gray },
            { "button2", Color.White },
            { "button3", Color.White }
        };
        public void ChangeButtonColors()
        {
            foreach (KeyValuePair<string, Color> kvp in ButtonColors)
            {
                Control[] matches = this.Controls.Find(kvp.Key, true); // Find the control with the matching name
                if (matches.Length > 0 && matches[0] is Button)
                {
                    Button button = (Button)matches[0];
                    button.BackColor = kvp.Value; // Set the color of the button using the value in the dictionary
                }
            }
            this.Show();
        }


        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            Table_1 table_1 = new Table_1();
            table_1.Show();
            this.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Table_2 table_2 = new Table_2();
            table_2.Show();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Table_3 table_3 = new Table_3();
            table_3.Show();
            this.Close();
        }

        //Logging out of the program and showing the login screen.
        private void Log_Out_Click(object sender, EventArgs e) 
        {
            LoginPage login = Application.OpenForms.OfType<LoginPage>().FirstOrDefault();
            {
                if (login != null)
                {
                    login.Show();
                }
            }
            this.Close();
        }
    }
}
