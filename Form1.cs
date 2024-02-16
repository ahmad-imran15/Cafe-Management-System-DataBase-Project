using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO dbo.items (name, category, price) VALUES (@itemName, @category, @price)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@itemName", SqlDbType.VarChar).Value = txtitemName.Text;
                        command.Parameters.Add("@category", SqlDbType.VarChar).Value = txtCategory.Text;
                        command.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPrice.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Clear input fields after successful insertion
                            /*txtItemName.Clear();
                            txtCategory.Clear();
                            txtPrice.Clear();*/
                        }
                        else
                        {
                            MessageBox.Show("Failed to add item. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO dbo.items (name, category, price) VALUES (@itemName, @category, @price)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@itemName", SqlDbType.VarChar).Value = txtitemName.Text;
                    command.Parameters.Add("@category", SqlDbType.VarChar).Value = txtCategory.Text;
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPrice.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Clear input fields after successful insertion
                        /*txtItemName.Clear();
                        txtCategory.Clear();
                        txtPrice.Clear();*/
                    }
                    else
                    {
                        MessageBox.Show("Failed to add item. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assume you have a variable 'username' containing the logged-in username
            string username = "admin";

            if (username.ToLower() == "admin")
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            if (username.ToLower() == "cashier")
                this.Hide();
            Cashier cashier = new Cashier();
            cashier.Show();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cashier cashier1 = new Cashier();
            this.Hide();
            cashier1.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
