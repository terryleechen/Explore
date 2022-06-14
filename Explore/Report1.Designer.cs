﻿namespace Explore
{
    partial class Report1
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
            this.PopularTypeGrid = new System.Windows.Forms.DataGridView();
            this.Type_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberRequests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationBox = new System.Windows.Forms.ComboBox();
            this.RequestedRecieved = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PopularTypeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Time Frame:";
            // 
            // PopularTypeGrid
            // 
            this.PopularTypeGrid.AllowUserToDeleteRows = false;
            this.PopularTypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopularTypeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type_Name,
            this.NumberRequests});
            this.PopularTypeGrid.Location = new System.Drawing.Point(18, 83);
            this.PopularTypeGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PopularTypeGrid.Name = "PopularTypeGrid";
            this.PopularTypeGrid.ReadOnly = true;
            this.PopularTypeGrid.RowHeadersWidth = 51;
            this.PopularTypeGrid.Size = new System.Drawing.Size(735, 282);
            this.PopularTypeGrid.TabIndex = 1;
            this.PopularTypeGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PopularTypeGrid_CellContentClick);
            // 
            // Type_Name
            // 
            this.Type_Name.HeaderText = "Car Type";
            this.Type_Name.MinimumWidth = 6;
            this.Type_Name.Name = "Type_Name";
            this.Type_Name.ReadOnly = true;
            this.Type_Name.Width = 125;
            // 
            // NumberRequests
            // 
            this.NumberRequests.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberRequests.HeaderText = "Total (Company Wide)";
            this.NumberRequests.MinimumWidth = 6;
            this.NumberRequests.Name = "NumberRequests";
            this.NumberRequests.ReadOnly = true;
            // 
            // DurationBox
            // 
            this.DurationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationBox.FormattingEnabled = true;
            this.DurationBox.Items.AddRange(new object[] {
            "This Week (Last 7 Days)",
            "This Month (Last 30 Days)",
            "This Year (Last 365 Days)"});
            this.DurationBox.Location = new System.Drawing.Point(262, 21);
            this.DurationBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(232, 25);
            this.DurationBox.TabIndex = 2;
            this.DurationBox.SelectedIndexChanged += new System.EventHandler(this.DurationBox_SelectedIndexChanged);
            // 
            // RequestedRecieved
            // 
            this.RequestedRecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestedRecieved.FormattingEnabled = true;
            this.RequestedRecieved.Items.AddRange(new object[] {
            "Cars Requested",
            "Cars Received"});
            this.RequestedRecieved.Location = new System.Drawing.Point(521, 21);
            this.RequestedRecieved.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RequestedRecieved.Name = "RequestedRecieved";
            this.RequestedRecieved.Size = new System.Drawing.Size(232, 25);
            this.RequestedRecieved.TabIndex = 3;
            this.RequestedRecieved.SelectedIndexChanged += new System.EventHandler(this.RequestedRecieved_SelectedIndexChanged);
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.RequestedRecieved);
            this.Controls.Add(this.DurationBox);
            this.Controls.Add(this.PopularTypeGrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Report1";
            this.Size = new System.Drawing.Size(790, 460);
            ((System.ComponentModel.ISupportInitialize)(this.PopularTypeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PopularTypeGrid;
        private System.Windows.Forms.ComboBox DurationBox;
        private System.Windows.Forms.ComboBox RequestedRecieved;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberRequests;
    }
}
