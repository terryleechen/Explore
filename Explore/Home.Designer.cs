namespace Explore
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.main_car_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.main_car_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // main_car_picture
            // 
            this.main_car_picture.Image = ((System.Drawing.Image)(resources.GetObject("main_car_picture.Image")));
            this.main_car_picture.Location = new System.Drawing.Point(200, 21);
            this.main_car_picture.Name = "main_car_picture";
            this.main_car_picture.Size = new System.Drawing.Size(414, 418);
            this.main_car_picture.TabIndex = 0;
            this.main_car_picture.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.main_car_picture);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(790, 460);
            ((System.ComponentModel.ISupportInitialize)(this.main_car_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox main_car_picture;
    }
}
