using Cow_Farm_System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DFMS_PROJECT
{
    public partial class MILK_PRODUCTION : Form
    {
        Functions Con;
        int key = 0;
        public MILK_PRODUCTION()
        {
            InitializeComponent();
            Con = new Functions();
            getCowId();
            showMilk();
        }
        private void showMilk()
        {
            String Query = "Select * from MilkTbl";
            MilkListTb.DataSource = Con.GetData(Query);
        }

        private void getCowId()
        {
            string Query = "Select CowId from CowTbl";
            CID.ValueMember = "CowId";
            CID.DataSource = Con.GetData(Query);
        }

        private void getCowName()
        {
            string Query = "Select * from CowTbl where CowId=" + CID.SelectedValue + "";
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                CName.Text = dr["CowName"].ToString();
            }
        }

        private void MILK_PRODUCTION_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            MDate.Value = DateTime.Today.Date;
            CName.Text = "";
            MAm.Text = "";
            MNoon.Text = "";
            MPm.Text = "";
            MTotal.Text = "";
            key = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CName.Text == "" || CID.SelectedIndex == -1 || MAm.Text == "" || MNoon.Text == "" || MPm.Text == "" || MTotal.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String Query = "insert into MilkTbl values(" + CID.SelectedValue.ToString() + ",'" + CName.Text + "'," + Convert.ToInt32(MAm.Text) + "," + Convert.ToInt32(MNoon.Text) + "," + Convert.ToInt32(MPm.Text) + "," + Convert.ToInt32(MTotal.Text) + ", '" + MDate.Value.Date.ToShortDateString() + "')";
                    Con.SetData(Query);
                    showMilk();
                    Clear();
                    MessageBox.Show("Milk Added!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CID_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCowName();
        }
        private void MPm_Leave(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(MAm.Text) + Convert.ToInt32(MNoon.Text) + Convert.ToInt32(MPm.Text);
            MTotal.Text = total.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CName.Text == "" || CID.SelectedIndex == -1 || MAm.Text == "" || MNoon.Text == "" || MPm.Text == "" || MTotal.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String Query = "Update MilkTbl set CowId='" + CID.SelectedValue.ToString() + "',CowName='" + CName.Text + "',AmMilk=" + Convert.ToInt32(MAm.Text) + ",NoonMilk=" + Convert.ToInt32(MNoon.Text) + ",PmMilk=" + Convert.ToInt32(MPm.Text) + ",TotalMilk=" + Convert.ToInt32(MTotal.Text) + ",DateProd= '" + MDate.Value.Date.ToShortDateString() + "' where MId=" + key + " ";
                    Con.SetData(Query);
                    showMilk();
                    Clear();
                    MessageBox.Show("Milk Edited!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MilkListTb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CID.SelectedValue = MilkListTb.SelectedRows[0].Cells[1].Value.ToString();
            CName.Text = MilkListTb.SelectedRows[0].Cells[2].Value.ToString();
            MAm.Text = MilkListTb.SelectedRows[0].Cells[3].Value.ToString();
            MNoon.Text = MilkListTb.SelectedRows[0].Cells[4].Value.ToString();
            MPm.Text = MilkListTb.SelectedRows[0].Cells[5].Value.ToString();
            MTotal.Text = MilkListTb.SelectedRows[0].Cells[6].Value.ToString();
            MDate.Text = MilkListTb.SelectedRows[0].Cells[7].Value.ToString();
            if (CName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(MilkListTb.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
