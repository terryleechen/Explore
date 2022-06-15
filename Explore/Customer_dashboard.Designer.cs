namespace Explore
{
    partial class Customer_dashboard
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_home = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customer_date = new System.Windows.Forms.Label();
            this.customer_logout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customer_home = new Explore.Customer_home();
            this.customer_search_selection = new Explore.Customer_search_selection();
            this.customer_search = new Explore.Customer_search(this.customer_search_selection);
            
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 560);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 460);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.date);
            this.panel5.Controls.Add(this.logout);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 100);
            this.panel5.TabIndex = 4;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.SeaGreen;
            this.date.Location = new System.Drawing.Point(30, 38);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(57, 25);
            this.date.TabIndex = 2;
            this.date.Text = "Date";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.SeaGreen;
            this.logout.Location = new System.Drawing.Point(679, 32);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(108, 39);
            this.logout.TabIndex = 1;
            this.logout.Text = "LOGOUT";
            this.logout.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.title);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 560);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel7.Controls.Add(this.button_home);
            this.panel7.Controls.Add(this.button_search);
            this.panel7.Location = new System.Drawing.Point(3, 97);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 460);
            this.panel7.TabIndex = 0;
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
            this.button_home.TabIndex = 1;
            this.button_home.Text = "HOME";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.Customer_home_click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.SeaShell;
            this.button_search.Location = new System.Drawing.Point(0, 109);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(191, 41);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "SEARCH";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.Customer_search_click);
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
            this.panel2.Controls.Add(this.customer_date);
            this.panel2.Controls.Add(this.customer_logout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 100);
            this.panel2.TabIndex = 2;
            // 
            // customer_date
            // 
            this.customer_date.AutoSize = true;
            this.customer_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_date.ForeColor = System.Drawing.Color.SeaShell;
            this.customer_date.Location = new System.Drawing.Point(30, 38);
            this.customer_date.Name = "customer_date";
            this.customer_date.Size = new System.Drawing.Size(57, 25);
            this.customer_date.TabIndex = 2;
            this.customer_date.Text = "Date";
            // 
            // customer_logout
            // 
            this.customer_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customer_logout.FlatAppearance.BorderSize = 0;
            this.customer_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_logout.ForeColor = System.Drawing.Color.Red;
            this.customer_logout.Location = new System.Drawing.Point(679, 32);
            this.customer_logout.Name = "customer_logout";
            this.customer_logout.Size = new System.Drawing.Size(108, 39);
            this.customer_logout.TabIndex = 1;
            this.customer_logout.Text = "LOGOUT";
            this.customer_logout.UseVisualStyleBackColor = false;
            this.customer_logout.Click += new System.EventHandler(this.Customer_logut_click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customer_home);
            this.panel3.Controls.Add(this.customer_search);
            this.panel3.Controls.Add(this.customer_search_selection);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 460);
            this.panel3.TabIndex = 3;
            // 
            // customer_home
            // 
            this.customer_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customer_home.Location = new System.Drawing.Point(0, 0);
            this.customer_home.Name = "customer_home";
            this.customer_home.Size = new System.Drawing.Size(790, 460);
            this.customer_home.TabIndex = 1;
            // 
            // customer_search
            // 
            this.customer_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customer_search.Location = new System.Drawing.Point(0, 0);
            this.customer_search.Name = "customer_search";
            this.customer_search.Size = new System.Drawing.Size(790, 460);
            this.customer_search.TabIndex = 0;
            this.customer_search.Visible = false;
            // 
            // customer_search_selection
            // 
            this.customer_search_selection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customer_search_selection.Location = new System.Drawing.Point(0, 0);
            this.customer_search_selection.Name = "customer_search_selection";
            this.customer_search_selection.Size = new System.Drawing.Size(790, 460);
            this.customer_search_selection.TabIndex = 2;
            this.customer_search_selection.Visible = false;
            // 
            // Customer_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Customer_dashboard";
            this.Size = new System.Drawing.Size(990, 560);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label customer_date;
        private System.Windows.Forms.Button customer_logout;
        private System.Windows.Forms.Panel panel3;
        private Customer_search customer_search;
        private Customer_home customer_home;
        private Customer_search_selection customer_search_selection;
        private System.Windows.Forms.Button button_home;
    }
}
