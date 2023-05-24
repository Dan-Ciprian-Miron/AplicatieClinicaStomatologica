using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectDisertatie
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin log = new AdminLogin();
            log.Show();
            this.Hide();
        }

        ConnectionString MyConnection = new ConnectionString();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection Con = MyConnection.GetCon();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Medic where NumeMedic='" + textBoxUserName.Text + "' and ParolaMedic='" + textBoxParola.Text + "' ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Programari App = new Programari();
                App.Show();
                this.Hide();
            }
            else
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from Pacienti where NumePac='" + textBoxUserName.Text + "' and ParolaPac='" + textBoxParola.Text + "' ", Con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if(dt1.Rows[0][0].ToString() == "1")
                {
                    Programari App = new Programari();
                    App.Show();
                    this.Hide();
                }
                else { 

                MessageBox.Show("UserName sau parola gresite!!!");
                textBoxUserName.Text = "";
                textBoxParola.Text = "";
                }

            }
             
            Con.Close();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPacientNou_Click(object sender, EventArgs e)
        {
            PacientiNoi pac = new PacientiNoi();
            pac.Show();
            this.Hide();
        }
    }
}
