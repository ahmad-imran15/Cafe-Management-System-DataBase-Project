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
    public partial class Feedbackshow : Form
    {
        public Feedbackshow()
        {
            InitializeComponent();

            // Manually call the method to load data
            LoadFeedbackData();
        }

        private void LoadFeedbackData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True;"))
                {
                    connection.Open();

                    // Select all items from the Feedback table
                    string selectQuery = "SELECT ProductName, CustomerName, FeedBackText FROM Feedback";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Set the DataGridView's data source to the retrieved data
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True;"))
                    {
                        connection.Open();

                        // Select all items from the Items table
                        string selectQuery = "SELECT ProductName, CustomerName, FeedBackText FROM Feedback";
                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);

                                // Set the DataGridView's data source to the retrieved data
                                dataGridView1.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to retrieve items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

