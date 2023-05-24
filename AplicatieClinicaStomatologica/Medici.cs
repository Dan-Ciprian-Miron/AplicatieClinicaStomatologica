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
    public partial class Medici : Form
    {
        public Medici()
        {
            InitializeComponent();
        }

        void populate()
        {

            Pacientii Pac = new Pacientii();
            string query = "select * FROM Medic";
            DataSet ds = Pac.ShowPatcient(query);
            MedicSort.DataSource = ds.Tables[0];

        }
        private void buttonSalveazaPacienti_Click(object sender, EventArgs e)
        {
            string query = "insert into Medic values('" + NumeMedic.Text + "', '" + EmailMedic.Text + "', '" + TelefonMedic.Text + "', '" + ParolaMedic.Text + "')";
            Pacientii Pac = new Pacientii();
            try
            {
                Pac.AddPacient(query);
                MessageBox.Show("Medic adaugat cu succes!!!");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void Medici_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void MedicSort_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NumeMedic.Text = MedicSort.SelectedRows[0].Cells[1].Value.ToString();
            EmailMedic.Text = MedicSort.SelectedRows[0].Cells[2].Value.ToString();
            TelefonMedic.Text = MedicSort.SelectedRows[0].Cells[3].Value.ToString();
            ParolaMedic.Text = MedicSort.SelectedRows[0].Cells[4].Value.ToString();

            if (NumeMedic.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(MedicSort.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void buttonStergeProgramare_Click(object sender, EventArgs e)
        {
            Pacientii Pac = new Pacientii();
            if (key == 0)
            {
                MessageBox.Show("Alege Medicul care va fi sters!");
            }
            else
            {
                try
                {
                    string query = "Delete from Medic where IdMedic=" + key + "";
                    Pac.StergePacient(query);
                    MessageBox.Show("Medicul a fost sters");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void buttonModificaProgramare_Click(object sender, EventArgs e)
        {
            Pacientii Pac = new Pacientii();
            if (key == 0)
            {
                MessageBox.Show("Alege Medicul!");
            }
            else
            {
                try
                {
                    string query = "Update Medic set NumeMedic='" + NumeMedic.Text + "', EmailMedic='" + EmailMedic.Text + "', TelefonMedic='" + TelefonMedic.Text + "', ParolaMedic='" + ParolaMedic.Text + "'  where IdMedic=" + key + ";";
                    Pac.StergePacient(query);
                    MessageBox.Show("Medicul a fost modificat cu succes!");
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
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }

        private void labelPacienti_Click(object sender, EventArgs e)
        {
            Pacienti pac = new Pacienti();
            pac.Show();
            this.Hide();
        }

        private void labelProgramareConsult_Click(object sender, EventArgs e)
        {
            Tratament trat = new Tratament();
            trat.Show();
            this.Hide();
        }

        private void labelConsultProgramare_Click(object sender, EventArgs e)
        {
            Programari prog = new Programari();
            prog.Show();
            this.Hide();
        }

        private void labelLaborator_Click(object sender, EventArgs e)
        {
            Laborator lab = new Laborator();
            lab.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Pacienti pac = new Pacienti();
            pac.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Tratament trat = new Tratament();
            trat.Show();
            this.Hide();
        }

        private void labelConsult_Click(object sender, EventArgs e)
        {
            Consult cons = new Consult();
            cons.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Programari prog = new Programari();
            prog.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Laborator lab = new Laborator();
            lab.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }
    }

}


