﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //to show subform form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //childForm.ShowDialog();
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void label8_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
