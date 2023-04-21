namespace SWE_3313_Restaurant_Automation
{
    partial class Table_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.New_Order = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Button();
            this.Table_Occupied = new System.Windows.Forms.Button();
            this.Table_Ready = new System.Windows.Forms.Button();
            this.Table_Dirty = new System.Windows.Forms.Button();
            this.TableStatus = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New_Order
            // 
            this.New_Order.Location = new System.Drawing.Point(152, 226);
            this.New_Order.Name = "New_Order";
            this.New_Order.Size = new System.Drawing.Size(75, 23);
            this.New_Order.TabIndex = 0;
            this.New_Order.Text = "New Order";
            this.New_Order.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.Payment.Location = new System.Drawing.Point(233, 226);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(75, 23);
            this.Payment.TabIndex = 1;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = true;
            // 
            // Table_Occupied
            // 
            this.Table_Occupied.Location = new System.Drawing.Point(172, 131);
            this.Table_Occupied.Name = "Table_Occupied";
            this.Table_Occupied.Size = new System.Drawing.Size(111, 23);
            this.Table_Occupied.TabIndex = 2;
            this.Table_Occupied.Text = "Table Occupied";
            this.Table_Occupied.UseVisualStyleBackColor = true;
            this.Table_Occupied.Click += new System.EventHandler(this.Table_Occupied_Click);
            // 
            // Table_Ready
            // 
            this.Table_Ready.Location = new System.Drawing.Point(172, 102);
            this.Table_Ready.Name = "Table_Ready";
            this.Table_Ready.Size = new System.Drawing.Size(111, 23);
            this.Table_Ready.TabIndex = 3;
            this.Table_Ready.Text = "Table Ready";
            this.Table_Ready.UseVisualStyleBackColor = true;
            this.Table_Ready.Click += new System.EventHandler(this.Table_Ready_Click);
            // 
            // Table_Dirty
            // 
            this.Table_Dirty.Location = new System.Drawing.Point(172, 160);
            this.Table_Dirty.Name = "Table_Dirty";
            this.Table_Dirty.Size = new System.Drawing.Size(111, 23);
            this.Table_Dirty.TabIndex = 4;
            this.Table_Dirty.Text = "Table Dirty";
            this.Table_Dirty.UseVisualStyleBackColor = true;
            this.Table_Dirty.Click += new System.EventHandler(this.Table_Dirty_Click);
            // 
            // TableStatus
            // 
            this.TableStatus.AutoSize = true;
            this.TableStatus.Location = new System.Drawing.Point(194, 73);
            this.TableStatus.Name = "TableStatus";
            this.TableStatus.Size = new System.Drawing.Size(69, 15);
            this.TableStatus.TabIndex = 5;
            this.TableStatus.Text = "Table Status";
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(194, 287);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 6;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Table_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.TableStatus);
            this.Controls.Add(this.Table_Dirty);
            this.Controls.Add(this.Table_Ready);
            this.Controls.Add(this.Table_Occupied);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.New_Order);
            this.Name = "Table_1";
            this.Text = "Table_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button New_Order;
        private Button Payment;
        private Button Table_Occupied;
        private Button Table_Ready;
        private Button Table_Dirty;
        private Label TableStatus;
        private Button Done;
    }
}