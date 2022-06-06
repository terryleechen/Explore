namespace Explore
{
    partial class Customer_detail
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
            this.customer_save = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customer_save
            // 
            this.customer_save.BackColor = System.Drawing.Color.Transparent;
            this.customer_save.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.customer_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.customer_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_save.ForeColor = System.Drawing.Color.SeaGreen;
            this.customer_save.Location = new System.Drawing.Point(129, 36);
            this.customer_save.Name = "customer_save";
            this.customer_save.Size = new System.Drawing.Size(82, 40);
            this.customer_save.TabIndex = 9;
            this.customer_save.Text = "Save";
            this.customer_save.UseVisualStyleBackColor = false;
            this.customer_save.Click += new System.EventHandler(this.Button_save_click);
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.Transparent;
            this.button_previous.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button_previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_previous.Location = new System.Drawing.Point(26, 36);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(97, 40);
            this.button_previous.TabIndex = 8;
            this.button_previous.Text = "Previous";
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.Button_previous_click);
            // 
            // Customer_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.customer_save);
            this.Controls.Add(this.button_previous);
            this.Name = "Customer_detail";
            this.Size = new System.Drawing.Size(790, 460);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customer_save;
        private System.Windows.Forms.Button button_previous;
    }
}
