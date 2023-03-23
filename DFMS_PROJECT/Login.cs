using Cow_Farm_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DFMS_PROJECT
{
    
    public partial class Login : Form
    {
        Functions Con;
        public Login()
        {
            InitializeComponent();

            Con = new Functions();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            Password.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Role.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Role");
            }
            else if (UserName.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Enter username and password");
            }
            else
            {
                if (Role.SelectedItem.ToString() == "Admin")
                {
                    if (UserName.Text == "Admin" && Password.Text == "Admin")
                    {
                        Employees page = new Employees();
                        page.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Admin name or Password");
                    }
                }
                else if (Role.SelectedItem.ToString() == "Employee")
                {
                    string Query = "Select count(*) from EmpTbl where EmpName='" + UserName.Text + "' and EmpPass='" + Password.Text + "'";
                    if (Con.GetData(Query).Rows[0][0].ToString() == "1")
                    {
                        COWS page = new COWS();
                        page.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong UserName or Password");
                    }

                }
            }
        }
    }
}
