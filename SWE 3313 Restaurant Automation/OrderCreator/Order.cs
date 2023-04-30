using SWE_3313_Restaurant_Automation;

namespace SWE_3313_Project
{
    public partial class Order : Form
    {
        internal TableObject table;

        internal Order(TableObject table)
        {
            this.table = table;
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Order.ActiveForm.Close();
        }

        private void Add_Seat_1_Click(object sender, EventArgs e)
        {
            OrderCategory orderCategory = new OrderCategory(table);
            orderCategory.Show();
        }

        private void Add_Seat_2_Click(object sender, EventArgs e)
        {
            OrderCategory orderCategory = new OrderCategory(table);
            orderCategory.Show();
        }

        private void Add_Seat_3_Click(object sender, EventArgs e)
        {
            OrderCategory orderCategory = new OrderCategory(table);
            orderCategory.Show();
        }

        private void Add_Seat_4_Click(object sender, EventArgs e)
        {
            OrderCategory orderCategory = new OrderCategory(table);
            orderCategory.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
