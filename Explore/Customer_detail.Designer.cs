namespace Explore
{
    partial class Customer_detail
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
            this.customer_save = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CID_Label = new System.Windows.Forms.Label();
            this.CID_Panel = new System.Windows.Forms.Panel();
            this.CID = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Name_Panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.FirstName_Label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LastName = new System.Windows.Forms.TextBox();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.Address_Panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Address_2 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Address_1 = new System.Windows.Forms.TextBox();
            this.Address_Label = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.City_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PostalCode_Label = new System.Windows.Forms.Label();
            this.Province_Label = new System.Windows.Forms.Label();
            this.Province = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Membership_Label = new System.Windows.Forms.Label();
            this.Membership = new System.Windows.Forms.CheckBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CID_Panel.SuspendLayout();
            this.Name_Panel.SuspendLayout();
            this.Address_Panel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_save
            // 
            this.customer_save.BackColor = System.Drawing.Color.Transparent;
            this.customer_save.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.customer_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.customer_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_save.ForeColor = System.Drawing.Color.SeaShell;
            this.customer_save.Location = new System.Drawing.Point(129, 36);
            this.customer_save.Name = "customer_save";
            this.customer_save.Size = new System.Drawing.Size(82, 40);
            this.customer_save.TabIndex = 9;
            this.customer_save.Text = "Save";
            this.customer_save.UseVisualStyleBackColor = false;
            this.customer_save.Click += new System.EventHandler(this.Button_save_click);
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
            this.button_previous.TabIndex = 8;
            this.button_previous.Text = "Previous";
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.Button_previous_click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // CID_Label
            // 
            this.CID_Label.AutoSize = true;
            this.CID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CID_Label.Location = new System.Drawing.Point(9, 11);
            this.CID_Label.Name = "CID_Label";
            this.CID_Label.Size = new System.Drawing.Size(45, 24);
            this.CID_Label.TabIndex = 10;
            this.CID_Label.Text = "CID:";
            // 
            // CID_Panel
            // 
            this.CID_Panel.Controls.Add(this.panel6);
            this.CID_Panel.Controls.Add(this.CID);
            this.CID_Panel.Controls.Add(this.CID_Label);
            this.CID_Panel.Location = new System.Drawing.Point(26, 94);
            this.CID_Panel.Name = "CID_Panel";
            this.CID_Panel.Size = new System.Drawing.Size(196, 46);
            this.CID_Panel.TabIndex = 11;
            // 
            // CID
            // 
            this.CID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CID.ForeColor = System.Drawing.Color.SeaShell;
            this.CID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CID.Location = new System.Drawing.Point(60, 7);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(125, 22);
            this.CID.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaShell;
            this.panel6.ForeColor = System.Drawing.Color.SeaShell;
            this.panel6.Location = new System.Drawing.Point(60, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(125, 1);
            this.panel6.TabIndex = 12;
            // 
            // Name_Panel
            // 
            this.Name_Panel.Controls.Add(this.panel4);
            this.Name_Panel.Controls.Add(this.LastName);
            this.Name_Panel.Controls.Add(this.LastName_Label);
            this.Name_Panel.Controls.Add(this.panel3);
            this.Name_Panel.Controls.Add(this.FirstName);
            this.Name_Panel.Controls.Add(this.FirstName_Label);
            this.Name_Panel.Location = new System.Drawing.Point(26, 146);
            this.Name_Panel.Name = "Name_Panel";
            this.Name_Panel.Size = new System.Drawing.Size(401, 101);
            this.Name_Panel.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.ForeColor = System.Drawing.Color.SeaShell;
            this.panel3.Location = new System.Drawing.Point(121, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 1);
            this.panel3.TabIndex = 12;
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.SeaShell;
            this.FirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FirstName.Location = new System.Drawing.Point(121, 11);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(185, 22);
            this.FirstName.TabIndex = 11;
            // 
            // FirstName_Label
            // 
            this.FirstName_Label.AutoSize = true;
            this.FirstName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_Label.Location = new System.Drawing.Point(9, 11);
            this.FirstName_Label.Name = "FirstName_Label";
            this.FirstName_Label.Size = new System.Drawing.Size(106, 24);
            this.FirstName_Label.TabIndex = 10;
            this.FirstName_Label.Text = "First Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaShell;
            this.panel4.ForeColor = System.Drawing.Color.SeaShell;
            this.panel4.Location = new System.Drawing.Point(121, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 1);
            this.panel4.TabIndex = 15;
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.ForeColor = System.Drawing.Color.SeaShell;
            this.LastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LastName.Location = new System.Drawing.Point(121, 58);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(185, 22);
            this.LastName.TabIndex = 14;
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_Label.Location = new System.Drawing.Point(9, 58);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(104, 24);
            this.LastName_Label.TabIndex = 13;
            this.LastName_Label.Text = "Last Name:";
            // 
            // Address_Panel
            // 
            this.Address_Panel.Controls.Add(this.panel2);
            this.Address_Panel.Controls.Add(this.Address_2);
            this.Address_Panel.Controls.Add(this.panel5);
            this.Address_Panel.Controls.Add(this.Address_1);
            this.Address_Panel.Controls.Add(this.Address_Label);
            this.Address_Panel.Location = new System.Drawing.Point(26, 253);
            this.Address_Panel.Name = "Address_Panel";
            this.Address_Panel.Size = new System.Drawing.Size(401, 101);
            this.Address_Panel.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.ForeColor = System.Drawing.Color.SeaShell;
            this.panel2.Location = new System.Drawing.Point(121, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 1);
            this.panel2.TabIndex = 15;
            // 
            // Address_2
            // 
            this.Address_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Address_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_2.ForeColor = System.Drawing.Color.SeaShell;
            this.Address_2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Address_2.Location = new System.Drawing.Point(121, 58);
            this.Address_2.Name = "Address_2";
            this.Address_2.Size = new System.Drawing.Size(185, 22);
            this.Address_2.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaShell;
            this.panel5.ForeColor = System.Drawing.Color.SeaShell;
            this.panel5.Location = new System.Drawing.Point(121, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(185, 1);
            this.panel5.TabIndex = 12;
            // 
            // Address_1
            // 
            this.Address_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Address_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_1.ForeColor = System.Drawing.Color.SeaShell;
            this.Address_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Address_1.Location = new System.Drawing.Point(121, 11);
            this.Address_1.Name = "Address_1";
            this.Address_1.Size = new System.Drawing.Size(185, 22);
            this.Address_1.TabIndex = 11;
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_Label.Location = new System.Drawing.Point(9, 11);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(85, 24);
            this.Address_Label.TabIndex = 10;
            this.Address_Label.Text = "Address:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Province);
            this.panel7.Controls.Add(this.Province_Label);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.textBox2);
            this.panel7.Controls.Add(this.PostalCode_Label);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.City_Label);
            this.panel7.Location = new System.Drawing.Point(26, 360);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(440, 86);
            this.panel7.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SeaShell;
            this.panel8.ForeColor = System.Drawing.Color.SeaShell;
            this.panel8.Location = new System.Drawing.Point(60, 34);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(125, 1);
            this.panel8.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SeaShell;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(60, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 11;
            // 
            // City_Label
            // 
            this.City_Label.AutoSize = true;
            this.City_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_Label.Location = new System.Drawing.Point(9, 11);
            this.City_Label.Name = "City_Label";
            this.City_Label.Size = new System.Drawing.Size(45, 24);
            this.City_Label.TabIndex = 10;
            this.City_Label.Text = "City:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.ForeColor = System.Drawing.Color.SeaShell;
            this.panel1.Location = new System.Drawing.Point(121, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 1);
            this.panel1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.SeaShell;
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox2.Location = new System.Drawing.Point(121, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 22);
            this.textBox2.TabIndex = 14;
            // 
            // PostalCode_Label
            // 
            this.PostalCode_Label.AutoSize = true;
            this.PostalCode_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalCode_Label.Location = new System.Drawing.Point(9, 50);
            this.PostalCode_Label.Name = "PostalCode_Label";
            this.PostalCode_Label.Size = new System.Drawing.Size(116, 24);
            this.PostalCode_Label.TabIndex = 13;
            this.PostalCode_Label.Text = "Postal Code:";
            // 
            // Province_Label
            // 
            this.Province_Label.AutoSize = true;
            this.Province_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Province_Label.Location = new System.Drawing.Point(201, 11);
            this.Province_Label.Name = "Province_Label";
            this.Province_Label.Size = new System.Drawing.Size(89, 24);
            this.Province_Label.TabIndex = 16;
            this.Province_Label.Text = "Province:";
            // 
            // Province
            // 
            this.Province.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Province.ForeColor = System.Drawing.Color.SeaShell;
            this.Province.FormattingEnabled = true;
            this.Province.Location = new System.Drawing.Point(296, 12);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(121, 21);
            this.Province.TabIndex = 17;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.Membership);
            this.panel9.Controls.Add(this.Membership_Label);
            this.panel9.Location = new System.Drawing.Point(231, 94);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(196, 46);
            this.panel9.TabIndex = 13;
            // 
            // Membership_Label
            // 
            this.Membership_Label.AutoSize = true;
            this.Membership_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Membership_Label.Location = new System.Drawing.Point(9, 11);
            this.Membership_Label.Name = "Membership_Label";
            this.Membership_Label.Size = new System.Drawing.Size(121, 24);
            this.Membership_Label.TabIndex = 10;
            this.Membership_Label.Text = "Membership:";
            // 
            // Membership
            // 
            this.Membership.Appearance = System.Windows.Forms.Appearance.Button;
            this.Membership.AutoSize = true;
            this.Membership.Location = new System.Drawing.Point(136, 15);
            this.Membership.MaximumSize = new System.Drawing.Size(25, 25);
            this.Membership.MinimumSize = new System.Drawing.Size(20, 20);
            this.Membership.Name = "Membership";
            this.Membership.Size = new System.Drawing.Size(20, 20);
            this.Membership.TabIndex = 11;
            this.Membership.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.textBox4);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Location = new System.Drawing.Point(433, 146);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(337, 56);
            this.panel10.TabIndex = 16;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SeaShell;
            this.panel12.ForeColor = System.Drawing.Color.SeaShell;
            this.panel12.Location = new System.Drawing.Point(152, 38);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(165, 1);
            this.panel12.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.SeaShell;
            this.textBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox4.Location = new System.Drawing.Point(152, 11);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 22);
            this.textBox4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone Number:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.textBox3);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Location = new System.Drawing.Point(433, 208);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(337, 56);
            this.panel11.TabIndex = 17;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.SeaShell;
            this.panel13.ForeColor = System.Drawing.Color.SeaShell;
            this.panel13.Location = new System.Drawing.Point(77, 38);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(240, 1);
            this.panel13.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.SeaShell;
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox3.Location = new System.Drawing.Point(77, 11);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 22);
            this.textBox3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email:";
            // 
            // Customer_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.Address_Panel);
            this.Controls.Add(this.Name_Panel);
            this.Controls.Add(this.CID_Panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customer_save);
            this.Controls.Add(this.button_previous);
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Customer_detail";
            this.Size = new System.Drawing.Size(790, 460);
            this.CID_Panel.ResumeLayout(false);
            this.CID_Panel.PerformLayout();
            this.Name_Panel.ResumeLayout(false);
            this.Name_Panel.PerformLayout();
            this.Address_Panel.ResumeLayout(false);
            this.Address_Panel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customer_save;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CID_Label;
        private System.Windows.Forms.Panel CID_Panel;
        private System.Windows.Forms.TextBox CID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel Name_Panel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label LastName_Label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label FirstName_Label;
        private System.Windows.Forms.Panel Address_Panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Address_2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Address_1;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox Province;
        private System.Windows.Forms.Label Province_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label PostalCode_Label;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label City_Label;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.CheckBox Membership;
        private System.Windows.Forms.Label Membership_Label;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
    }
}
