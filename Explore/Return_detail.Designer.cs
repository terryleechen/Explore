namespace Explore
{
    partial class Return_detail
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
            this.label1 = new System.Windows.Forms.Label();
            this.return_confirm = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "return detail";
            // 
            // return_confirm
            // 
            this.return_confirm.BackColor = System.Drawing.Color.Transparent;
            this.return_confirm.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.return_confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.return_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_confirm.ForeColor = System.Drawing.Color.SeaShell;
            this.return_confirm.Location = new System.Drawing.Point(129, 36);
            this.return_confirm.Name = "return_confirm";
            this.return_confirm.Size = new System.Drawing.Size(89, 40);
            this.return_confirm.TabIndex = 11;
            this.return_confirm.Text = "Confirm";
            this.return_confirm.UseVisualStyleBackColor = false;
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.Transparent;
            this.button_previous.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.button_previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.ForeColor = System.Drawing.Color.SeaShell;
            this.button_previous.Location = new System.Drawing.Point(26, 36);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(97, 40);
            this.button_previous.TabIndex = 10;
            this.button_previous.Text = "Previous";
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // Return_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.return_confirm);
            this.Controls.Add(this.button_previous);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.Name = "Return_detail";
            this.Size = new System.Drawing.Size(790, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button return_confirm;
        private System.Windows.Forms.Button button_previous;
    }
}
