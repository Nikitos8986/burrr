using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burrr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Rotor rot = new Rotor();
            rot.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Napr nap = new Napr();
            nap.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hydro hyd = new Hydro();
            hyd.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Gornie gor = new Gornie();
            gor.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Poverh pov = new Poverh();
            pov.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prosm pro = new Prosm();
            pro.Show();
        }
    }
}
