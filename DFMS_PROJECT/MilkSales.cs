﻿using Cow_Farm_System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFMS_PROJECT
{
    public partial class MilkSales : Form
    {
        Functions Con;
        int key = 0;
        public MilkSales()
        {
            InitializeComponent();
            Con = new Functions();
            getEmpId();
            showSales();
        }
        private void Clear()
        {
            SDate.Value = DateTime.Today.Date;
            SCName.Text = "";
            SCPhone.Text = "";
            SPrice.Text = "";
            SQuantity.Text = "";
            STotal.Text = "";
            key = 0;
        }

        private void getEmpId()
        {
            string Query = "Select EmpId from EmpTbl";
            EID.ValueMember = "EmpId";
            EID.DataSource = Con.GetData(Query);
        }

        private void showSales()
        {
            String Query = "Select * from MilkSalesTbl";
            SalesListTb.DataSource = Con.GetData(Query);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            COWS Ob = new COWS();
            Ob.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            COWS Ob = new COWS();
            Ob.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MILK_PRODUCTION Ob = new MILK_PRODUCTION();
            Ob.Show();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MILK_PRODUCTION Ob = new MILK_PRODUCTION();
            Ob.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Health Ob = new Health();
            Ob.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Health Ob = new Health();
            Ob.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label14_Click(object sender, EventArgs e)
        {
            breeding Ob = new breeding();
            Ob.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            breeding Ob = new breeding();
            Ob.Show();
            this.Hide();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Finance Ob = new Finance();
            Ob.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Finance Ob = new Finance();
            Ob.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            MilkSales Ob = new MilkSales();
            Ob.Show();
            this.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MilkSales Ob = new MilkSales();
            Ob.Show();
            this.Hide();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Dashboard Ob = new Dashboard();
            Ob.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Dashboard Ob = new Dashboard();
            Ob.Show();
            this.Hide();
        }

        private void MilkSales_Load(object sender, EventArgs e)
        {

        }
        private void SaveIncome()
        {
            try
            {
                String type = "Sales";
                String Query = "insert into IncomeTbl values('" + SDate.Value.Date.ToShortDateString() + "','" + type + "','" + Convert.ToInt32(STotal.Text) + "','" + Convert.ToInt32(EID.SelectedValue.ToString()) + "')";
                Con.SetData(Query);
                MessageBox.Show("Income Added!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SQuantity_Leave(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(SPrice.Text) * Convert.ToInt32(SQuantity.Text);
            STotal.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SCName.Text == "" || EID.SelectedIndex == -1 || SPrice.Text == "" || SQuantity.Text == "" || STotal.Text == "" || SCPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String Query = "insert into MilkSalesTbl values('" + SDate.Value.Date.ToShortDateString() + "'," + Convert.ToInt32(SPrice.Text) + ",'" + SCName.Text + "','" + SCPhone.Text + "'," + Convert.ToInt32(EID.SelectedValue.ToString()) + "," + Convert.ToInt32(SQuantity.Text) + ", " + Convert.ToInt32(STotal.Text) + ")";
                    Con.SetData(Query);

                    showSales();
                    MessageBox.Show("Sales Added!!!");
                    SaveIncome();
                    Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
