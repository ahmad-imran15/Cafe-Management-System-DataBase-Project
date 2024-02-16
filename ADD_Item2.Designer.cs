namespace restaurantSystem
{
    partial class ADD_Item2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.txtitemName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddItem.Location = new System.Drawing.Point(455, 551);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(176, 54);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
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
            this.txtCategory.Location = new System.Drawing.Point(220, 251);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(385, 28);
            this.txtCategory.TabIndex = 5;
            this.txtCategory.StyleChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtitemName
            // 
            this.txtitemName.Location = new System.Drawing.Point(220, 349);
            this.txtitemName.Name = "txtitemName";
            this.txtitemName.Size = new System.Drawing.Size(363, 26);
            this.txtitemName.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(220, 443);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(363, 26);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ADD_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtitemName);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ADD_Item";
            this.Size = new System.Drawing.Size(1164, 672);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox txtCategory;
        private System.Windows.Forms.TextBox txtitemName;
        private System.Windows.Forms.TextBox txtPrice;
    }
}
