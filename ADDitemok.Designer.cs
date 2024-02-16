namespace restaurantSystem
{
    partial class ADDitemok
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtitemName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtitemName);
            this.panel1.Controls.Add(this.txtCategory);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 598);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(592, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Item";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(319, 394);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(363, 26);
            this.txtPrice.TabIndex = 14;
            // 
            // txtitemName
            // 
            this.txtitemName.Location = new System.Drawing.Point(319, 294);
            this.txtitemName.Name = "txtitemName";
            this.txtitemName.Size = new System.Drawing.Size(363, 26);
            this.txtitemName.TabIndex = 13;
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
            this.txtCategory.Location = new System.Drawing.Point(319, 200);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(385, 28);
            this.txtCategory.TabIndex = 12;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddItem.Location = new System.Drawing.Point(491, 462);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(176, 59);
            this.btnAddItem.TabIndex = 11;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "item Name";
            // 
            // ADDitemok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 666);
            this.Controls.Add(this.panel1);
            this.Name = "ADDitemok";
            this.Text = "ADDitemok";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtitemName;
        private System.Windows.Forms.ComboBox txtCategory;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}