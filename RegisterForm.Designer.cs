namespace restaurantSystem
{
    partial class RegisterForm
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFirstName.Location = new System.Drawing.Point(327, 262);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(306, 26);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Text = "first name";
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxFirstName.Enter += new System.EventHandler(this.textBoxFirstName_Enter);
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBoxFirstName_Leave);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLastname.Location = new System.Drawing.Point(676, 262);
            this.textBoxLastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(308, 26);
            this.textBoxLastname.TabIndex = 2;
            this.textBoxLastname.Text = "last name";
            this.textBoxLastname.TextChanged += new System.EventHandler(this.textBoxLastname_TextChanged);
            this.textBoxLastname.Enter += new System.EventHandler(this.textBoxLastname_Enter);
            this.textBoxLastname.Leave += new System.EventHandler(this.textBoxLastname_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(327, 322);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(658, 26);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.Text = "email address";
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(327, 377);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(658, 26);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "username";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(488, 549);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(346, 58);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Create Account";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textpassword
            // 
            this.textpassword.ForeColor = System.Drawing.Color.Gray;
            this.textpassword.Location = new System.Drawing.Point(327, 440);
            this.textpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.Size = new System.Drawing.Size(658, 26);
            this.textpassword.TabIndex = 5;
            this.textpassword.Text = "\r\nPASSWORD";
            this.textpassword.UseSystemPasswordChar = true;
            this.textpassword.TextChanged += new System.EventHandler(this.textpassword_TextChanged);
            this.textpassword.Enter += new System.EventHandler(this.textpassword_Enter);
            this.textpassword.Leave += new System.EventHandler(this.textpassword_Leave);
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(327, 495);
            this.textBoxPasswordConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.PasswordChar = '*';
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(658, 26);
            this.textBoxPasswordConfirm.TabIndex = 6;
            this.textBoxPasswordConfirm.Text = "confirm password";
            this.textBoxPasswordConfirm.UseSystemPasswordChar = true;
            this.textBoxPasswordConfirm.TextChanged += new System.EventHandler(this.textBoxPasswordConfirm_TextChanged);
            this.textBoxPasswordConfirm.Enter += new System.EventHandler(this.textBoxPasswordConfirm_Enter);
            this.textBoxPasswordConfirm.Leave += new System.EventHandler(this.textBoxPasswordConfirm_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(103, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 54);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(219, 106);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 71);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Register Account";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 63);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantSystem.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 855);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.textBoxFirstName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textpassword;
    }
}