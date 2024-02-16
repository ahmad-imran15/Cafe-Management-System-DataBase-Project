using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Drawing;
using System.Drawing.Printing;
using DGVPrinterHelper;

namespace restaurantSystem
{
    public partial class PlaceOrder : Form
    {
        string query;
        protected int n, total = 0;
        private int ammount;

        // Assuming you have a SqlConnection somewhere in your application
        private SqlConnection connection;

        public PlaceOrder()
        {
            InitializeComponent();

            // Initialize your SqlConnection
            string connstring = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True";
            connection = new SqlConnection(connstring);
        }

      

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = comboCategory.Text;
            query = "SELECT name FROM items WHERE category = '" + category + "'";
            showItemList(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string category = comboCategory.Text;
            query = "SELECT name FROM items WHERE category = '" + category + "' AND name LIKE '" + txtSearch.Text + "%'";
            showItemList(query);
        }

        private void showItemList(string query)
        {
            listBox1.Items.Clear();

            try
            {
                // Open the connection
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBox1.Items.Add(reader["name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuanitydownUp.ResetText();
            txtTotal.Clear();

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;
            query = "SELECT price FROM items WHERE name = '" + text + "'";

            try
            {
                // Open the connection
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        txtPrice.Text = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void txtQuanitydownUp_ValueChanged(object sender, EventArgs e)
        {
            // Ensure quantity is at least 1
            if (Int64.TryParse(txtQuanitydownUp.Text, out Int64 quan) && quan <= 0)
            {
                txtQuanitydownUp.Text = "0";
                quan = 0;  // Update quan to 1
            }

            UpdateTotal();
        }

        private void UpdateTotal()
        {
            if (!string.IsNullOrEmpty(txtItemName.Text))
            {
                string itemName = txtItemName.Text;

                // Fetch the price from the database using the selected item
                string query = "SELECT price FROM items WHERE name = '" + itemName + "'";

                try
                {
                    // Open the connection
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            Int64 price = Convert.ToInt64(result);
                            txtTotal.Text = (Convert.ToInt64(txtQuanitydownUp.Text) * price).ToString();
                        }
                        else
                        {
                            txtTotal.Text = "Invalid input";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }

                finally
                {
                    // Close the connection
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                txtTotal.Text = "0";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                try
                {
                    n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                    dataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                    dataGridView1.Rows[n].Cells[2].Value = txtQuanitydownUp.Text;
                    dataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                    total += int.Parse(txtTotal.Text);
                    labelTotalammount.Text = "Rs. " + total;

                    // Insert order into the Orders table
                  /*  InsertOrder(
                        txtItemName.Text,
                        int.Parse(txtPrice.Text),
                        int.Parse(txtQuanitydownUp.Text),
                        int.Parse(txtTotal.Text),
                        DateTime.Now
                    );*/

                    // Clear item details after adding to the cart
                    txtItemName.Clear();
                    txtPrice.Clear();
                    txtQuanitydownUp.Text = "1"; // Set quantity to 1
                    txtTotal.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to add to cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Minimum Quantity Needs to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*private void InsertOrder(string itemName, int price, int quantity, int total, DateTime orderDate)
        {
            try
            {
                // Open the connection
                connection.Open();

                // Insert order into the Orders table
                string insertQuery = "INSERT INTO Orders (ItemName, Price, Quantity, Total, OrderDate) VALUES (@ItemName, @Price, @Quantity, @Total, @OrderDate)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", itemName);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Total", total);
                    command.Parameters.AddWithValue("@OrderDate", orderDate);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to insert order: {ex.Message}");
            }
            finally
            {
                // Close the connection
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

*/











        /* private void InsertOrder(string itemName, string priceText, string quantityText, string totalText)
         {
             try
             {
                 // Validate input strings
                 if (!int.TryParse(priceText, out int price) || !int.TryParse(quantityText, out int quantity) || !int.TryParse(totalText, out int total))
                 {
                     MessageBox.Show("Invalid input format. Please enter valid numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                 }

                 // Open the connection
                 connection.Open();

                 // Insert order into the Orders table
                 string insertQuery = "INSERT INTO Orders (ItemName, Price, Quantity, Total, OrderDate) VALUES (@ItemName, @Price, @Quantity, @Total, @OrderDate)";
                 using (SqlCommand command = new SqlCommand(insertQuery, connection))
                 {
                     command.Parameters.AddWithValue("@ItemName", itemName);
                     command.Parameters.AddWithValue("@Price", priceText); // Keep 'priceText' as a string
                     command.Parameters.AddWithValue("@Quantity", quantity);
                     command.Parameters.AddWithValue("@Total", total);
                     command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                     command.ExecuteNonQuery();
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Failed to insert order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             finally
             {
                 // Close the connection
                 if (connection.State == ConnectionState.Open)
                 {
                     connection.Close();
                 }
             }
         }*/







        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            catch
            {
            }

            total -= ammount;
            labelTotalammount.Text = "Rs. " + total;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ammount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           DGVPrinter printer  = new DGVPrinter();




            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date and Time: {0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Ammount: " + labelTotalammount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);

           /* total = 0;
            dataGridView1.Rows.Clear();
            labelTotalammount = "Rs. " + total;
*/


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            decimal totalAmount = Convert.ToDecimal(total);

            AddPayment addPayment = new AddPayment(total);

            this.Hide();
            addPayment.Show();

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        //    main.show();
           

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {

        }

        private void labelTotalammount_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Your custom printing logic goes here
            // Use e.Graphics.DrawString to draw content on the printed page
        }


    }
}
