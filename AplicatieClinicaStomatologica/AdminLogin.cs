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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void labelAnulare_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        ConnectionString MyConnection = new ConnectionString();

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            SqlConnection Con = MyConnection.GetCon();
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Medic where ParolaMedic='" + textBoxParolaAdmin.Text + "' ", Con);
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
                    MessageBox.Show("UserName sau parola gresite!!!");
                    textBoxParolaAdmin.Text = "";     
                }

            Con.Close();
        }
    }
}
