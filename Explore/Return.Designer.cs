namespace Explore
{
    partial class Return
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.customer_driver_license = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.return_search = new System.Windows.Forms.Button();
            this.panel_info = new System.Windows.Forms.Panel();
            this.panel_lastname = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.customer_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_firstname = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customer_firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.transactions = new System.Windows.Forms.DataGridView();
            this.button_next = new System.Windows.Forms.Button();
            this.data_TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_reservation_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_car_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel_info.SuspendLayout();
            this.panel_lastname.SuspendLayout();
            this.panel_firstname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.return_search);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.customer_driver_license);
            this.panel5.Controls.Add(this.label3);
            this.panel5.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 51);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaShell;
            this.panel6.ForeColor = System.Drawing.Color.SeaShell;
            this.panel6.Location = new System.Drawing.Point(133, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(125, 1);
            this.panel6.TabIndex = 3;
            // 
            // customer_driver_license
            // 
            this.customer_driver_license.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customer_driver_license.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customer_driver_license.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_driver_license.ForeColor = System.Drawing.Color.SeaShell;
            this.customer_driver_license.Location = new System.Drawing.Point(133, 9);
            this.customer_driver_license.Name = "customer_driver_license";
            this.customer_driver_license.Size = new System.Drawing.Size(125, 22);
            this.customer_driver_license.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Driver License:";
            // 
            // return_search
            // 
            this.return_search.BackColor = System.Drawing.Color.Transparent;
            this.return_search.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.return_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.return_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_search.ForeColor = System.Drawing.Color.SeaShell;
            this.return_search.Location = new System.Drawing.Point(279, 3);
            this.return_search.Name = "return_search";
            this.return_search.Size = new System.Drawing.Size(89, 40);
            this.return_search.TabIndex = 12;
            this.return_search.Text = "Search";
            this.return_search.UseVisualStyleBackColor = false;
            this.return_search.Click += new System.EventHandler(this.Button_search_click);
            // 
            // panel_info
            // 
            this.panel_info.Controls.Add(this.panel_lastname);
            this.panel_info.Controls.Add(this.panel_firstname);
            this.panel_info.Controls.Add(this.transactions);
            this.panel_info.Controls.Add(this.button_next);
            this.panel_info.Location = new System.Drawing.Point(12, 79);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(773, 378);
            this.panel_info.TabIndex = 17;
            // 
            // panel_lastname
            // 
            this.panel_lastname.Controls.Add(this.panel4);
            this.panel_lastname.Controls.Add(this.customer_lastname);
            this.panel_lastname.Controls.Add(this.label2);
            this.panel_lastname.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel_lastname.Location = new System.Drawing.Point(402, 13);
            this.panel_lastname.Name = "panel_lastname";
            this.panel_lastname.Size = new System.Drawing.Size(330, 51);
            this.panel_lastname.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaShell;
            this.panel4.ForeColor = System.Drawing.Color.SeaShell;
            this.panel4.Location = new System.Drawing.Point(106, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 1);
            this.panel4.TabIndex = 3;
            // 
            // customer_lastname
            // 
            this.customer_lastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customer_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customer_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_lastname.ForeColor = System.Drawing.Color.SeaShell;
            this.customer_lastname.Location = new System.Drawing.Point(106, 9);
            this.customer_lastname.Name = "customer_lastname";
            this.customer_lastname.ReadOnly = true;
            this.customer_lastname.Size = new System.Drawing.Size(150, 22);
            this.customer_lastname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // panel_firstname
            // 
            this.panel_firstname.Controls.Add(this.panel2);
            this.panel_firstname.Controls.Add(this.customer_firstname);
            this.panel_firstname.Controls.Add(this.label4);
            this.panel_firstname.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel_firstname.Location = new System.Drawing.Point(12, 13);
            this.panel_firstname.Name = "panel_firstname";
            this.panel_firstname.Size = new System.Drawing.Size(330, 51);
            this.panel_firstname.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Location = new System.Drawing.Point(106, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 1);
            this.panel2.TabIndex = 3;
            // 
            // customer_firstname
            // 
            this.customer_firstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customer_firstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customer_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_firstname.ForeColor = System.Drawing.Color.SeaShell;
            this.customer_firstname.Location = new System.Drawing.Point(106, 9);
            this.customer_firstname.Name = "customer_firstname";
            this.customer_firstname.ReadOnly = true;
            this.customer_firstname.Size = new System.Drawing.Size(150, 22);
            this.customer_firstname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name:";
            // 
            // transactions
            // 
            this.transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_TID,
            this.data_start_date,
            this.data_end_date,
            this.data_reservation_price,
            this.data_car_type});
            this.transactions.Location = new System.Drawing.Point(105, 105);
            this.transactions.Name = "transactions";
            this.transactions.Size = new System.Drawing.Size(539, 150);
            this.transactions.TabIndex = 22;
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.Transparent;
            this.button_next.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.button_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.ForeColor = System.Drawing.Color.SeaShell;
            this.button_next.Location = new System.Drawing.Point(684, 330);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(82, 40);
            this.button_next.TabIndex = 21;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.Button_next_click);
            // 
            // data_TID
            // 
            this.data_TID.HeaderText = "TID";
            this.data_TID.Name = "data_TID";
            // 
            // data_start_date
            // 
            this.data_start_date.HeaderText = "Start Date";
            this.data_start_date.Name = "data_start_date";
            // 
            // data_end_date
            // 
            this.data_end_date.HeaderText = "End Date";
            this.data_end_date.Name = "data_end_date";
            // 
            // data_reservation_price
            // 
            this.data_reservation_price.HeaderText = "Reservation Price";
            this.data_reservation_price.Name = "data_reservation_price";
            // 
            // data_car_type
            // 
            this.data_car_type.HeaderText = "Car Type";
            this.data_car_type.Name = "data_car_type";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.panel5);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Name = "Return";
            this.Size = new System.Drawing.Size(790, 460);
            this.Load += new System.EventHandler(this.Return_load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_info.ResumeLayout(false);
            this.panel_lastname.ResumeLayout(false);
            this.panel_lastname.PerformLayout();
            this.panel_firstname.ResumeLayout(false);
            this.panel_firstname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox customer_driver_license;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button return_search;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Panel panel_lastname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox customer_lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_firstname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox customer_firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView transactions;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_reservation_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_car_type;
    }
}
