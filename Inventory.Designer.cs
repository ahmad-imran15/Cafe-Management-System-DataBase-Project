namespace restaurantSystem
{
    partial class Inventory
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
            this.item_table = new System.Windows.Forms.DataGridView();
            this.additem_btn = new System.Windows.Forms.Button();
            this.removeitem_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.item_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(327, 424);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(112, 35);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // item_table
            // 
            this.item_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.item_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.item_table.BackgroundColor = System.Drawing.Color.White;
            this.item_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_table.GridColor = System.Drawing.Color.Black;
            this.item_table.Location = new System.Drawing.Point(195, 38);
            this.item_table.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.item_table.Name = "item_table";
            this.item_table.RowHeadersWidth = 62;
            this.item_table.Size = new System.Drawing.Size(859, 345);
            this.item_table.TabIndex = 5;
            this.item_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.item_table_CellContentClick);
            // 
            // additem_btn
            // 
            this.additem_btn.Location = new System.Drawing.Point(740, 496);
            this.additem_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.additem_btn.Name = "additem_btn";
            this.additem_btn.Size = new System.Drawing.Size(112, 35);
            this.additem_btn.TabIndex = 1;
            this.additem_btn.Text = "Add";
            this.additem_btn.UseVisualStyleBackColor = true;
            this.additem_btn.Click += new System.EventHandler(this.additem_btn_Click);
            // 
            // removeitem_btn
            // 
            this.removeitem_btn.Location = new System.Drawing.Point(909, 496);
            this.removeitem_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeitem_btn.Name = "removeitem_btn";
            this.removeitem_btn.Size = new System.Drawing.Size(112, 35);
            this.removeitem_btn.TabIndex = 2;
            this.removeitem_btn.Text = "Remove";
            this.removeitem_btn.UseVisualStyleBackColor = true;
            this.removeitem_btn.Click += new System.EventHandler(this.removeitem_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(772, 412);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Low Stock : None";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(764, 403);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 56);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 63);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantSystem.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 855);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeitem_btn);
            this.Controls.Add(this.additem_btn);
            this.Controls.Add(this.item_table);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.item_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView item_table;
        private System.Windows.Forms.Button additem_btn;
        private System.Windows.Forms.Button removeitem_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
    }
}