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
    public partial class Chef : Form
    {
        public Chef()
        {
            InitializeComponent();
        }

        private void recipe_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delivery delivery = new Delivery();
            delivery.Show();
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
           
            Menu menu = new Menu();
            menu.Show();

        }

        private void salary_btn_Click(object sender, EventArgs e)
        {
            
            PlaceOrder placeOrder = new PlaceOrder();
            placeOrder.Show();
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Info info = new Info();
             info.Show();
          
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFeedback addFeedback = new AddFeedback();
            this.Hide();
            addFeedback.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pos pos = new Pos();
            this.Hide(); 
            pos.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
