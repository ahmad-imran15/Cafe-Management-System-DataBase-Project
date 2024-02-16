namespace restaurantSystem
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtitemName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(45, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Black;
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddItem.Location = new System.Drawing.Point(336, 455);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(176, 54);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(63, 404);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(363, 26);
            this.txtPrice.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "Price";
            // 
            // txtitemName
            // 
            this.txtitemName.Location = new System.Drawing.Point(63, 309);
            this.txtitemName.Name = "txtitemName";
            this.txtitemName.Size = new System.Drawing.Size(363, 26);
            this.txtitemName.TabIndex = 2;
            // 
            // txtCategory
            // 
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Items.AddRange(new object[] {
            "Cake",
            "Soft Drink",
            "Juice",
            "Asian",
            "Desi",
            "BBQ",
            "Platter"});
            this.txtCategory.Location = new System.Drawing.Point(63, 187);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(385, 28);
            this.txtCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 39);
            this.label3.TabIndex = 17;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "item Name";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 63);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantSystem.Properties.Resources.WhatsApp_Image_2023_12_01_at_13_20_10_ad8f852c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 855);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtitemName);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtitemName;
        private System.Windows.Forms.ComboBox txtCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
    }
}