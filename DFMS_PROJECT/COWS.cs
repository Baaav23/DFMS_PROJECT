﻿using Cow_Farm_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters.Entities;


namespace DFMS_PROJECT
{
    public partial class COWS : Form
    {
        Functions Con;
        int key = 0;
        int age = 0;
        public COWS()
        {
            InitializeComponent();
            Con = new Functions();
            ShowCows();
        }
        private void ShowCows()
        {
            String Query = "Select * from CowTbl";
            CowGV.DataSource = Con.GetData(Query);
        }
        private void SearchCow()
        {
            String Query = "Select * from CowTbl where CowName like '%" + CFilter.Text + "%'";
            CowGV.DataSource = Con.GetData(Query);
        }

        private void Clear()
        {
            age = 0;
            DOBDate.Value = DateTime.Today.Date;
            CowNameTb.Text = "";
            EarTagTb.Text = "";
            ColorTb.Text = "";
            BreedTb.Text = "";
            AgeTb.Text = age.ToString();
            WeigthTb.Text = "";
            PasTureTb.Text = "";
            key = 0;
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void COWS_Load(object sender, EventArgs e)
        {

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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MILK_PRODUCTION Ob = new MILK_PRODUCTION();
            Ob.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MILK_PRODUCTION Ob = new MILK_PRODUCTION();
            Ob.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Health Ob = new Health();
            Ob.Show();
            this.Hide();
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label15_Click(object sender, EventArgs e)
        {
            MilkSales Ob = new MilkSales();
            Ob.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MilkSales Ob = new MilkSales();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (CowNameTb.Text == "" || EarTagTb.Text == ""|| ColorTb.Text==""||BreedTb.Text==""||AgeTb.Text==""||AgeTb.Text==""||PasTureTb.Text=="")
            {
                MessageBox.Show("Mmissing Data");
            }
            else
            {
                try
                {
                    String Query = "insert into CowTbl values('" + CowNameTb.Text + "','" + EarTagTb.Text + "','" + ColorTb.Text + "','" + BreedTb.Text + "'," + age + "," + Convert.ToInt32(WeigthTb.Text) + ",'" + PasTureTb.Text + "')";
                    Con.SetData(Query);
                    ShowCows();
                    Clear();
                    MessageBox.Show("Cow Added!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CowNameTb.Text = CowGV.SelectedRows[0].Cells[1].Value.ToString();
            EarTagTb.Text = CowGV.SelectedRows[0].Cells[2].Value.ToString();
            ColorTb.Text = CowGV.SelectedRows[0].Cells[3].Value.ToString();
            BreedTb.Text = CowGV.SelectedRows[0].Cells[4].Value.ToString();
            AgeTb.Text = CowGV.SelectedRows[0].Cells[5].Value.ToString();
            WeigthTb.Text = CowGV.SelectedRows[0].Cells[6].Value.ToString();
            PasTureTb.Text = CowGV.SelectedRows[0].Cells[7].Value.ToString();
            //age = Convert.ToInt32(CAge.Text);
            if (CowNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CowGV.SelectedRows[0].Cells[0].Value.ToString());
                age = Convert.ToInt32(CowGV.SelectedRows[0].Cells[5].Value.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DOBDate_ValueChanged(object sender, EventArgs e)
        {
            age = Convert.ToInt32((DateTime.Today.Date - DOBDate.Value.Date).Days) / 365;
            DOBDate.Text = age.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please Sellect a Cow!!!");
            }
            else
            {
                try
                {
                    String Query = "Delete from CowTbl where CowId = {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    ShowCows();
                    Clear();
                    MessageBox.Show("Cow Deleted!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (CowNameTb.Text == "" || EarTagTb.Text == "" || ColorTb.Text == "" || BreedTb.Text == "" || AgeTb.Text == "" || WeigthTb.Text == "" || PasTureTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String Query = "Update CowTbl set CowName = '" + CowNameTb.Text + "',EarTag = '" + EarTagTb.Text + "',Color = '" + ColorTb.Text + "',Breed = '" + BreedTb.Text + "',Age = " + AgeTb + ",WeigtAtBirth = " + Convert.ToInt32(WeigthTb.Text) + ",Pasture = '" + PasTureTb.Text + "'  where CowId = " + key + "";
                    Con.SetData(Query);
                    ShowCows();
                    Clear();
                    MessageBox.Show("Cow Edited!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CFilter_TextChanged(object sender, EventArgs e)
        {
            SearchCow();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
