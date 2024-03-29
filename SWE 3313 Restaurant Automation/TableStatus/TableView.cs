﻿namespace SWE_3313_Project
{
    internal class TableView
    {
        public TableObject table;
        public int tableID;
        public Button button;
        public OrderObject order;

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
