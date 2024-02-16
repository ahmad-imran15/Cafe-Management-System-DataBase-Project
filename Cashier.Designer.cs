namespace restaurantSystem
{
    partial class Cashier
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu_btn = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_btn
            // 
            this.menu_btn.BackColor = System.Drawing.Color.Transparent;
            this.menu_btn.BackgroundImage = global::restaurantSystem.Properties.Resources.ssdf;
            this.menu_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btn.Location = new System.Drawing.Point(603, 306);
            this.menu_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(159, 155);
            this.menu_btn.TabIndex = 2;
            this.menu_btn.UseVisualStyleBackColor = false;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // info_btn
            // 
            this.info_btn.BackgroundImage = global::restaurantSystem.Properties.Resources.Capture;
            this.info_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.info_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info_btn.Location = new System.Drawing.Point(362, 306);
            this.info_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(159, 155);
            this.info_btn.TabIndex = 1;
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(469, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 41);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hi Cashier!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::restaurantSystem.Properties.Resources.supermarket_cashier1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(499, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 125);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(155, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(856, 203);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(158, 738);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(112, 35);
            this.logout_btn.TabIndex = 38;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(193, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "LogOut";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 63);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantSystem.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 855);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.menu_btn);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button menu_btn;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
    }
}