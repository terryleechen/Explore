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
            this.components = new System.ComponentModel.Container();
            this.selected_branch_label = new System.Windows.Forms.Label();
            this.selected_branch_combobox = new System.Windows.Forms.ComboBox();
            this.inventory_add_button = new System.Windows.Forms.Button();
            this.inventory_edit_button = new System.Windows.Forms.Button();
            this.inventory_delete_button = new System.Windows.Forms.Button();
            this.exploredatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.explore_dataset = new Explore.explore_dataset();
            this.exploredatasetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new Explore.explore_datasetTableAdapters.CarTableAdapter();
            this.tableAdapterManager = new Explore.explore_datasetTableAdapters.TableAdapterManager();
            this.carDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.exploredatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explore_dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exploredatasetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).BeginInit();
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
            this.selected_branch_combobox.DataSource = this.exploredatasetBindingSource;
            this.selected_branch_combobox.FormattingEnabled = true;
            this.selected_branch_combobox.Location = new System.Drawing.Point(258, 23);
            this.selected_branch_combobox.Name = "selected_branch_combobox";
            this.selected_branch_combobox.Size = new System.Drawing.Size(242, 21);
            this.selected_branch_combobox.TabIndex = 1;
            this.selected_branch_combobox.SelectedIndexChanged += new System.EventHandler(this.selected_branch_combobox_SelectedIndexChanged);
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
            // exploredatasetBindingSource
            // 
            this.exploredatasetBindingSource.DataSource = this.explore_dataset;
            this.exploredatasetBindingSource.Position = 0;
            // 
            // explore_dataset
            // 
            this.explore_dataset.DataSetName = "explore_dataset";
            this.explore_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exploredatasetBindingSource1
            // 
            this.exploredatasetBindingSource1.DataSource = this.explore_dataset;
            this.exploredatasetBindingSource1.Position = 0;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.explore_dataset;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Branch_PhoneTableAdapter = null;
            this.tableAdapterManager.BranchTableAdapter = null;
            this.tableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.Customer_PhoneTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.Employee_PhoneTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.Rental_TransactionTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Explore.explore_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carDataGridView
            // 
            this.carDataGridView.AutoGenerateColumns = false;
            this.carDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.carDataGridView.DataSource = this.carBindingSource;
            this.carDataGridView.Location = new System.Drawing.Point(32, 60);
            this.carDataGridView.Name = "carDataGridView";
            this.carDataGridView.Size = new System.Drawing.Size(743, 349);
            this.carDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Car_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Car_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BID";
            this.dataGridViewTextBoxColumn2.HeaderText = "BID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Type_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type_ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn4.HeaderText = "Year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Brand";
            this.dataGridViewTextBoxColumn5.HeaderText = "Brand";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn6.HeaderText = "Model";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Mileage";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mileage";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.carDataGridView);
            this.Controls.Add(this.inventory_delete_button);
            this.Controls.Add(this.inventory_edit_button);
            this.Controls.Add(this.inventory_add_button);
            this.Controls.Add(this.selected_branch_combobox);
            this.Controls.Add(this.selected_branch_label);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(929, 460);
            ((System.ComponentModel.ISupportInitialize)(this.exploredatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explore_dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exploredatasetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selected_branch_label;
        private System.Windows.Forms.ComboBox selected_branch_combobox;
        private System.Windows.Forms.Button inventory_add_button;
        private System.Windows.Forms.Button inventory_edit_button;
        private System.Windows.Forms.Button inventory_delete_button;
        private System.Windows.Forms.BindingSource exploredatasetBindingSource;
        private explore_dataset explore_dataset;
        private System.Windows.Forms.BindingSource exploredatasetBindingSource1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private explore_datasetTableAdapters.CarTableAdapter carTableAdapter;
        private explore_datasetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView carDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}
