
using MySql.Data.MySqlClient;
using Sitecore.FakeDb;
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
using System.Windows.Media.TextFormatting;

namespace restaurantSystem
{
    

    public partial class User : Form
    {
        //  SqlConnection conn;
        string connstring = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True";


        public User()
        {
            InitializeComponent();
            this.txtPassword.AutoSize = false;
            this.txtPassword.Size = new Size(this.txtPassword.Size.Width, 20);
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlConnection conn = db.getConnection();

            if (conn != null)
            {
                try
                {
                    db.openConnection(); // Open the connection

                    String username = txtUsername.Text;
                    String password = txtPassword.Text;

                    Global.Gusername = txtUsername.Text.ToString();
                    DataTable table = new DataTable();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand("SELECT * FROM users WHERE username = @usn", conn);

                    command.Parameters.Add("@usn", SqlDbType.VarChar).Value = username;

                    adapter.SelectCommand = command;

                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        string actualPassword = table.Rows[0]["password"].ToString(); // Retrieve password from the result set
                        string category = table.Rows[0]["category"].ToString(); // Retrieve category from the result set

                        switch (category.Trim().ToLower())
                        {
                            case "admin":
                                if (username.ToLower() == "admin" && password == actualPassword)
                                {
                                    this.Hide();
                                    Main main = new Main();
                                    main.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Admin Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case "cashier":
                                if (username.ToLower() == "cashier" && password == "cashier123")
                                {
                                    this.Hide();
                                    Cashier cashier = new Cashier();
                                    cashier.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Cashier Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                           

                            // Add similar cases for other categories (Rider, Waiter) as needed

                            default:
                           
                                // Allow any username, password, and category for Chef
                                this.Hide();
                                Chef chef = new Chef();
                                chef.Show();
                                break;

                                
                        }
                    }
                    else
                    {
                        // Handle invalid username
                        MessageBox.Show("Invalid Username", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    db.closeConnection(); // Close the connection, whether an exception occurred or not
                }
            }
            else
            {
                Console.WriteLine("Connection is null. Check your DB class and getConnection method.");
            }
        }


        // Replace this method with your actual implementation to get category from the database
        private string GetCategoryFromDatabase(string username)
        {
            // Your database query to get the category based on the username
            // Example query: SELECT category FROM users WHERE username = @usn
            // Execute the query and return the category value
            // Make sure to handle database connections, commands, and exceptions appropriately

            return "admin"; // Placeholder, replace with actual category retrieved from the database
        }


        private void labelGoToSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {

            //        comboBox1.SelectedText.
            comboBox1.ForeColor = Color.Black;

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {

            comboBox1.SelectionLength = 0;


                comboBox1.ForeColor = Color.Black;

           
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(comboBox1.SelectedText, "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { comboBox1.Select(0, 0); }));
        
        }

        private void comboBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(comboBox1.SelectedText, "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { comboBox1.Select(0, 0); }));
        }

        private void comboBox1_DropDownStyleChanged(object sender, EventArgs e)
        {
       //     MessageBox.Show(comboBox1.SelectedText, "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
