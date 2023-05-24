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
    public partial class PacientiNoi : Form
    {
        public PacientiNoi()
        {
            InitializeComponent();
        }
        public static void main()
        {
            string dt = "24/01/2013";
            DateTime date = DateTime.ParseExact(dt, "dd/MM/yyyy", null);
            Console.WriteLine(date);
        }

        private void buttonSalveazaPac_Click(object sender, EventArgs e)
        {
            string query = "insert into Pacienti values('" + NumePac.Text + "', '" + AdresaPac.Text + "', '" + TelefonPac.Text + "', '" + EmailPac.Text + "', '" + ZiNasterePac.Value.Date + "', '" + SexPac.SelectedItem.ToString() + "', '" + ParolaPac.Text + "')";
            Pacientii Pac = new Pacientii();
            try
            {
                Pac.AddPacient(query);
                MessageBox.Show("Pacienet adaugat cu succes!!!");
                //populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
