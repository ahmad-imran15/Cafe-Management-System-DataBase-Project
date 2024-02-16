using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace restaurantSystem
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*AddNEWItem aDD_Item = new AddNEWItem();
            this.Hide();
            aDD_Item.Show();*/

            PlaceOrder placeOrder = new PlaceOrder();
            this.Hide();
            placeOrder.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
                }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User fm = new User();
            this.Hide();

            fm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNEWItem add_Item = new AddNEWItem();
            add_Item.Visible = true;
            add_Item.BringToFront();
        }

        private void adD_Item1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
