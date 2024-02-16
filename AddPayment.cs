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
    public partial class AddPayment : Form
    {
       
        private decimal totalAmount;

        // Add a constructor that accepts the total amount
       /* public AddPayment(decimal totalAmount)
        {
           
        }*/
        public AddPayment(decimal totalAmount)
        {

            InitializeComponent();

            // Unsubscribe from the Load event if it was previously subscribed
            this.Load -= AddPayment_Load;

            this.totalAmount = totalAmount;

            // Set the total amount in the text box when initializing the form
            ap_total.Text = totalAmount.ToString();

            // Set the current timestamp in the ap_timestamp TextBox
         //   ap_timestamp.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


            // Subscribe to the Load event
            this.Load += AddPayment_Load;
        }


        private void addpayment_btn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            SqlCommand command = new SqlCommand("INSERT INTO payments (method, total_amount, accountNo, time) VALUES (@method, @total, @accountNo, @time)", db.getConnection());

            command.Parameters.Add("@method", SqlDbType.VarChar).Value = ap_comboBox.Text;

            // Validate and parse total and accountNo
            if (Decimal.TryParse(ap_total.Text, out decimal total) && Decimal.TryParse(ap_balance.Text, out decimal balance))
            {
                command.Parameters.Add("@total", SqlDbType.Decimal).Value = total;
                command.Parameters.Add("@accountNo", SqlDbType.Decimal).Value = balance;
            }
            else
            {
                // Handle invalid decimal format
                MessageBox.Show("Invalid total amount or account number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // or handle accordingly
            }

            command.Parameters.Add("@time", SqlDbType.DateTime).Value = Convert.ToDateTime(ap_timestamp.Text);

            command.ExecuteNonQuery();

            /*this.Hide();
            Payment payment = new Payment();
            payment.Show();*/

            MessageBox.Show("Payment Done Successfully", "Payment", MessageBoxButtons.OK, MessageBoxIcon.None);


            PlaceOrder placeOrder = new PlaceOrder();
            this.Hide();
            placeOrder.Show();
        }


        private void back_btn_Click(object sender, EventArgs e)
        {
            /* this.Hide();
             Payment payment = new Payment();
             payment.Show();*/

            this.Hide();
            PlaceOrder placeOrder = new PlaceOrder();   
            placeOrder.Show();

        }

        private void ap_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { ap_comboBox.Select(0, 0); }));
        }

        private void ap_timestamp_Enter(object sender, EventArgs e)
        {
            string timestamp = ap_timestamp.Text;
            if (timestamp.ToLower().Trim().Equals("e.g. 2020-10-10 18:29:13"))
            {
                ap_timestamp.Text = "";              
                ap_timestamp.ForeColor = Color.Black;



            }
        }

        private void ap_timestamp_Leave(object sender, EventArgs e)
        {
            string timestamp = ap_timestamp.Text;
            if (timestamp.ToLower().Trim().Equals("e.g. 2020-10-10 18:29:13") ||
                timestamp.Trim().Equals(""))
            {
                ap_timestamp.Text = "e.g. 2020-10-10 18:29:13";               
                ap_timestamp.ForeColor = Color.Gray;



            }
        }

        private void ap_timestamp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddPayment_Load(object sender, EventArgs e)
        {
            // Set the total amount in the text box when the form is loaded
            ap_total.Text = totalAmount.ToString();

            // Set the current timestamp in the ap_timestamp TextBox
            ap_timestamp.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Debug message to check if the method is executed
            Console.WriteLine("AddPayment_Load executed");
        }
        private void ap_total_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
