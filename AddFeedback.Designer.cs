namespace restaurantSystem
{
    partial class AddFeedback
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "FeedBack:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(404, 287);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(280, 41);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(404, 365);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(280, 41);
            this.txtFeedback.TabIndex = 3;
            this.txtFeedback.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(404, 204);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(280, 41);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(521, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save FeedBack";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(96, 499);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(113, 54);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(23, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 63);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 48);
            this.label4.TabIndex = 44;
            this.label4.Text = "FeedBack";
            // 
            // AddFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantSystem.Properties.Resources.WhatsApp_Image_2023_12_01_at_13_20_10_ad8f852c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 855);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFeedback";
            this.Load += new System.EventHandler(this.AddFeedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}