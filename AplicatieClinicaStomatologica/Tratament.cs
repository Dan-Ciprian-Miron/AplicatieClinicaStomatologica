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
    public partial class Tratament : Form
    {
        public Tratament()
        {
            InitializeComponent();
        }

        private void buttonSalveazaTratament_Click(object sender, EventArgs e)
        {
            string query = "insert into Tratament values('" + textBoxTratamente.Text + "', '" + textBoxCostTratamente.Text + "', '" + textBoxManopera.Text + "')";
            Pacientii Pac = new Pacientii();
            try
            {
                Pac.AddPacient(query);
                MessageBox.Show("Tratament adaugat cu succes!!!");
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
            string query = "select * FROM Tratament";
            DataSet ds = Pac.ShowPatcient(query);
            TratamentSort.DataSource = ds.Tables[0];
        }

        private void Tratament_Load(object sender, EventArgs e)
        {

            populate();
        }

        int key =0;
        private void buttonModificaTratamente_Click(object sender, EventArgs e)
        {
            Pacientii Pac = new Pacientii();
            if (key == 0)
            {
                MessageBox.Show("Alege Tratamentul");
            }
            else
            {
                try
                {
                    string query = "Update Tratament set NumeTratament='" + textBoxTratamente.Text + "', CostTratament='" + textBoxCostTratamente.Text + "', ManoperaTratament='" + textBoxManopera.Text + "' where IdTratament=" + key + ";";
                    Pac.StergePacient(query);
                    MessageBox.Show("Tratamentul a fost modificat cu succes!");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void TratamentSort_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTratamente.Text = TratamentSort.SelectedRows[0].Cells[1].Value.ToString();
            textBoxCostTratamente.Text = TratamentSort.SelectedRows[0].Cells[2].Value.ToString();
            textBoxManopera.Text = TratamentSort.SelectedRows[0].Cells[3].Value.ToString();

            if (textBoxTratamente.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TratamentSort.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void buttonStergeTratamente_Click(object sender, EventArgs e)
        {
            Pacientii Pac = new Pacientii();
            if (key == 0)
            {
                MessageBox.Show("Alege Tratamentul");
            }
            else
            {
                try
                {
                    string query = "Delete from Tratament where IdTratament=" + key + "";
                    Pac.StergePacient(query);
                    MessageBox.Show("Tratamentul a fost sters!");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void labelPacienti_Click(object sender, EventArgs e)
        {
            Pacienti Pac = new Pacienti();
            Pac.Show();
            this.Hide();
        }

        private void labelProgramareTratament_Click(object sender, EventArgs e)
        {
            Programari progr = new Programari();
            progr.Show();
            this.Hide();
        }

        private void labelConsult_Click(object sender, EventArgs e)
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

        private void labelLaborator_Click(object sender, EventArgs e)
        {
            Laborator lab = new Laborator();
            lab.Show();
            this.Hide();
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
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
