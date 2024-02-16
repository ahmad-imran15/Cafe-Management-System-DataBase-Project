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
    public partial class Menu : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True;");

        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            DisplayMenuItems();
        }

        public void DisplayMenuItems()
        {
            try
            {
                connection.Open();

                string selectQuery = "SELECT name, category, price FROM items";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {




            if (Global.UserID.Trim().Equals("Admin"))
            {

                this.Hide();
                Main main = new Main();
                main.Show();


            }

            else if (Global.UserID.Trim().Equals("Cashier"))
            {

                this.Hide();
                Cashier cashier = new Cashier();
                cashier.Show();


            }

            else if (Global.UserID.Trim().Equals("Rider"))
            {

                this.Hide();
                Rider rider = new Rider();
                rider.Show();


            }

            else if (Global.UserID.Trim().Equals("Waiter"))
            {


                this.Hide();
                Waiter waiter = new Waiter();
                waiter.Show();

            }

            else if (Global.UserID.Trim().Equals("Chef"))
            {


                this.Hide();
                Chef chef = new Chef();
                chef.Show();



            }
        }
        private void Menu_load(object sender, EventArgs e)
        {
            user_table.DataSource = userlist();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True;"))
                {
                    connection.Open();

                    // Select all items from the Items table
                    string selectQuery = "SELECT name, category, price FROM items";
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

        private DataTable userlist()
        {


            DB db = new DB();


            DataTable table = new DataTable();



            SqlCommand command = new SqlCommand("SELECT * FROM items", db.getConnection());


            db.openConnection();


            SqlDataReader rdr = command.ExecuteReader();

            table.Load(rdr);

            return table;
        }


        private void button1_Click(object sender, EventArgs e)
        {
           // Cashier cashier = new Cashier();
            this.Hide();
            //cashier.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
