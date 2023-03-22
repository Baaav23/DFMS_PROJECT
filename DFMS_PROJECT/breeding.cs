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
using System.Xml.Linq;

namespace DFMS_PROJECT
{
    public partial class breeding : Form
    {
        Functions Con;
        int key = 0;
        public breeding()
        {
            InitializeComponent();
            Con = new Functions();
            showBreading();
            getCowId();
        }
        private void showBreading()
        {
            String Query = "Select * from BreedTbl";
            CowListTb.DataSource = Con.GetData(Query);
        }

        private void getCowId()
        {
            string Query = "Select CowId from CowTbl";
            CowIdTb.ValueMember = "CowId";
            CowIdTb.DataSource = Con.GetData(Query);
        }
        private void getCowName()
        {
            string Query = "Select * from CowTbl where CowId=" +CowIdTb.SelectedValue + "";
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                CowNameTb.Text = dr["CowName"].ToString();
                CowAgeTb.Text = dr["Age"].ToString();
            }
        }
        private void Clear()
        {
            HeateDateTb.Value = DateTime.Today.Date;
            PregnancyDateTb.Value = DateTime.Today.Date;
            ExpectDateTb.Value = DateTime.Today.Date;
            DateCalvedTb.Value = DateTime.Today.Date;
            BreedDateTb.Value = DateTime.Today.Date;
            CowNameTb.Text = "";
            CowAgeTb.Text = "";
            RemarkesTb.Text = "";
            key = 0;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void label16_Click(object sender, EventArgs e)
        {
            Finance Ob = new Finance();
            Ob.Show();
            this.Hide();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Finance Ob = new Finance();
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

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CowIdTb.SelectedIndex == -1 || CowNameTb.Text == "" || CowAgeTb.Text == "" || RemarkesTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    String Query = "insert into BreedTbl values('" + HeateDateTb.Value.Date.ToShortDateString() + "','" + BreedDateTb.Value.Date.ToShortDateString() + "'," + Convert.ToInt32(CowIdTb.SelectedValue.ToString()) + ",'" + CowNameTb.Text + "','" + PregnancyDateTb.Value.Date.ToShortDateString() + "','" + ExpectDateTb.Value.Date.ToShortDateString() + "', '" + DateCalvedTb.Value.Date.ToShortDateString() + "', " + Convert.ToInt32(CowAgeTb.Text) + ", '" + RemarkesTb.Text + "')";
                    Con.SetData(Query);
                    showBreading();
                    Clear();
                    MessageBox.Show("Breading Added!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CowIdTb_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCowName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CowIdTb.SelectedIndex == -1 || CowNameTb.Text == "" || CowAgeTb.Text == "" || RemarkesTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                try
                {
                    String Query = "update BreedTbl set HeatDate='" + HeateDateTb.Value.Date.ToShortDateString() + "',BreedDate= '" + BreedDateTb.Value.Date.ToShortDateString() + "',CowId=" + Convert.ToInt32(CowIdTb.SelectedValue.ToString()) + ",CowName='" + CowNameTb.Text + "',PregDate='" + PregnancyDateTb.Value.Date.ToShortDateString() + "',ExpDateCalve='" + ExpectDateTb.Value.Date.ToShortDateString() + "',DateCalved='" + DateCalvedTb.Value.Date.ToShortDateString() + "',CowAge=" + Convert.ToInt32(CowAgeTb.Text) + ",Remarks='" + RemarkesTb.Text + "' where BrId=" + key + " ";
                    Con.SetData(Query);
                    showBreading();
                    Clear();
                    MessageBox.Show("Breading Edited!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please Sellect a Breading!!!");
            }
            else
            {
                try
                {
                    String Query = "Delete from BreedTbl where BrId = {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    showBreading();
                    Clear();
                    MessageBox.Show("Breading Deleted!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CowListTb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HeateDateTb.Text = CowListTb.SelectedRows[0].Cells[1].Value.ToString();
            BreedDateTb.Text = CowListTb.SelectedRows[0].Cells[2].Value.ToString();
            CowIdTb.SelectedValue = CowListTb.SelectedRows[0].Cells[3].Value.ToString();
            CowNameTb.Text = CowListTb.SelectedRows[0].Cells[4].Value.ToString();
            PregnancyDateTb.Text = CowListTb.SelectedRows[0].Cells[5].Value.ToString();
            ExpectDateTb.Text = CowListTb.SelectedRows[0].Cells[6].Value.ToString();
            DateCalvedTb.Text = CowListTb.SelectedRows[0].Cells[7].Value.ToString();
            CowAgeTb.Text = CowListTb.SelectedRows[0].Cells[8].Value.ToString();
            RemarkesTb.Text = CowListTb.SelectedRows[0].Cells[9].Value.ToString();
            if (CowNameTb.Text == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(CowListTb.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void breeding_Load(object sender, EventArgs e)
        {

        }
    }
}
