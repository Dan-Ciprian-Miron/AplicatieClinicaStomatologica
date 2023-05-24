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

    public partial class Pacienti : Form
    {

        public Pacienti()
        {
            InitializeComponent();
        }
        private void buttonSalveazaPacienti_Click(object sender, EventArgs e)
        {
            string query = "insert into Pacienti values('" + NumePac.Text + "', '" + AdresaPac.Text + "', '" + TelefonPac.Text + "', '" + EmailPac.Text + "', '" + ZiNasterePac.Value.Date + "', '" + SexPac.SelectedItem.ToString() + "', '" + ParolaPac.Text + "')";
            Pacientii Pac = new Pacientii();
            try
            {
                Pac.AddPacient(query);
                MessageBox.Show("Pacienet adaugat cu succes!!!");
                populate();
            }  
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

         }
        void populate()
        {
            Pacientii Pac = new Pacientii();
            string query = "select * FROM Pacienti";
            DataSet ds = Pac.ShowPatcient(query);
            PacSort.DataSource = ds.Tables[0];
        }

        private void Pacienti_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void PacSort_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NumePac.Text = PacSort.SelectedRows[0].Cells[1].Value.ToString();
            AdresaPac.Text = PacSort.SelectedRows[0].Cells[2].Value.ToString();
            TelefonPac.Text = PacSort.SelectedRows[0].Cells[3].Value.ToString();
            EmailPac.Text = PacSort.SelectedRows[0].Cells[4].Value.ToString();
            ZiNasterePac.Text = PacSort.SelectedRows[0].Cells[5].Value.ToString();
            SexPac.SelectedItem = PacSort.SelectedRows[0].Cells[6].Value.ToString();
            ParolaPac.Text = PacSort.SelectedRows[0].Cells[7].Value.ToString();
            if (NumePac.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PacSort.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void buttonStergePac_Click(object sender, EventArgs e)
        {

            Pacientii Pac = new Pacientii();
            if (key == 0)
            {
                MessageBox.Show("Alege Pacientul");
            }
            else
            {
                try
                {
                    string query = "Delete from Pacienti where Id_Pacient=" + key + "";
                    Pac.StergePacient(query);
                    MessageBox.Show("Pacientul a fost sters!");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            Pacientii Pac = new Pacientii();
            if (key == 0)
            {
                MessageBox.Show("Alege Pacientul");
            }
            else
            {
                try
                {
                    string query = "Update Pacienti set NumePac='" + NumePac.Text + "', AdresaPac='" + AdresaPac.Text + "', TelefonPac='" + TelefonPac.Text + "', EmailPac='" + EmailPac.Text + "', ZiNasterePac='" + ZiNasterePac.Value.Date + "', SexPac='" + SexPac.SelectedItem.ToString() + "', ParolaPac='" + ParolaPac.Text + "' where Id_Pacient=" + key + ";";                         
                    Pac.StergePacient(query);
                    MessageBox.Show("Datele au fost modificate cu succes!");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void labelConsult_Click(object sender, EventArgs e)
        {
            Consult consult = new Consult();
            consult.Show();
            this.Hide();
        }

        private void labelPacienti_Click(object sender, EventArgs e)
        {
            Programari prog = new Programari();
            prog.Show();
            this.Hide();
        }

        private void labelConsult_Click_1(object sender, EventArgs e)
        {
            Consult consult = new Consult();
            consult.Show();
            this.Hide();
        }

        private void labelMedici_Click(object sender, EventArgs e)
        {
            Medici med = new Medici();
            med.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Tratament trat = new Tratament();
            trat.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Laborator lab = new Laborator();
            lab.Show();
            this.Hide();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
 
}

