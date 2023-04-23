using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_3313_Project
{
    internal class TableView
    {
        public TableObject table;
        public Button button;

        public TableView()
        {
            table = new TableObject();
            button = new Button();

            button.Click += OnTableClick;
        }

        public void OnTableClick(object Sender, EventArgs Args)
        {
            Color initialStatus = button.BackColor;
            TableStatus tableStatus = new TableStatus(initialStatus, table);
            tableStatus.ShowDialog();
            if (tableStatus.StatusColor != initialStatus && tableStatus.DialogResult == DialogResult.OK)
            {
                button.BackColor = tableStatus.StatusColor;
            }
        }
    }
}
