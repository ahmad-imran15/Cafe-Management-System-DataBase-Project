namespace restaurantSystem
{
    partial class AddUsers
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFirstName.Location = new System.Drawing.Point(340, 158);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(302, 28);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.Text = "first name";
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxFirstName.Enter += new System.EventHandler(this.textBoxFirstName_Enter);
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBoxFirstName_Leave);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastname.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLastname.Location = new System.Drawing.Point(716, 158);
            this.textBoxLastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(283, 28);
            this.textBoxLastname.TabIndex = 1;
            this.textBoxLastname.Text = "last name";
            this.textBoxLastname.TextChanged += new System.EventHandler(this.textBoxLastname_TextChanged);
            this.textBoxLastname.Enter += new System.EventHandler(this.textBoxLastname_Enter);
            this.textBoxLastname.Leave += new System.EventHandler(this.textBoxLastname_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(340, 218);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(658, 28);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.Text = "email address";
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(340, 274);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(658, 28);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "username";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(783, 656);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(215, 48);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Create Account";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textpassword
            // 
            this.textpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpassword.ForeColor = System.Drawing.Color.Gray;
            this.textpassword.Location = new System.Drawing.Point(340, 337);
            this.textpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(658, 28);
            this.textpassword.TabIndex = 4;
            this.textpassword.Text = "password";
            this.textpassword.UseSystemPasswordChar = true;
            this.textpassword.TextChanged += new System.EventHandler(this.textpassword_TextChanged);
            this.textpassword.Enter += new System.EventHandler(this.textpassword_Enter);
            this.textpassword.Leave += new System.EventHandler(this.textpassword_Leave);
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordConfirm.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(340, 392);
            this.textBoxPasswordConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(658, 28);
            this.textBoxPasswordConfirm.TabIndex = 5;
            this.textBoxPasswordConfirm.Text = "confirm password";
            this.textBoxPasswordConfirm.UseSystemPasswordChar = true;
            this.textBoxPasswordConfirm.TextChanged += new System.EventHandler(this.textBoxPasswordConfirm_TextChanged);
            this.textBoxPasswordConfirm.Enter += new System.EventHandler(this.textBoxPasswordConfirm_Enter);
            this.textBoxPasswordConfirm.Leave += new System.EventHandler(this.textBoxPasswordConfirm_Leave);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.back_btn.Location = new System.Drawing.Point(91, 656);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(136, 48);
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(25, 110);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 366);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 397);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Re-enter Password";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(25, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 63);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantSystem.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 855);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.textBoxFirstName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUsers";
            this.Load += new System.EventHandler(this.AddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
    }
    }