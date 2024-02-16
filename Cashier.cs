﻿using System;
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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show(this);
          /*
           Inventory inventory = new Inventory();
            inventory.Show();
            */
        }

        private void pos_btn_Click(object sender, EventArgs e)
        {
           // this.Hide();
            Pos pos = new Pos();
            pos.Show();
        }

        private void salary_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Salary salary = new Salary();
            //salary.Show();
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            
            PlaceOrder placeOrder = new PlaceOrder();
            placeOrder.Show();


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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 addNEWItem = new Form1();
            this.Hide();
            addNEWItem.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
