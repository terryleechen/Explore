namespace Explore
{
    partial class Reports
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
            this.button_add = new System.Windows.Forms.Button();
            this.report_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.report4 = new Explore.Report4();
            this.report3 = new Explore.Report3();
            this.report2 = new Explore.Report2();
            this.report1 = new Explore.Report1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.report_combo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 54);
            this.panel1.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Transparent;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.SeaShell;
            this.button_add.Location = new System.Drawing.Point(324, 6);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(82, 40);
            this.button_add.TabIndex = 29;
            this.button_add.Text = "Show";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_show_click);
            // 
            // report_combo
            // 
            this.report_combo.FormattingEnabled = true;
            this.report_combo.Location = new System.Drawing.Point(170, 16);
            this.report_combo.Name = "report_combo";
            this.report_combo.Size = new System.Drawing.Size(148, 21);
            this.report_combo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report selections:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.report4);
            this.panel2.Controls.Add(this.report3);
            this.panel2.Controls.Add(this.report2);
            this.panel2.Controls.Add(this.report1);
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 386);
            this.panel2.TabIndex = 1;
            // 
            // report4
            // 
            this.report4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.report4.Location = new System.Drawing.Point(0, 0);
            this.report4.Name = "report4";
            this.report4.Size = new System.Drawing.Size(790, 386);
            this.report4.TabIndex = 3;
            this.report4.Visible = false;
            // 
            // report3
            // 
            this.report3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.report3.Location = new System.Drawing.Point(0, 0);
            this.report3.Name = "report3";
            this.report3.Size = new System.Drawing.Size(790, 386);
            this.report3.TabIndex = 2;
            this.report3.Visible = false;
            // 
            // report2
            // 
            this.report2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.report2.Location = new System.Drawing.Point(0, 0);
            this.report2.Name = "report2";
            this.report2.Size = new System.Drawing.Size(790, 386);
            this.report2.TabIndex = 1;
            this.report2.Visible = false;
            // 
            // report1
            // 
            this.report1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.report1.Location = new System.Drawing.Point(0, 0);
            this.report1.Name = "report1";
            this.report1.Size = new System.Drawing.Size(790, 386);
            this.report1.TabIndex = 0;
            this.report1.Visible = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(790, 460);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox report_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel2;
        private Report1 report1;
        private Report2 report2;
        private Report4 report4;
        private Report3 report3;
    }
}
