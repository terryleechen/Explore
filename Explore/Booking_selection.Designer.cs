namespace Explore
{
    partial class Booking_selection
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
            this.customer_book = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customer_book
            // 
            this.customer_book.BackColor = System.Drawing.Color.Transparent;
            this.customer_book.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.customer_book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.customer_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_book.ForeColor = System.Drawing.Color.SeaGreen;
            this.customer_book.Location = new System.Drawing.Point(684, 387);
            this.customer_book.Name = "customer_book";
            this.customer_book.Size = new System.Drawing.Size(82, 40);
            this.customer_book.TabIndex = 11;
            this.customer_book.Text = "Save";
            this.customer_book.UseVisualStyleBackColor = false;
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.Transparent;
            this.button_previous.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button_previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_previous.Location = new System.Drawing.Point(581, 387);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(97, 40);
            this.button_previous.TabIndex = 10;
            this.button_previous.Text = "Previous";
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.Button_previous_click);
            // 
            // Booking_selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.customer_book);
            this.Controls.Add(this.button_previous);
            this.Name = "Booking_selection";
            this.Size = new System.Drawing.Size(790, 460);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customer_book;
        private System.Windows.Forms.Button button_previous;
    }
}
