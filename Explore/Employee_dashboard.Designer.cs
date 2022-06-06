namespace Explore
{
    partial class Employee_dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_reports = new System.Windows.Forms.Button();
            this.button_customer = new System.Windows.Forms.Button();
            this.button_booking = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            this.button_inventory = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.employee_date = new System.Windows.Forms.Label();
            this.employee_logout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customer_detail = new Explore.Customer_detail();
            this.booking_selection = new Explore.Booking_selection();
            this.employee_home = new Explore.Home();
            // link customer and customer detail
            this.employee_customer = new Explore.Customer(customer_detail);
            this.customer_detail.Get_customer(this);
            // linke booking and booking selection
            this.employee_booking = new Explore.Booking(this.booking_selection);
            this.booking_selection.Get_employee_dashboard(this);
            this.employee_return = new Explore.Return();
            this.employee_inventory = new Explore.Inventory();
            this.employee_reports = new Explore.Reports();
            
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 560);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_reports);
            this.panel4.Controls.Add(this.button_customer);
            this.panel4.Controls.Add(this.button_booking);
            this.panel4.Controls.Add(this.button_return);
            this.panel4.Controls.Add(this.button_inventory);
            this.panel4.Controls.Add(this.button_home);
            this.panel4.Location = new System.Drawing.Point(3, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 460);
            this.panel4.TabIndex = 0;
            // 
            // button_reports
            // 
            this.button_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_reports.FlatAppearance.BorderSize = 0;
            this.button_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reports.ForeColor = System.Drawing.Color.SeaShell;
            this.button_reports.Location = new System.Drawing.Point(3, 388);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(191, 41);
            this.button_reports.TabIndex = 5;
            this.button_reports.Text = "REPORTS";
            this.button_reports.UseVisualStyleBackColor = false;
            this.button_reports.Click += new System.EventHandler(this.button_report_click);
            // 
            // button_customer
            // 
            this.button_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_customer.FlatAppearance.BorderSize = 0;
            this.button_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_customer.ForeColor = System.Drawing.Color.SeaShell;
            this.button_customer.Location = new System.Drawing.Point(3, 89);
            this.button_customer.Name = "button_customer";
            this.button_customer.Size = new System.Drawing.Size(191, 41);
            this.button_customer.TabIndex = 4;
            this.button_customer.Text = "CUSTOMER";
            this.button_customer.UseVisualStyleBackColor = false;
            this.button_customer.Click += new System.EventHandler(this.button_customer_click);
            // 
            // button_booking
            // 
            this.button_booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_booking.FlatAppearance.BorderSize = 0;
            this.button_booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_booking.ForeColor = System.Drawing.Color.SeaShell;
            this.button_booking.Location = new System.Drawing.Point(3, 167);
            this.button_booking.Name = "button_booking";
            this.button_booking.Size = new System.Drawing.Size(191, 41);
            this.button_booking.TabIndex = 3;
            this.button_booking.Text = "BOOKING";
            this.button_booking.UseVisualStyleBackColor = false;
            this.button_booking.Click += new System.EventHandler(this.button_booking_click);
            // 
            // button_return
            // 
            this.button_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_return.FlatAppearance.BorderSize = 0;
            this.button_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_return.ForeColor = System.Drawing.Color.SeaShell;
            this.button_return.Location = new System.Drawing.Point(3, 239);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(191, 41);
            this.button_return.TabIndex = 2;
            this.button_return.Text = "RETURN";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_click);
            // 
            // button_inventory
            // 
            this.button_inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_inventory.FlatAppearance.BorderSize = 0;
            this.button_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_inventory.ForeColor = System.Drawing.Color.SeaShell;
            this.button_inventory.Location = new System.Drawing.Point(3, 311);
            this.button_inventory.Name = "button_inventory";
            this.button_inventory.Size = new System.Drawing.Size(191, 41);
            this.button_inventory.TabIndex = 1;
            this.button_inventory.Text = "INVENTORY";
            this.button_inventory.UseVisualStyleBackColor = false;
            this.button_inventory.Click += new System.EventHandler(this.button_inventory_click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.Color.SeaShell;
            this.button_home.Location = new System.Drawing.Point(3, 31);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(191, 41);
            this.button_home.TabIndex = 0;
            this.button_home.Text = "HOME";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Gold;
            this.title.Location = new System.Drawing.Point(6, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(194, 55);
            this.title.TabIndex = 4;
            this.title.Text = "Explore";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.employee_date);
            this.panel2.Controls.Add(this.employee_logout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 100);
            this.panel2.TabIndex = 1;
            // 
            // employee_date
            // 
            this.employee_date.AutoSize = true;
            this.employee_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_date.ForeColor = System.Drawing.Color.SeaShell;
            this.employee_date.Location = new System.Drawing.Point(30, 38);
            this.employee_date.Name = "employee_date";
            this.employee_date.Size = new System.Drawing.Size(57, 25);
            this.employee_date.TabIndex = 2;
            this.employee_date.Text = "Date";
            // 
            // employee_logout
            // 
            this.employee_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.employee_logout.FlatAppearance.BorderSize = 0;
            this.employee_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_logout.ForeColor = System.Drawing.Color.Red;
            this.employee_logout.Location = new System.Drawing.Point(679, 32);
            this.employee_logout.Name = "employee_logout";
            this.employee_logout.Size = new System.Drawing.Size(108, 39);
            this.employee_logout.TabIndex = 1;
            this.employee_logout.Text = "Sign Out";
            this.employee_logout.UseVisualStyleBackColor = false;
            this.employee_logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.booking_selection);
            this.panel3.Controls.Add(this.customer_detail);
            this.panel3.Controls.Add(this.employee_home);
            this.panel3.Controls.Add(this.employee_customer);
            this.panel3.Controls.Add(this.employee_booking);
            this.panel3.Controls.Add(this.employee_return);
            this.panel3.Controls.Add(this.employee_inventory);
            this.panel3.Controls.Add(this.employee_reports);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 460);
            this.panel3.TabIndex = 2;
            // 
            // customer_detail
            // 
            this.customer_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customer_detail.Location = new System.Drawing.Point(0, 0);
            this.customer_detail.Name = "customer_detail";
            this.customer_detail.Size = new System.Drawing.Size(790, 460);
            this.customer_detail.TabIndex = 6;
            // 
            // employee_customer
            // 
            this.employee_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.employee_customer.Location = new System.Drawing.Point(0, 0);
            this.employee_customer.Name = "employee_customer";
            this.employee_customer.Size = new System.Drawing.Size(790, 460);
            this.employee_customer.TabIndex = 4;
            // 
            // employee_home
            // 
            this.employee_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.employee_home.Location = new System.Drawing.Point(0, 0);
            this.employee_home.Name = "employee_home";
            this.employee_home.Size = new System.Drawing.Size(790, 460);
            this.employee_home.TabIndex = 5;
            // 
            // employee_booking
            // 
            this.employee_booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.employee_booking.Location = new System.Drawing.Point(0, 0);
            this.employee_booking.Name = "employee_booking";
            this.employee_booking.Size = new System.Drawing.Size(790, 460);
            this.employee_booking.TabIndex = 3;
            // 
            // employee_return
            // 
            this.employee_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.employee_return.ForeColor = System.Drawing.Color.SeaGreen;
            this.employee_return.Location = new System.Drawing.Point(0, 0);
            this.employee_return.Name = "employee_return";
            this.employee_return.Size = new System.Drawing.Size(790, 460);
            this.employee_return.TabIndex = 2;
            // 
            // employee_inventory
            // 
            this.employee_inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.employee_inventory.ForeColor = System.Drawing.Color.SeaGreen;
            this.employee_inventory.Location = new System.Drawing.Point(0, 0);
            this.employee_inventory.Name = "employee_inventory";
            this.employee_inventory.Size = new System.Drawing.Size(790, 460);
            this.employee_inventory.TabIndex = 1;
            // 
            // employee_reports
            // 
            this.employee_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.employee_reports.ForeColor = System.Drawing.Color.SeaGreen;
            this.employee_reports.Location = new System.Drawing.Point(0, 0);
            this.employee_reports.Name = "employee_reports";
            this.employee_reports.Size = new System.Drawing.Size(790, 460);
            this.employee_reports.TabIndex = 0;
            // 
            // booking_selection
            // 
            this.booking_selection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.booking_selection.Location = new System.Drawing.Point(0, 0);
            this.booking_selection.Name = "booking_selection";
            this.booking_selection.Size = new System.Drawing.Size(790, 460);
            this.booking_selection.TabIndex = 7;
            // 
            // Employee_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Employee_dashboard";
            this.Size = new System.Drawing.Size(990, 560);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_customer;
        private System.Windows.Forms.Button button_booking;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_inventory;
        private System.Windows.Forms.Button button_reports;
        private System.Windows.Forms.Button employee_logout;
        private System.Windows.Forms.Label employee_date;
        private Reports employee_reports;
        private Inventory employee_inventory;
        private Return employee_return;
        private Booking employee_booking;
        private Customer employee_customer;
        private Home employee_home;
        private Customer_detail customer_detail;
        private Booking_selection booking_selection;
    }
}
