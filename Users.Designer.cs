namespace restaurantSystem
{
    partial class Users
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
            this.user_table = new System.Windows.Forms.DataGridView();
            this.adduser_btn = new System.Windows.Forms.Button();
            this.removeuser_btn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(167, 641);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(112, 35);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // user_table
            // 
            this.user_table.AllowUserToAddRows = false;
            this.user_table.AllowUserToDeleteRows = false;
            this.user_table.AllowUserToResizeColumns = false;
            this.user_table.AllowUserToResizeRows = false;
            this.user_table.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.user_table.BackgroundColor = System.Drawing.Color.White;
            this.user_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_table.GridColor = System.Drawing.Color.Black;
            this.user_table.Location = new System.Drawing.Point(123, 105);
            this.user_table.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_table.MultiSelect = false;
            this.user_table.Name = "user_table";
            this.user_table.RowHeadersWidth = 62;
            this.user_table.Size = new System.Drawing.Size(990, 458);
            this.user_table.TabIndex = 5;
            this.user_table.AllowUserToAddRowsChanged += new System.EventHandler(this.user_table_AllowUserToAddRowsChanged);
            this.user_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adduser_btn
            // 
            this.adduser_btn.Location = new System.Drawing.Point(764, 605);
            this.adduser_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adduser_btn.Name = "adduser_btn";
            this.adduser_btn.Size = new System.Drawing.Size(112, 35);
            this.adduser_btn.TabIndex = 1;
            this.adduser_btn.Text = "Add";
            this.adduser_btn.UseVisualStyleBackColor = true;
            this.adduser_btn.Click += new System.EventHandler(this.adduser_btn_Click);
            // 
            // removeuser_btn
            // 
            this.removeuser_btn.Location = new System.Drawing.Point(981, 605);
            this.removeuser_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeuser_btn.Name = "removeuser_btn";
            this.removeuser_btn.Size = new System.Drawing.Size(112, 35);
            this.removeuser_btn.TabIndex = 2;
            this.removeuser_btn.Text = "Remove";
            this.removeuser_btn.UseVisualStyleBackColor = true;
            this.removeuser_btn.Click += new System.EventHandler(this.removeuser_btn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(21, 23);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 63);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantSystem.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 855);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.removeuser_btn);
            this.Controls.Add(this.adduser_btn);
            this.Controls.Add(this.user_table);
            this.Controls.Add(this.back_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView user_table;
        private System.Windows.Forms.Button adduser_btn;
        private System.Windows.Forms.Button removeuser_btn;
        private System.Windows.Forms.Button btnExit;
    }
}