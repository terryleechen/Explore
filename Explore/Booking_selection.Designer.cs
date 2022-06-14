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
            this.button_book = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selected_pickup_branch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.availability_table = new System.Windows.Forms.DataGridView();
            this.Car_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selected_return_branch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.estimated_cost = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availability_table)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_book
            // 
            this.button_book.BackColor = System.Drawing.Color.Transparent;
            this.button_book.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.button_book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_book.ForeColor = System.Drawing.Color.SeaShell;
            this.button_book.Location = new System.Drawing.Point(684, 396);
            this.button_book.Name = "button_book";
            this.button_book.Size = new System.Drawing.Size(82, 40);
            this.button_book.TabIndex = 11;
            this.button_book.Text = "Book";
            this.button_book.UseVisualStyleBackColor = false;
            this.button_book.Click += new System.EventHandler(this.Button_book_click);
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.Transparent;
            this.button_previous.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.button_previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.ForeColor = System.Drawing.Color.SeaShell;
            this.button_previous.Location = new System.Drawing.Point(581, 397);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(97, 40);
            this.button_previous.TabIndex = 10;
            this.button_previous.Text = "Previous";
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.Button_previous_click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selected_pickup_branch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(30, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 51);
            this.panel1.TabIndex = 14;
            // 
            // selected_pickup_branch
            // 
            this.selected_pickup_branch.BackColor = System.Drawing.SystemColors.Window;
            this.selected_pickup_branch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selected_pickup_branch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.selected_pickup_branch.FormattingEnabled = true;
            this.selected_pickup_branch.Location = new System.Drawing.Point(135, 12);
            this.selected_pickup_branch.Name = "selected_pickup_branch";
            this.selected_pickup_branch.Size = new System.Drawing.Size(130, 21);
            this.selected_pickup_branch.TabIndex = 1;
            this.selected_pickup_branch.Leave += new System.EventHandler(this.Selected_pickup_branch_changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pickup Branch:";
            // 
            // availability_table
            // 
            this.availability_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availability_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Car_ID,
            this.Type_Name,
            this.Brand,
            this.Model,
            this.Year,
            this.Mileage});
            this.availability_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.availability_table.Location = new System.Drawing.Point(30, 102);
            this.availability_table.Name = "availability_table";
            this.availability_table.ReadOnly = true;
            this.availability_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availability_table.Size = new System.Drawing.Size(633, 279);
            this.availability_table.TabIndex = 15;
            this.availability_table.Click += new System.EventHandler(this.Selection_click);
            // 
            // Car_ID
            // 
            this.Car_ID.HeaderText = "Car ID";
            this.Car_ID.Name = "Car_ID";
            this.Car_ID.ReadOnly = true;
            // 
            // Type_Name
            // 
            this.Type_Name.HeaderText = "Type Name";
            this.Type_Name.Name = "Type_Name";
            this.Type_Name.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Mileage
            // 
            this.Mileage.HeaderText = "Mileage";
            this.Mileage.Name = "Mileage";
            this.Mileage.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selected_return_branch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(386, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 51);
            this.panel2.TabIndex = 15;
            // 
            // selected_return_branch
            // 
            this.selected_return_branch.BackColor = System.Drawing.SystemColors.Window;
            this.selected_return_branch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selected_return_branch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.selected_return_branch.FormattingEnabled = true;
            this.selected_return_branch.Location = new System.Drawing.Point(135, 12);
            this.selected_return_branch.Name = "selected_return_branch";
            this.selected_return_branch.Size = new System.Drawing.Size(130, 21);
            this.selected_return_branch.TabIndex = 1;
            this.selected_return_branch.Leave += new System.EventHandler(this.Selected_return_branch_changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Branch:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.estimated_cost);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(30, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 51);
            this.panel3.TabIndex = 16;
            // 
            // estimated_cost
            // 
            this.estimated_cost.AutoSize = true;
            this.estimated_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimated_cost.ForeColor = System.Drawing.Color.SeaShell;
            this.estimated_cost.Location = new System.Drawing.Point(139, 9);
            this.estimated_cost.Name = "estimated_cost";
            this.estimated_cost.Size = new System.Drawing.Size(96, 25);
            this.estimated_cost.TabIndex = 4;
            this.estimated_cost.Text = "              ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaShell;
            this.panel4.Location = new System.Drawing.Point(135, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 1);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estimated Cost:";
            // 
            // Booking_selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.availability_table);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_book);
            this.Controls.Add(this.button_previous);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Booking_selection";
            this.Size = new System.Drawing.Size(790, 460);
            this.Load += new System.EventHandler(this.Booking_selection_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availability_table)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_book;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selected_pickup_branch;
        private System.Windows.Forms.DataGridView availability_table;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox selected_return_branch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
        private System.Windows.Forms.Label estimated_cost;
    }
}
