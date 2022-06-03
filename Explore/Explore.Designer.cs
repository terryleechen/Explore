namespace Explore
{
    partial class Explore
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
            this.login_page = new Login_page();
            this.SuspendLayout();
            // 
            // login_page
            // 
            this.login_page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.login_page.Location = new System.Drawing.Point(0, 0);
            this.login_page.Name = "login_page";
            this.login_page.Size = new System.Drawing.Size(990, 560);
            this.login_page.TabIndex = 0;
            // 
            // Explore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.login_page);
            this.Name = "Explore";
            this.Text = "Explore";
            this.ResumeLayout(false);

        }

        #endregion

        private Login_page login_page;
    }
}