using SWE_3313_Project;
using SWE_3313_Restaurant_Automation.OrderCreator;

namespace SWE_3313_Restaurant_Automation
{
    public partial class OrderCategory : Form
    {
        TableObject table;
        internal OrderCategory(TableObject table)
        {
            this.table = table;
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#733635");

        }

        private void Order_Appetizers_Click(object sender, EventArgs e)
        {
            AppetizerSelection appetizerForm = new AppetizerSelection(table);
            appetizerForm.Show();
            this.Close();
        }

        private void Salad_Click(object sender, EventArgs e)
        {
            SaladSelection saladSelection = new SaladSelection(table);
            saladSelection.Show();
            this.Close();
        }

        private void Entree_Click(object sender, EventArgs e)
        {
            EntreeSelection entreeSelection = new EntreeSelection(table);
            entreeSelection.Show();
            this.Close();
        }

        private void Burger_Click(object sender, EventArgs e)
        {
            BurgerSelection burgerSelection = new BurgerSelection(table);
            burgerSelection.Show();
            this.Close();
        }

        private void Beverage_Click(object sender, EventArgs e)
        {
            BeverageSelection beverageSelection = new BeverageSelection(table);
            beverageSelection.Show();
            this.Close();
        }
    }
}
