using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProiectDisertatie
{
    public partial class Programari : Form
    {
        public Programari()
        {
            InitializeComponent();
        }


        ConnectionString MyCon = new ConnectionString();


        private void FillPacienti()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT NumePac from Pacienti", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("NumePac", typeof(string));
            dt.Load(rdr);
            PacientCB.ValueMember = "NumePac";
            PacientCB.DataSource = dt;
            Con.Close();

        }
        private void FillMedici()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT NumeMedic from Medic", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("NumeMedic", typeof(string));
            dt.Load(rdr);
            MediciCB.ValueMember = "NumeMedic";
            MediciCB.DataSource = dt;
            Con.Close();

        }


        private void FillTratament()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT NumeTratament from Tratament", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("NumeTratament", typeof(string));
            dt.Load(rdr);
            TratamentCB.ValueMember = "NumeTratament";
            TratamentCB.DataSource = dt;
            Con.Close();

        }

        private void Programari_Load(object sender, EventArgs e)
        {
            FillPacienti();
            FillTratament();
            FillMedici();
            populate();
        }

        void populate()
        {

            Pacientii Pac = new Pacientii();
            string query = "select * FROM Programare";
            DataSet ds = Pac.ShowPatcient(query);
            ProgramareSort.DataSource = ds.Tables[0];

        }
        private void buttonSalveazaProgramari_Click(object sender, EventArgs e)
        {
            string query = "insert into Programare values('" + PacientCB.SelectedValue.ToString() + "', '" + TratamentCB.SelectedValue.ToString() + "','" + MediciCB.SelectedValue.ToString() + "', '" + DataProgramare.Value.Date + "', '" + OraProgramare.Text + "')";
            Pacientii Pac = new Pacientii();
            try
            {
                Pac.AddPacient(query);
                MessageBox.Show("Programare inregistrata cu succes!!!");
                populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;
        private void ProgramareSort_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            PacientCB.SelectedValue = ProgramareSort.SelectedRows[0].Cells[1].Value.ToString();
            MediciCB.SelectedValue = ProgramareSort.SelectedRows[0].Cells[3].Value.ToString();
            TratamentCB.SelectedValue = ProgramareSort.SelectedRows[0].Cells[2].Value.ToString();
            string Pac = ProgramareSort.SelectedRows[0].Cells[4].Value.ToString();

            if (Pac == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ProgramareSort.SelectedRows[0].Cells[0].Value.ToString());
            }
            //ProgramareSort.Columns[0].DefaultCellStyle.Format = "dd.MM.yyyy";
        }

        private void buttonStergeProgramare_Click(object sender, EventArgs e)
        {
            Pacientii Pac = new Pacientii();
            if (key == 0)
            {
                MessageBox.Show("Alege ce programare va fi stearsa!");
            }
            else
            {
                try
                {
                    string query = "Delete from Programare where IdProgramare=" + key + "";
                    Pac.StergePacient(query);
                    MessageBox.Show("Programarea a fost stearsa!");
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
                MessageBox.Show("Alege Programarea!");
            }
            else
            {
                try
                {
                    string query = "Update Programare set Pacient='" + PacientCB.SelectedValue.ToString() + "', Tratament='" + TratamentCB.SelectedValue.ToString() + "', NumeMedic='" + MediciCB.SelectedValue.ToString() + "', DataProgramare='" + DataProgramare.Value.Date + "', OraProgramare='" + OraProgramare.Text + "'  where IdProgramare=" + key + ";";
                    Pac.StergePacient(query);
                    MessageBox.Show("Programarea a fost modificata cu succes!");
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

        private void labelTratament_Click(object sender, EventArgs e)
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

        private void labelMedici_Click(object sender, EventArgs e)
        {
            Medici Med = new Medici();
            Med.Show();
            this.Hide();
        }

        private void labelLaborator_Click(object sender, EventArgs e)
        {
            Laborator Lab = new Laborator();
            Lab.Show();
            this.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {
            Laborator lab = new Laborator();
            lab.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Tratament trat = new Tratament();
            trat.Show();
            this.Hide();
        }

        private void labelMedici_Click_1(object sender, EventArgs e)
        {
            Medici Med = new Medici();
            Med.Show();
            this.Hide();
        }

        private void labelConsult_Click_1(object sender, EventArgs e)
        {
            Consult cons = new Consult();
            cons.Show();
            this.Hide();
        }
    }

}

   

