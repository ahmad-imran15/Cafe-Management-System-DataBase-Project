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
    public partial class ADDitemok : Form
    {
        public ADDitemok()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
      


        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtitemName.Clear();
            txtPrice.Clear();
        }

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO items (name, category, price) VALUES (@itemName, @category, @price)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Assuming txtitemName, txtCategory, and txtPrice are TextBox controls on your form
                        command.Parameters.Add("@itemName", SqlDbType.VarChar).Value = txtitemName.Text;
                        command.Parameters.Add("@category", SqlDbType.VarChar).Value = txtCategory.Text;
                        command.Parameters.Add("@price", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPrice.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearAll(); // Clear input fields after successful insertion
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


    }
}
