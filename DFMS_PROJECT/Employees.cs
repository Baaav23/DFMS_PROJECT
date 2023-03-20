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
    }
}
