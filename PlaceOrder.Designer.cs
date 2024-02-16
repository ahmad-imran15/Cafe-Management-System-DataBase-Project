namespace restaurantSystem
{
    partial class PlaceOrder
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
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuanitydownUp = new System.Windows.Forms.NumericUpDown();
            this.btnAddtocart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalammount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuanitydownUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(361, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Cake",
            "Soft Drink",
            "Juice",
            "Asian",
            "Desi",
            "BBQ",
            "Platter"});
            this.comboCategory.Location = new System.Drawing.Point(143, 105);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(169, 28);
            this.comboCategory.TabIndex = 2;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(76, 149);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(236, 32);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Search Item";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(49, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 324);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(830, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(830, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(453, 136);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(253, 35);
            this.txtItemName.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTotal.Location = new System.Drawing.Point(854, 226);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(247, 44);
            this.txtTotal.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPrice.Location = new System.Drawing.Point(854, 120);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(247, 41);
            this.txtPrice.TabIndex = 11;
            // 
            // txtQuanitydownUp
            // 
            this.txtQuanitydownUp.Location = new System.Drawing.Point(453, 226);
            this.txtQuanitydownUp.Name = "txtQuanitydownUp";
            this.txtQuanitydownUp.Size = new System.Drawing.Size(203, 26);
            this.txtQuanitydownUp.TabIndex = 12;
            this.txtQuanitydownUp.ValueChanged += new System.EventHandler(this.txtQuanitydownUp_ValueChanged);
            // 
            // btnAddtocart
            // 
            this.btnAddtocart.BackColor = System.Drawing.Color.Black;
            this.btnAddtocart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtocart.ForeColor = System.Drawing.Color.White;
            this.btnAddtocart.Location = new System.Drawing.Point(885, 290);
            this.btnAddtocart.Name = "btnAddtocart";
            this.btnAddtocart.Size = new System.Drawing.Size(171, 37);
            this.btnAddtocart.TabIndex = 13;
            this.btnAddtocart.Text = "Add To Cart";
            this.btnAddtocart.UseVisualStyleBackColor = false;
            this.btnAddtocart.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(361, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(723, 186);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(899, 556);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(175, 51);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print Receipt";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Black;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(415, 549);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 47);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(661, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Grand Total";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelTotalammount
            // 
            this.labelTotalammount.BackColor = System.Drawing.Color.Tan;
            this.labelTotalammount.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.labelTotalammount.ForeColor = System.Drawing.Color.Brown;
            this.labelTotalammount.Location = new System.Drawing.Point(629, 563);
            this.labelTotalammount.Name = "labelTotalammount";
            this.labelTotalammount.Size = new System.Drawing.Size(185, 60);
            this.labelTotalammount.TabIndex = 18;
            this.labelTotalammount.Text = "Rs.00";
            this.labelTotalammount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotalammount.Click += new System.EventHandler(this.labelTotalammount_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(420, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Black;
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddItem.Location = new System.Drawing.Point(83, 556);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(105, 40);
            this.btnAddItem.TabIndex = 20;
            this.btnAddItem.Text = "Back";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 62);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(426, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Name";
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::restaurantSystem.Properties.Resources.WhatsApp_Image_2023_12_01_at_13_20_10_ad8f852c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 855);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTotalammount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddtocart);
            this.Controls.Add(this.txtQuanitydownUp);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PlaceOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaceOrder";
            this.Load += new System.EventHandler(this.PlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuanitydownUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.NumericUpDown txtQuanitydownUp;
        private System.Windows.Forms.Button btnAddtocart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalammount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
    }
}