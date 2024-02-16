using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace restaurantSystem
{
    public partial class UpdateForm : Form
    {
        string connstring = "Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True";
        string query;
        int id;

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                query = "select * from items";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                query = "select * from items where name like '" + txtSearchItem.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idString = dataGridView1.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
            if (!string.IsNullOrEmpty(idString) && int.TryParse(idString, out int result))
            {
                id = result;

                // Assuming name is the second column
                string name = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();

                // Assuming category is the third column
                string category = dataGridView1.Rows[e.RowIndex].Cells["category"].Value.ToString();

                // Assuming price is the fourth column
                decimal price;
                if (decimal.TryParse(dataGridView1.Rows[e.RowIndex].Cells["price"].Value.ToString(), out decimal priceResult))
                {
                    price = priceResult;
                }
                else
                {
                    MessageBox.Show("Invalid Price value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update the TextBox values
                txtName.Text = name;
                txtCategory.Text = category;
                txtPrice.Text = price.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Item_ID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                query = "update items set name = '" + txtName.Text + "', category = '" + txtCategory.Text + "', price = " + txtPrice.Text + " where item_id = " + id;
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

            loadData();

            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
