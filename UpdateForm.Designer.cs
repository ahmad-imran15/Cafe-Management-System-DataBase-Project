namespace restaurantSystem
{
    partial class UpdateForm
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
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(767, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Location = new System.Drawing.Point(737, 112);
            this.txtSearchItem.Multiline = true;
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(272, 38);
            this.txtSearchItem.TabIndex = 1;
            this.txtSearchItem.TextChanged += new System.EventHandler(this.txtSearchItem_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(142, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(760, 230);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(162, 455);
            this.txtCategory.Multiline = true;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(272, 38);
            this.txtCategory.TabIndex = 2;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 544);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 38);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(610, 466);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(272, 38);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(605, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(798, 563);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 56);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 63);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(95, 627);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(109, 46);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::restaurantSystem.Properties.Resources.WhatsApp_Image_2023_12_01_at_13_20_10_ad8f852c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 855);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearchItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button back_btn;
    }
}