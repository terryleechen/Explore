namespace Explore
{
    partial class Booking
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
            this.customer_book_next = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.customer_driver_license = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.customer_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customer_firstname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pickup_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.start_date_picker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.return_date_picker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.return_combo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.car_type_combo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
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
            this.customer_book_next.TabIndex = 12;
            this.customer_book_next.Text = "Next";
            this.customer_book_next.UseVisualStyleBackColor = false;
            this.customer_book_next.Click += new System.EventHandler(this.Button_next_click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.customer_driver_license);
            this.panel5.Controls.Add(this.label3);
            this.panel5.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel5.Location = new System.Drawing.Point(30, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 51);
            this.panel5.TabIndex = 15;
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
            this.customer_driver_license.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Driver_license_keydown);
            this.customer_driver_license.Leave += new System.EventHandler(this.Driver_license_leave);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.customer_lastname);
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(30, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 51);
            this.panel3.TabIndex = 14;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.customer_firstname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(30, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 51);
            this.panel1.TabIndex = 13;
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
            // panel7
            // 
            this.panel7.Controls.Add(this.pickup_combo);
            this.panel7.Controls.Add(this.label5);
            this.panel7.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel7.Location = new System.Drawing.Point(396, 45);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(330, 51);
            this.panel7.TabIndex = 16;
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
            // panel8
            // 
            this.panel8.Controls.Add(this.start_date_picker);
            this.panel8.Controls.Add(this.label6);
            this.panel8.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel8.Location = new System.Drawing.Point(30, 282);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(330, 51);
            this.panel8.TabIndex = 17;
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
            // panel9
            // 
            this.panel9.Controls.Add(this.return_date_picker);
            this.panel9.Controls.Add(this.label7);
            this.panel9.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel9.Location = new System.Drawing.Point(396, 282);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(330, 51);
            this.panel9.TabIndex = 18;
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
            // panel10
            // 
            this.panel10.Controls.Add(this.return_combo);
            this.panel10.Controls.Add(this.label8);
            this.panel10.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel10.Location = new System.Drawing.Point(396, 127);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(330, 51);
            this.panel10.TabIndex = 17;
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
            // panel11
            // 
            this.panel11.Controls.Add(this.car_type_combo);
            this.panel11.Controls.Add(this.label9);
            this.panel11.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel11.Location = new System.Drawing.Point(396, 204);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(330, 51);
            this.panel11.TabIndex = 18;
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
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customer_book_next);
            this.Name = "Booking";
            this.Size = new System.Drawing.Size(790, 460);
            this.Load += new System.EventHandler(this.Booking_load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button customer_book_next;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox customer_driver_license;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox customer_lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox customer_firstname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox pickup_combo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker start_date_picker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DateTimePicker return_date_picker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox return_combo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox car_type_combo;
        private System.Windows.Forms.Label label9;
    }
}
