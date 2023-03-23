using Cow_Farm_System;
using System;
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
    public partial class Dashboard : Form
    {
        Functions Con;
        int key = 0;
        public Dashboard()
        {
            InitializeComponent();
            Con = new Functions();
            FinanceCalc();
            LogistecCalc();
            getMax();
        }
        private void FinanceCalc()
        {
            int inc, exp;
            double bal;
            String Query = "Select sum(IncAmount) from IncomeTbl";
            inc = Convert.ToInt32(Con.GetData(Query).Rows[0][0]);
            FInc.Text = "$ " + inc.ToString();

            String Query2 = "Select sum(ExpAmount) from ExpenditureTbl";
            exp = Convert.ToInt32(Con.GetData(Query2).Rows[0][0]);
            FExp.Text = "$ " + exp.ToString();

            bal = inc - exp;
            FBal.Text = "$ " + bal;
        }

        private void LogistecCalc()
        {
            String Query = "Select count(*) from CowTbl";
            LCow.Text = Con.GetData(Query).Rows[0][0].ToString();

            String Query2 = "Select sum(TotalMilk) from MilkTbl";
            LMilk.Text = Con.GetData(Query2).Rows[0][0].ToString() + " Litters";

            String Query3 = "Select count(*) from EmpTbl";
            LEmp.Text = Con.GetData(Query3).Rows[0][0].ToString();
        }

        private void getMax()
        {
            String Query = "Select Max(IncAmount) from IncomeTbl";
            SMax.Text = "$ " + Con.GetData(Query).Rows[0][0].ToString();

            String Query2 = "Select Max(ExpAmount) from ExpenditureTbl";
            ExpMax.Text = "$ " + Con.GetData(Query2).Rows[0][0].ToString();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Health Ob = new Health();
            Ob.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
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

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
