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
            this.label1 = new System.Windows.Forms.Label();
            this.customer_book_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(237, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking";
            // 
            // customer_book_next
            // 
            this.customer_book_next.BackColor = System.Drawing.Color.Transparent;
            this.customer_book_next.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.customer_book_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.customer_book_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_book_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_book_next.ForeColor = System.Drawing.Color.SeaGreen;
            this.customer_book_next.Location = new System.Drawing.Point(684, 387);
            this.customer_book_next.Name = "customer_book_next";
            this.customer_book_next.Size = new System.Drawing.Size(82, 40);
            this.customer_book_next.TabIndex = 12;
            this.customer_book_next.Text = "Next";
            this.customer_book_next.UseVisualStyleBackColor = false;
            this.customer_book_next.Click += new System.EventHandler(this.button_next_click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.customer_book_next);
            this.Controls.Add(this.label1);
            this.Name = "Booking";
            this.Size = new System.Drawing.Size(790, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customer_book_next;
    }
}
