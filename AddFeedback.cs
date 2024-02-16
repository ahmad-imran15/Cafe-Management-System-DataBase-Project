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
    public partial class AddFeedback : Form
    {
        public AddFeedback()
        {
            InitializeComponent();  
        }

        private void AddFeedback_Load(object sender, EventArgs e)
        {

        }

        private void SaveFeedbackToDatabase(string productName, string customerName, string feedback)
        {
            try

            {
                using (SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True"))
                {


               
                    connection.Open();

                    string insertQuery = "INSERT INTO Feedback (ProductName, CustomerName, FeedbackText) VALUES (@ProductName, @CustomerName, @Feedback)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@Feedback", feedback);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Feedback saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call the method to save feedback to the database
            SaveFeedbackToDatabase(txtProductName.Text, txtCustomerName.Text, txtFeedback.Text);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chef chef = new Chef();
            chef.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
