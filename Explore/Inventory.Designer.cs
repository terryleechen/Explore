namespace Explore
{
    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inventory_selected_branch_label = new System.Windows.Forms.Label();
            this.inventory_branch_select_combobox = new System.Windows.Forms.ComboBox();
            this.dataGridView_inventory = new System.Windows.Forms.DataGridView();
            this.Car_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory_add_button = new System.Windows.Forms.Button();
            this.inventory_update_button = new System.Windows.Forms.Button();
            this.inventory_delete_button = new System.Windows.Forms.Button();
            this.inventory_show_records_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inventory)).BeginInit();
            this.SuspendLayout();
            // 
            // inventory_selected_branch_label
            // 
            this.inventory_selected_branch_label.AutoSize = true;
            this.inventory_selected_branch_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_selected_branch_label.ForeColor = System.Drawing.Color.White;
            this.inventory_selected_branch_label.Location = new System.Drawing.Point(76, 26);
            this.inventory_selected_branch_label.Name = "inventory_selected_branch_label";
            this.inventory_selected_branch_label.Size = new System.Drawing.Size(154, 24);
            this.inventory_selected_branch_label.TabIndex = 0;
            this.inventory_selected_branch_label.Text = "Selected Branch:";
            // 
            // inventory_branch_select_combobox
            // 
            this.inventory_branch_select_combobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventory_branch_select_combobox.FormattingEnabled = true;
            this.inventory_branch_select_combobox.Location = new System.Drawing.Point(236, 31);
            this.inventory_branch_select_combobox.Name = "inventory_branch_select_combobox";
            this.inventory_branch_select_combobox.Size = new System.Drawing.Size(317, 21);
            this.inventory_branch_select_combobox.TabIndex = 1;
            this.inventory_branch_select_combobox.SelectedValueChanged += new System.EventHandler(this.User_select);
            // 
            // dataGridView_inventory
            // 
            this.dataGridView_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Car_ID,
            this.Type_ID,
            this.Brand,
            this.Model,
            this.Year,
            this.Mileage});
            this.dataGridView_inventory.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_inventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_inventory.Location = new System.Drawing.Point(80, 58);
            this.dataGridView_inventory.Name = "dataGridView_inventory";
            this.dataGridView_inventory.ReadOnly = true;
            this.dataGridView_inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_inventory.Size = new System.Drawing.Size(643, 304);
            this.dataGridView_inventory.TabIndex = 2;
            this.dataGridView_inventory.Click += new System.EventHandler(this.RowClick);
            // 
            // Car_ID
            // 
            this.Car_ID.HeaderText = "Car ID";
            this.Car_ID.Name = "Car_ID";
            this.Car_ID.ReadOnly = true;
            // 
            // Type_ID
            // 
            this.Type_ID.HeaderText = "Type ID";
            this.Type_ID.Name = "Type_ID";
            this.Type_ID.ReadOnly = true;
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
            // inventory_add_button
            // 
            this.inventory_add_button.BackColor = System.Drawing.Color.Transparent;
            this.inventory_add_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.inventory_add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inventory_add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_add_button.ForeColor = System.Drawing.Color.SeaShell;
            this.inventory_add_button.Location = new System.Drawing.Point(506, 378);
            this.inventory_add_button.Name = "inventory_add_button";
            this.inventory_add_button.Size = new System.Drawing.Size(82, 40);
            this.inventory_add_button.TabIndex = 12;
            this.inventory_add_button.Text = "Add";
            this.inventory_add_button.UseVisualStyleBackColor = false;
            this.inventory_add_button.Click += new System.EventHandler(this.Button_add_click);
            // 
            // inventory_update_button
            // 
            this.inventory_update_button.BackColor = System.Drawing.Color.Transparent;
            this.inventory_update_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.inventory_update_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inventory_update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_update_button.ForeColor = System.Drawing.Color.SeaShell;
            this.inventory_update_button.Location = new System.Drawing.Point(594, 378);
            this.inventory_update_button.Name = "inventory_update_button";
            this.inventory_update_button.Size = new System.Drawing.Size(82, 40);
            this.inventory_update_button.TabIndex = 13;
            this.inventory_update_button.Text = "Update";
            this.inventory_update_button.UseVisualStyleBackColor = false;
            this.inventory_update_button.Click += new System.EventHandler(this.Button_update_click);
            // 
            // inventory_delete_button
            // 
            this.inventory_delete_button.BackColor = System.Drawing.Color.Transparent;
            this.inventory_delete_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.inventory_delete_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inventory_delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_delete_button.ForeColor = System.Drawing.Color.SeaShell;
            this.inventory_delete_button.Location = new System.Drawing.Point(682, 378);
            this.inventory_delete_button.Name = "inventory_delete_button";
            this.inventory_delete_button.Size = new System.Drawing.Size(82, 40);
            this.inventory_delete_button.TabIndex = 14;
            this.inventory_delete_button.Text = "Delete";
            this.inventory_delete_button.UseVisualStyleBackColor = false;
            // 
            // inventory_show_records_button
            // 
            this.inventory_show_records_button.BackColor = System.Drawing.Color.Transparent;
            this.inventory_show_records_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.inventory_show_records_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inventory_show_records_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_show_records_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_show_records_button.ForeColor = System.Drawing.Color.SeaShell;
            this.inventory_show_records_button.Location = new System.Drawing.Point(80, 378);
            this.inventory_show_records_button.Name = "inventory_show_records_button";
            this.inventory_show_records_button.Size = new System.Drawing.Size(212, 40);
            this.inventory_show_records_button.TabIndex = 15;
            this.inventory_show_records_button.Text = "Show all records";
            this.inventory_show_records_button.UseVisualStyleBackColor = false;
            this.inventory_show_records_button.Click += new System.EventHandler(this.Inventory_show_records_button_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.inventory_show_records_button);
            this.Controls.Add(this.inventory_delete_button);
            this.Controls.Add(this.inventory_update_button);
            this.Controls.Add(this.inventory_add_button);
            this.Controls.Add(this.dataGridView_inventory);
            this.Controls.Add(this.inventory_branch_select_combobox);
            this.Controls.Add(this.inventory_selected_branch_label);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(790, 460);
            this.Load += new System.EventHandler(this.Load_event);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inventory_selected_branch_label;
        private System.Windows.Forms.ComboBox inventory_branch_select_combobox;
        private System.Windows.Forms.DataGridView dataGridView_inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
        private System.Windows.Forms.Button inventory_add_button;
        private System.Windows.Forms.Button inventory_update_button;
        private System.Windows.Forms.Button inventory_delete_button;
        private System.Windows.Forms.Button inventory_show_records_button;
    }
}
