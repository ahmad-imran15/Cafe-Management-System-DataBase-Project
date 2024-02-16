using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlaceOrder placeOrder = new PlaceOrder();
            placeOrder.Show();
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.Show();
        }

        private void payment_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }

        private void sales_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
           /* Sales sales = new Sales();
            sales.Show();*/
        }

        private void inbox_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pos pos = new Pos();
            pos.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFeedback addFeedback = new AddFeedback();
            addFeedback.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddNEWItem addNEWItem = new AddNEWItem();
            addNEWItem.Show();  

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedbackshow feedbackshow = new Feedbackshow();
            feedbackshow.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
                      
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
