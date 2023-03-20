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
using Bunifu.Framework.UI;
using System.Management.Instrumentation;

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
            string Query = "Select * from CowTbl where CowId=" + CowIDTb.SelectedValue + "";
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                CowNameTb.Text = dr["CowName"].ToString();
            }
        }
        private void Clear()
        {
            HDDate.Value = DateTime.Today.Date;
            CowNameTb.Text = "";
            VetNameTb.Text = "";
            EventTb.Text = "";
            TreatmentTb.Text = "";
            DiagnosisTb.Text = "";
            CostTb.Text = "";
            key = 0;
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
            if (CowNameTb.Text == "" || CowIDTb.SelectedIndex == -1 || EventTb.Text == "" || DiagnosisTb.Text == "" || TreatmentTb.Text == "" || CostTb.Text == "" || VetNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String Query = "insert into HealthTbl values('" + CowIDTb.SelectedValue.ToString() + "','" + CowNameTb.Text + "','" + HDDate.Value.Date.ToShortDateString() + "','" + EventTb.Text + "','" + DiagnosisTb.Text + "','" + TreatmentTb.Text + "', " + CostTb.Text + ", '" + VetNameTb.Text + "')";
                    Con.SetData(Query);
                    showHealth();
                    Clear();
                    MessageBox.Show("Health Report Added!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Health_Load(object sender, EventArgs e)
        {

        }

        private void HealthListTb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CowIDTb.SelectedValue = HealthListTb.SelectedRows[0].Cells[1].Value.ToString();
            CowNameTb.Text = HealthListTb.SelectedRows[0].Cells[2].Value.ToString();
            HDDate.Text = HealthListTb.SelectedRows[0].Cells[3].Value.ToString();
            EventTb.Text = HealthListTb.SelectedRows[0].Cells[4].Value.ToString();
            DiagnosisTb.Text = HealthListTb.SelectedRows[0].Cells[5].Value.ToString();
            TreatmentTb.Text = HealthListTb.SelectedRows[0].Cells[6].Value.ToString();
            CostTb.Text = HealthListTb.SelectedRows[0].Cells[7].Value.ToString();
            VetNameTb.Text = HealthListTb.SelectedRows[0].Cells[8].Value.ToString();
            if (CowNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(HealthListTb.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CowNameTb.Text == "" || CowIDTb.SelectedIndex == -1 || EventTb.Text == "" || DiagnosisTb.Text == "" || TreatmentTb.Text == "" || CostTb.Text == "" || VetNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String Query = "update HealthTbl set CowId='" + CowIDTb.SelectedValue.ToString() + "',CowName= '" + CowNameTb.Text + "',RepDate='" + HDDate.Value.Date.ToShortDateString() + "',Event='" + EventTb.Text + "',Diagnosis='" + DiagnosisTb.Text + "',Treatment='" + TreatmentTb.Text + "',Cost=" + CostTb.Text + ",VetName='" + VetNameTb.Text + "' where RepId=" + key + " ";
                    Con.SetData(Query);
                    showHealth();
                    Clear();
                    MessageBox.Show("Health Report Edited!!!");
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
                MessageBox.Show("Please Sellect a Health Report!!!");
            }
            else
            {
                try
                {
                    String Query = "Delete from HealthTbl where RepId = {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    showHealth();
                    Clear();
                    MessageBox.Show("Health Report Deleted!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CowIDTb_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCowName();
        }
    }
}
