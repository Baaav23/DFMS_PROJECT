using Cow_Farm_System;
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
    public partial class Finance : Form
    {
        Functions Con;
        int key = 0;
        public Finance()
        {
            InitializeComponent();
            Con = new Functions();
            showExp();
            showInc();
        }
        private void showExp()
        {
            String Query = "Select * from ExpenditureTbl";
            ExpenListTb.DataSource = Con.GetData(Query);
        }

        private void showInc()
        {
            String Query = "Select * from IncomeTbl";
            IncomeListTb.DataSource = Con.GetData(Query);
        }
        private void ClearExp()
        {
            PregnancyDateTb.Value = DateTime.Today.Date;
            PerpuseTb.SelectedIndex = -1;
            EventTb.Text = "";
            key = 0;
        }

        private void ClearInc()
        {
            IncomeDateTb.Value = DateTime.Today.Date;
            TypeTb.SelectedIndex = -1;
            AmountTb.Text = "";
            key = 0;
        }

        private void Finance_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            COWS Ob = new COWS();
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
            MILK_PRODUCTION Ob = new MILK_PRODUCTION();
            Ob.Show();
            this.Hide();
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
            Health Ob = new Health();
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

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            breeding Ob = new breeding();
            Ob.Show();
            this.Hide();
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
            Finance Ob = new Finance();
            Ob.Show();
            this.Hide();
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
            Dashboard Ob = new Dashboard();
            Ob.Show();
            this.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            MilkSales Ob = new MilkSales();
            Ob.Show();
            this.Hide();
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (EventTb.Text == "" || PerpuseTb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String Query = "insert into ExpenditureTbl values('" + PregnancyDateTb.Value.Date.ToShortDateString() + "','" + PerpuseTb.SelectedItem.ToString() + "','" + Convert.ToInt32(EventTb.Text) + "','" + Convert.ToInt32(EmpTemp.Text) + "')";
                    Con.SetData(Query);
                    showExp();
                    ClearExp();
                    MessageBox.Show("Expenditure Added!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ExRef_Click(object sender, EventArgs e)
        {
            showExp();
        }

        private void FExFilter_ValueChanged(object sender, EventArgs e)
        {
            String Query = "Select * from ExpenditureTbl where ExpDate='" + FExFilter.Value.Date.ToShortDateString() + "'";
            ExpenListTb.DataSource = Con.GetData(Query);
        }
        private void Filterincome()
        {
            String Query = "Select * from IncomeTbl where IncDate='" + FilterTb.Value.Date.ToShortDateString() + "'";
            IncomeListTb.DataSource = Con.GetData(Query);
        }

        private void FilterTb_ValueChanged(object sender, EventArgs e)
        {
            Filterincome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AmountTb.Text == "" || TypeTb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String Query = "insert into IncomeTbl values('" + IncomeDateTb.Value.Date.ToShortDateString() + "','" + TypeTb.SelectedItem.ToString() + "','" + Convert.ToInt32(AmountTb.Text) + "','" + Convert.ToInt32(EmpTemp.Text) + "')";
                    Con.SetData(Query);
                    showInc();
                    ClearInc();
                    MessageBox.Show("Income Added!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
