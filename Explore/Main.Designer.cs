namespace Explore
{
    partial class Main
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
            this.employee_dashboard = new Explore.Employee_dashboard();
            this.customer_dashboard = new Explore.Customer_dashboard();
            this.login_page = new Explore.Login_page(this.employee_dashboard, this.customer_dashboard);
            this.employee_dashboard.Set_login(this.login_page);
            this.customer_dashboard.Set_login(this.login_page);

            this.SuspendLayout();
            // 
            // employee_dashboard
            // 
            this.employee_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.employee_dashboard.Location = new System.Drawing.Point(0, 0);
            this.employee_dashboard.Name = "employee_dashboard";
            this.employee_dashboard.Size = new System.Drawing.Size(990, 560);
            this.employee_dashboard.TabIndex = 1;
            // 
            // login_page
            //
            
            this.login_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.login_page.Location = new System.Drawing.Point(0, 0);
            this.login_page.Name = "login_page";
            this.login_page.Size = new System.Drawing.Size(990, 560);
            this.login_page.TabIndex = 0;
            
            // 
            // customer_page
            // 
            this.customer_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customer_dashboard.Location = new System.Drawing.Point(0, 0);
            this.customer_dashboard.Name = "customer_page";
            this.customer_dashboard.Size = new System.Drawing.Size(990, 560);
            this.customer_dashboard.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.customer_dashboard);
            this.Controls.Add(this.employee_dashboard);
            this.Controls.Add(this.login_page);
            this.customer_dashboard.Hide();
            this.employee_dashboard.Hide();
            this.Name = "Main";
            this.Text = "Explore";
            this.ResumeLayout(false);

        }

        #endregion

        private Login_page login_page;
        private Employee_dashboard employee_dashboard;
        private Customer_dashboard customer_dashboard;
    }
}