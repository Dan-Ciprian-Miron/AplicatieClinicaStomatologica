using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectDisertatie
{
    public partial class EcranPornire : Form
    {
        public EcranPornire()
        {
            InitializeComponent();
            pBar.Value = 0;
        }

        private void pictureBoxEcranPornire_Click(object sender, EventArgs e)
        {

        }

        private void EcranPornire_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pBar.Value += 1;
            pBar.Text = pBar.Value.ToString() + "%";
            if (pBar.Value == 100)
            {
                timer1.Enabled = false;
                Form form = new LoginForm();
                form.Show();
                this.Hide();
            }
             
        }
    } 

}

