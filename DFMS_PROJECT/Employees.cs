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
    public partial class Employees : Form
    {
        Functions Con;
        int key = 0;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            showEmployees();

        }
        private void Clear()
        {
            EDate.Value = DateTime.Today.Date;
            EName.Text = "";
            EPass.Text = "";
            EPhon.Text = "";
            EAdd.Text = "";
            EGen.SelectedIndex = -1;
            key = 0;
        }

        private void showEmployees()
        {
            String Query = "Select * from EmpTbl";
            EList.DataSource = Con.GetData(Query);
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (EName.Text == "" || EGen.SelectedIndex == -1 || EPhon.Text == "" || EAdd.Text == "" /*|| EPass.Text == ""*/)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String Query = "insert into EmpTbl values('" + EName.Text + "','" + EDate.Value.Date.ToShortDateString() + "','" + EGen.SelectedItem.ToString() + "','" + EPhon.Text + "', '" + EAdd.Text + "')";
                    Con.SetData(Query);
                    showEmployees();
                    Clear();
                    MessageBox.Show("Employee Added!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EName.Text = EList.SelectedRows[0].Cells[1].Value.ToString();
            EDate.Text = EList.SelectedRows[0].Cells[2].Value.ToString();
            EGen.SelectedItem = EList.SelectedRows[0].Cells[3].Value.ToString();
            EPhon.Text = EList.SelectedRows[0].Cells[4].Value.ToString();
            EAdd.Text = EList.SelectedRows[0].Cells[5].Value.ToString();
            //EPass.Text = EList.SelectedRows[0].Cells[6].Value.ToString();
            if (EName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
