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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar3_progressChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startP = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            ProgBar.Value = startP;
            if (ProgBar.Value == 100)
            {
                ProgBar.Value = 0;
                timer1.Stop();
                Login page = new Login();
                this.Hide();
                page.Show();
            }
        }
    }
}
