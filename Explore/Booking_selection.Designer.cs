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
            this.panel1 = new System.Windows.Forms.Panel();
            this.selected_branch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Type_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_book
            // 
            this.customer_book.BackColor = System.Drawing.Color.Transparent;
            this.customer_book.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.customer_book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.customer_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_book.ForeColor = System.Drawing.Color.SeaShell;
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
            this.button_previous.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.button_previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.ForeColor = System.Drawing.Color.SeaShell;
            this.button_previous.Location = new System.Drawing.Point(581, 387);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(97, 40);
            this.button_previous.TabIndex = 10;
            this.button_previous.Text = "Previous";
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.Button_previous_click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selected_branch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(30, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 51);
            this.panel1.TabIndex = 14;
            // 
            // selected_branch
            // 
            this.selected_branch.FormattingEnabled = true;
            this.selected_branch.Location = new System.Drawing.Point(164, 11);
            this.selected_branch.Name = "selected_branch";
            this.selected_branch.Size = new System.Drawing.Size(130, 21);
            this.selected_branch.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selected Branch:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type_ID,
            this.Brand,
            this.Model,
            this.Year,
            this.Mileage});
            this.dataGridView1.Location = new System.Drawing.Point(30, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // Type_ID
            // 
            this.Type_ID.HeaderText = "Type_ID";
            this.Type_ID.Name = "Type_ID";
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // Mileage
            // 
            this.Mileage.HeaderText = "Mileage";
            this.Mileage.Name = "Mileage";
            // 
            // Booking_selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customer_book);
            this.Controls.Add(this.button_previous);
            this.Name = "Booking_selection";
            this.Size = new System.Drawing.Size(790, 460);
            this.Load += new System.EventHandler(this.Booking_selection_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customer_book;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selected_branch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
    }
}
