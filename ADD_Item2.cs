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
    public partial class ADD_Item2 : UserControl
    {
       // Function fn = new Function();   

        string query;
        public ADD_Item2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Update your query in setData method to use the correct case
            string query = "INSERT INTO items (name, category, price) VALUES (@name, @category, @price)";


            // Assuming txtitemName, txtCategory, and txtPrice are TextBox controls on your form
            SqlParameter[] parameters = {
        new SqlParameter("@itemName", SqlDbType.VarChar) { Value = txtitemName.Text },
        new SqlParameter("@category", SqlDbType.VarChar) { Value = txtCategory.Text },
        new SqlParameter("@price", SqlDbType.Decimal) { Value = Convert.ToDecimal(txtPrice.Text) }
    };

           // fn.setData(query, parameters);
            clearAll();
        }


        public void clearAll() 
        {
            txtCategory.SelectedIndex = -1;   
            txtitemName.Clear();
            txtPrice.Clear();
        }
    }
}
