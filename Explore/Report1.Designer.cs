namespace Explore
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
            this.DurationBox = new System.Windows.Forms.ComboBox();
            this.CarData = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.BranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberRequests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PopularTypeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(89, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Time Frame:";
            // 
            // PopularTypeGrid
            // 
            this.PopularTypeGrid.AllowUserToDeleteRows = false;
            this.PopularTypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopularTypeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BranchName,
            this.data,
            this.NumberRequests});
            this.PopularTypeGrid.Location = new System.Drawing.Point(93, 113);
            this.PopularTypeGrid.Name = "PopularTypeGrid";
            this.PopularTypeGrid.ReadOnly = true;
            this.PopularTypeGrid.Size = new System.Drawing.Size(551, 229);
            this.PopularTypeGrid.TabIndex = 1;
            // 
            // DurationBox
            // 
            this.DurationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationBox.FormattingEnabled = true;
            this.DurationBox.Items.AddRange(new object[] {
            "This Week (Last 7 Days)",
            "This Month (Last 30 Days)",
            "This Year (Last 365 Days)"});
            this.DurationBox.Location = new System.Drawing.Point(287, 19);
            this.DurationBox.Name = "DurationBox";
            this.DurationBox.Size = new System.Drawing.Size(175, 21);
            this.DurationBox.TabIndex = 2;
            this.DurationBox.SelectedIndexChanged += new System.EventHandler(this.DurationBox_SelectedIndexChanged);
            // 
            // CarData
            // 
            this.CarData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarData.FormattingEnabled = true;
            this.CarData.Items.AddRange(new object[] {
            "Year",
            "Brand",
            "Model",
            "Type"});
            this.CarData.Location = new System.Drawing.Point(287, 73);
            this.CarData.Name = "CarData";
            this.CarData.Size = new System.Drawing.Size(175, 21);
            this.CarData.TabIndex = 4;
            this.CarData.SelectedIndexChanged += new System.EventHandler(this.CarData_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(89, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search By:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(545, 71);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // BranchName
            // 
            this.BranchName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BranchName.HeaderText = "Branch Name";
            this.BranchName.Name = "BranchName";
            this.BranchName.ReadOnly = true;
            this.BranchName.Width = 97;
            // 
            // data
            // 
            this.data.HeaderText = "Data Type";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // NumberRequests
            // 
            this.NumberRequests.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberRequests.HeaderText = "Total (Company Wide)";
            this.NumberRequests.Name = "NumberRequests";
            this.NumberRequests.ReadOnly = true;
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CarData);
            this.Controls.Add(this.DurationBox);
            this.Controls.Add(this.PopularTypeGrid);
            this.Controls.Add(this.label1);
            this.Name = "Report1";
            this.Size = new System.Drawing.Size(790, 386);
            ((System.ComponentModel.ISupportInitialize)(this.PopularTypeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PopularTypeGrid;
        private System.Windows.Forms.ComboBox DurationBox;
        private System.Windows.Forms.ComboBox CarData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberRequests;
    }
}
