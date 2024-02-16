namespace restaurantSystem
{
    partial class AddPayment
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
            this.back_btn = new System.Windows.Forms.Button();
            this.addpayment_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ap_timestamp = new System.Windows.Forms.TextBox();
            this.ap_total = new System.Windows.Forms.TextBox();
            this.ap_balance = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ap_comboBox = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(183, 586);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(152, 58);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // addpayment_btn
            // 
            this.addpayment_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addpayment_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addpayment_btn.Location = new System.Drawing.Point(886, 586);
            this.addpayment_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addpayment_btn.Name = "addpayment_btn";
            this.addpayment_btn.Size = new System.Drawing.Size(152, 58);
            this.addpayment_btn.TabIndex = 5;
            this.addpayment_btn.Text = "Add Payment";
            this.addpayment_btn.UseVisualStyleBackColor = false;
            this.addpayment_btn.Click += new System.EventHandler(this.addpayment_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(230, 356);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Timestamp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(230, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Account No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Method:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total Amount:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ap_timestamp
            // 
            this.ap_timestamp.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ap_timestamp.ForeColor = System.Drawing.Color.Black;
            this.ap_timestamp.Location = new System.Drawing.Point(435, 348);
            this.ap_timestamp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ap_timestamp.Multiline = true;
            this.ap_timestamp.Name = "ap_timestamp";
            this.ap_timestamp.Size = new System.Drawing.Size(593, 38);
            this.ap_timestamp.TabIndex = 4;
            this.ap_timestamp.Text = "e.g. 2020-10-10 18:29:13";
            this.ap_timestamp.TextChanged += new System.EventHandler(this.ap_timestamp_TextChanged);
            this.ap_timestamp.Enter += new System.EventHandler(this.ap_timestamp_Enter);
            this.ap_timestamp.Leave += new System.EventHandler(this.ap_timestamp_Leave);
            // 
            // ap_total
            // 
            this.ap_total.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ap_total.Location = new System.Drawing.Point(435, 278);
            this.ap_total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ap_total.Multiline = true;
            this.ap_total.Name = "ap_total";
            this.ap_total.Size = new System.Drawing.Size(593, 38);
            this.ap_total.TabIndex = 3;
            this.ap_total.TextChanged += new System.EventHandler(this.ap_total_TextChanged);
            // 
            // ap_balance
            // 
            this.ap_balance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ap_balance.Location = new System.Drawing.Point(435, 213);
            this.ap_balance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ap_balance.Multiline = true;
            this.ap_balance.Name = "ap_balance";
            this.ap_balance.Size = new System.Drawing.Size(593, 38);
            this.ap_balance.TabIndex = 2;
            this.ap_balance.Text = "Enter Account Number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(88, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 369);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ap_comboBox
            // 
            this.ap_comboBox.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ap_comboBox.FormattingEnabled = true;
            this.ap_comboBox.Items.AddRange(new object[] {
            "Debit Card",
            "Credit Card",
            "JazzCash",
            "EasyPaisa",
            "NayaPay"});
            this.ap_comboBox.Location = new System.Drawing.Point(435, 151);
            this.ap_comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ap_comboBox.Name = "ap_comboBox";
            this.ap_comboBox.Size = new System.Drawing.Size(593, 31);
            this.ap_comboBox.TabIndex = 1;
            this.ap_comboBox.Text = "Choose a method";
            this.ap_comboBox.SelectedIndexChanged += new System.EventHandler(this.ap_comboBox_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 63);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantSystem.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 855);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ap_comboBox);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.addpayment_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ap_timestamp);
            this.Controls.Add(this.ap_total);
            this.Controls.Add(this.ap_balance);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPayment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button addpayment_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ap_timestamp;
        private System.Windows.Forms.TextBox ap_total;
        private System.Windows.Forms.TextBox ap_balance;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ap_comboBox;
        private System.Windows.Forms.Button btnExit;
    }
}