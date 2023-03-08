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
        public Dashboard()
        {
            InitializeComponent();
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
    }
}
