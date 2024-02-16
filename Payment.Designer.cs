namespace restaurantSystem
{
    partial class Payment
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
            this.payment_table = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.payment_table)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(155, 642);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(112, 35);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // payment_table
            // 
            this.payment_table.AllowUserToAddRows = false;
            this.payment_table.AllowUserToDeleteRows = false;
            this.payment_table.AllowUserToResizeColumns = false;
            this.payment_table.AllowUserToResizeRows = false;
            this.payment_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payment_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.payment_table.BackgroundColor = System.Drawing.Color.White;
            this.payment_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payment_table.GridColor = System.Drawing.Color.Black;
            this.payment_table.Location = new System.Drawing.Point(121, 154);
            this.payment_table.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.payment_table.Name = "payment_table";
            this.payment_table.RowHeadersWidth = 62;
            this.payment_table.Size = new System.Drawing.Size(1060, 440);
            this.payment_table.TabIndex = 3;
            this.payment_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payment_table_CellContentClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(23, 32);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 63);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 48);
            this.label4.TabIndex = 45;
            this.label4.Text = "Payments";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantSystem.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 855);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.payment_table);
            this.Controls.Add(this.back_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payment_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView payment_table;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
    }
}