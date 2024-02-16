using MySql.Data.MySqlClient;
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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

            this.Hide();
            }

        private void item_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removeitem_btn_Click(object sender, EventArgs e)
        {
            // Assuming 'id' is an integer. If it's a string, adjust accordingly.
            int idLocRemv;

            if (item_table.SelectedRows.Count > 0 && item_table.SelectedRows[0].Cells[0].Value != null &&
                int.TryParse(item_table.SelectedRows[0].Cells[0].Value.ToString(), out idLocRemv))
            {
                try
                {

                    using (SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True"))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("DELETE FROM items WHERE item_id = @item_id", connection))
                        {
                            command.Parameters.Add("@item_id", SqlDbType.Int).Value = idLocRemv;

                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Row with ID " + idLocRemv + " got removed.", "Removed Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // this.Hide();
                /*Inventory invento*///ry = new Inventory();
                /*inventory.Show();*/
                RefreshData();
                /*
                                MessageBox.Show("Row with ID " + idLocRemv + " got removed.", "Removed Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Please select a valid row.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }*/
            }
        }
        private void RefreshData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=ANONYMOUS\\SQLEXPRESS;Initial Catalog=DataProject;Integrated Security=True"))
                {
                    connection.Open();

                    // Assuming item_table is your DataGridView
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM items", connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Update the DataGridView with the new data
                        item_table.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void additem_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNEWItem addItems = new AddNEWItem();
            addItems.Show();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            item_table.DataSource = itemlist();
        }

        private DataTable itemlist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM items", db.getConnection());

            db.openConnection();

            SqlDataReader rdr = command.ExecuteReader();

            table.Load(rdr);

            return table;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
