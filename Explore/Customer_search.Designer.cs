namespace Explore
{
    partial class Customer_search
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.return_combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pickup_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.return_date_picker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.start_date_picker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.car_type_combo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.customer_book_next = new System.Windows.Forms.Button();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.return_combo);
            this.panel10.Controls.Add(this.label8);
            this.panel10.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel10.Location = new System.Drawing.Point(396, 45);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(330, 51);
            this.panel10.TabIndex = 19;
            // 
            // return_combo
            // 
            this.return_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.return_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_combo.FormattingEnabled = true;
            this.return_combo.Location = new System.Drawing.Point(137, 12);
            this.return_combo.Name = "return_combo";
            this.return_combo.Size = new System.Drawing.Size(130, 21);
            this.return_combo.TabIndex = 1;
            this.return_combo.SelectedValueChanged += new System.EventHandler(this.Return_selection_picked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaShell;
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Return Branch";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pickup_combo);
            this.panel7.Controls.Add(this.label5);
            this.panel7.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel7.Location = new System.Drawing.Point(30, 45);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(330, 51);
            this.panel7.TabIndex = 18;
            // 
            // pickup_combo
            // 
            this.pickup_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pickup_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickup_combo.FormattingEnabled = true;
            this.pickup_combo.Location = new System.Drawing.Point(137, 12);
            this.pickup_combo.Name = "pickup_combo";
            this.pickup_combo.Size = new System.Drawing.Size(130, 21);
            this.pickup_combo.TabIndex = 1;
            this.pickup_combo.SelectedValueChanged += new System.EventHandler(this.Pickup_selection_picked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaShell;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pickup Branch";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.return_date_picker);
            this.panel9.Controls.Add(this.label7);
            this.panel9.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel9.Location = new System.Drawing.Point(396, 127);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(330, 51);
            this.panel9.TabIndex = 21;
            // 
            // return_date_picker
            // 
            this.return_date_picker.Location = new System.Drawing.Point(123, 13);
            this.return_date_picker.Name = "return_date_picker";
            this.return_date_picker.Size = new System.Drawing.Size(190, 20);
            this.return_date_picker.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaShell;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Return Date:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.start_date_picker);
            this.panel8.Controls.Add(this.label6);
            this.panel8.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel8.Location = new System.Drawing.Point(30, 127);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(330, 51);
            this.panel8.TabIndex = 20;
            // 
            // start_date_picker
            // 
            this.start_date_picker.CustomFormat = "yyyy/mm/dd";
            this.start_date_picker.Location = new System.Drawing.Point(103, 13);
            this.start_date_picker.Name = "start_date_picker";
            this.start_date_picker.Size = new System.Drawing.Size(190, 20);
            this.start_date_picker.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaShell;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Start Date:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.car_type_combo);
            this.panel11.Controls.Add(this.label9);
            this.panel11.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel11.Location = new System.Drawing.Point(30, 209);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(330, 51);
            this.panel11.TabIndex = 22;
            // 
            // car_type_combo
            // 
            this.car_type_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.car_type_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.car_type_combo.FormattingEnabled = true;
            this.car_type_combo.Location = new System.Drawing.Point(137, 12);
            this.car_type_combo.Name = "car_type_combo";
            this.car_type_combo.Size = new System.Drawing.Size(121, 21);
            this.car_type_combo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SeaShell;
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Car Type";
            // 
            // customer_book_next
            // 
            this.customer_book_next.BackColor = System.Drawing.Color.Transparent;
            this.customer_book_next.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.customer_book_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customer_book_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_book_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_book_next.ForeColor = System.Drawing.Color.SeaShell;
            this.customer_book_next.Location = new System.Drawing.Point(684, 387);
            this.customer_book_next.Name = "customer_book_next";
            this.customer_book_next.Size = new System.Drawing.Size(82, 40);
            this.customer_book_next.TabIndex = 24;
            this.customer_book_next.Text = "Next";
            this.customer_book_next.UseVisualStyleBackColor = false;
            this.customer_book_next.Click += new System.EventHandler(this.Button_next_click);
            // 
            // Customer_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.customer_book_next);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Name = "Customer_search";
            this.Size = new System.Drawing.Size(790, 460);
            this.Load += new System.EventHandler(this.Customer_search_load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox return_combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox pickup_combo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DateTimePicker return_date_picker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker start_date_picker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox car_type_combo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button customer_book_next;
    }
}
