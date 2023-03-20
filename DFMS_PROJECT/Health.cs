using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Cow_Farm_System;
using System.Collections;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace DFMS_PROJECT
{
    public partial class Health : Form
    {
        Functions Con;
        int key = 0;
        public Health()
        {
            InitializeComponent();
            Con = new Functions();
            getCowId();
            showHealth();
        }
        private void showHealth()
        {
            String Query = "Select * from HealthTbl";
            HealthListTb.DataSource = Con.GetData(Query);
        }

        private void getCowId()
        {
            string Query = "Select CowId from CowTbl";
            CowIDTb.ValueMember = "CowId";
            CowIDTb.DataSource = Con.GetData(Query);
        }

        private void getCowName()
        {
            string Query = "Select * from CowTbl where CowId=" + CID.SelectedValue + "";
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                CowNameTb.Text = dr["CowName"].ToString();
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Health_Load(object sender, EventArgs e)
        {

        }
    }
}
