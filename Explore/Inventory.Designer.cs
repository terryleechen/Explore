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
            this.selected_branch_label = new System.Windows.Forms.Label();
            this.selected_branch_combobox = new System.Windows.Forms.ComboBox();
            this.employee_inventory_datagridview = new System.Windows.Forms.DataGridView();
            this.Car_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Car_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventory_add_button = new System.Windows.Forms.Button();
            this.inventory_edit_button = new System.Windows.Forms.Button();
            this.inventory_delete_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employee_inventory_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // selected_branch_label
            // 
            this.selected_branch_label.AutoSize = true;
            this.selected_branch_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_branch_label.ForeColor = System.Drawing.Color.White;
            this.selected_branch_label.Location = new System.Drawing.Point(98, 18);
            this.selected_branch_label.Name = "selected_branch_label";
            this.selected_branch_label.Size = new System.Drawing.Size(154, 24);
            this.selected_branch_label.TabIndex = 0;
            this.selected_branch_label.Text = "Selected Branch:";
            // 
            // selected_branch_combobox
            // 
            this.selected_branch_combobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selected_branch_combobox.FormattingEnabled = true;
            this.selected_branch_combobox.Location = new System.Drawing.Point(258, 23);
            this.selected_branch_combobox.Name = "selected_branch_combobox";
            this.selected_branch_combobox.Size = new System.Drawing.Size(242, 21);
            this.selected_branch_combobox.TabIndex = 1;
            // 
            // employee_inventory_datagridview
            // 
            this.employee_inventory_datagridview.AllowUserToAddRows = false;
            this.employee_inventory_datagridview.AllowUserToDeleteRows = false;
            this.employee_inventory_datagridview.AllowUserToResizeColumns = false;
            this.employee_inventory_datagridview.AllowUserToResizeRows = false;
            this.employee_inventory_datagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.employee_inventory_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_inventory_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Car_ID,
            this.Car_Type,
            this.Brand,
            this.Model,
            this.Year,
            this.Mileage});
            this.employee_inventory_datagridview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_inventory_datagridview.Location = new System.Drawing.Point(77, 60);
            this.employee_inventory_datagridview.Name = "employee_inventory_datagridview";
            this.employee_inventory_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employee_inventory_datagridview.Size = new System.Drawing.Size(643, 349);
            this.employee_inventory_datagridview.TabIndex = 2;
            // 
            // Car_ID
            // 
            this.Car_ID.HeaderText = "Car ID";
            this.Car_ID.Name = "Car_ID";
            // 
            // Car_Type
            // 
            this.Car_Type.HeaderText = "Car Type";
            this.Car_Type.Name = "Car_Type";
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
            this.Mileage.HeaderText = "Mileage (km)";
            this.Mileage.Name = "Mileage";
            // 
            // inventory_add_button
            // 
            this.inventory_add_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventory_add_button.ForeColor = System.Drawing.Color.Black;
            this.inventory_add_button.Location = new System.Drawing.Point(464, 415);
            this.inventory_add_button.Name = "inventory_add_button";
            this.inventory_add_button.Size = new System.Drawing.Size(75, 23);
            this.inventory_add_button.TabIndex = 3;
            this.inventory_add_button.Text = "Add";
            this.inventory_add_button.UseVisualStyleBackColor = true;
            // 
            // inventory_edit_button
            // 
            this.inventory_edit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventory_edit_button.ForeColor = System.Drawing.Color.Black;
            this.inventory_edit_button.Location = new System.Drawing.Point(545, 415);
            this.inventory_edit_button.Name = "inventory_edit_button";
            this.inventory_edit_button.Size = new System.Drawing.Size(75, 23);
            this.inventory_edit_button.TabIndex = 4;
            this.inventory_edit_button.Text = "Update";
            this.inventory_edit_button.UseVisualStyleBackColor = true;
            // 
            // inventory_delete_button
            // 
            this.inventory_delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventory_delete_button.ForeColor = System.Drawing.Color.Black;
            this.inventory_delete_button.Location = new System.Drawing.Point(626, 415);
            this.inventory_delete_button.Name = "inventory_delete_button";
            this.inventory_delete_button.Size = new System.Drawing.Size(75, 23);
            this.inventory_delete_button.TabIndex = 5;
            this.inventory_delete_button.Text = "Delete";
            this.inventory_delete_button.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.inventory_delete_button);
            this.Controls.Add(this.inventory_edit_button);
            this.Controls.Add(this.inventory_add_button);
            this.Controls.Add(this.employee_inventory_datagridview);
            this.Controls.Add(this.selected_branch_combobox);
            this.Controls.Add(this.selected_branch_label);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(790, 460);
            ((System.ComponentModel.ISupportInitialize)(this.employee_inventory_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selected_branch_label;
        private System.Windows.Forms.ComboBox selected_branch_combobox;
        private System.Windows.Forms.DataGridView employee_inventory_datagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Car_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mileage;
        private System.Windows.Forms.Button inventory_add_button;
        private System.Windows.Forms.Button inventory_edit_button;
        private System.Windows.Forms.Button inventory_delete_button;
    }
}
