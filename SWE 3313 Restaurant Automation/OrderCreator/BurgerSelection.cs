using SWE_3313_Project;

namespace SWE_3313_Restaurant_Automation.OrderCreator
{
    public partial class BurgerSelection : Form
    {
        TableObject table;
        internal BurgerSelection(TableObject table)
        {
            this.table = table;
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#733635");
        }

        private void MushroomSwiss_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Mushroom Swiss Burger"));
            this.Close();
        }

        private void Bacon_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Bacon Cheeseburger"));
            this.Close();
        }

        private void Carolina_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Carolina Burger"));
            this.Close();
        }

        private void VeganBoca_Click(object sender, EventArgs e)
        {
            table.Order.addToOrder(LoginPage.GetMenuItem("Vegan Boca Burger"));
            this.Close();
        }
    }
}
