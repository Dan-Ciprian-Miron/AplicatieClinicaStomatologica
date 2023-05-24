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
    public partial class Consult : Form
    {
        public Consult()
        {
            InitializeComponent();
        }

        ConnectionString MyCon = new ConnectionString();


        private void FillPacienti()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Pacient from Programare", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Pacient", typeof(string));
            dt.Load(rdr);
            textBoxPacConsult.ValueMember = "Pacient";
            textBoxPacConsult.DataSource = dt;
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
            dt.Columns.Add("Pacient", typeof(string));
            dt.Load(rdr);
            textBoxPacConsult.ValueMember = "Pacient";
            textBoxPacConsult.DataSource = dt;
            Con.Close();
        }
        private void GetTratament()
         {
              SqlConnection Con = MyCon.GetCon();
              Con.Open();
              SqlCommand cmd = new SqlCommand("SELECT * from Programare where Pacient='"+textBoxPacConsult.SelectedValue.ToString()+"'", Con);
              DataTable dt = new DataTable();
              SqlDataAdapter sda = new SqlDataAdapter(cmd);
              sda.Fill(dt);
              foreach(DataRow dr in dt.Rows)
              {
                  textBoxConsultTratament.Text = dr["Tratament"].ToString();
              }
              Con.Close();
         }
        private void GetCost()
        {
            SqlConnection Con = MyCon.GetCon();
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Tratament where NumeTratament='" + textBoxConsultTratament.Text + "'", Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBoxCostConsult.Text = dr["CostTratament"].ToString();
            }
            Con.Close();
        }

        private void Consult_Load(object sender, EventArgs e)
        {
            FillPacienti();
            populate();
        }

        private void textBoxPacConsult_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTratament();
        }

        private void textBoxConsultTratament_TextChanged(object sender, EventArgs e)
        {
            GetCost();
        }

        void populate()
        {
            Pacientii Pac = new Pacientii();
            string query = "select * FROM Consult";
            DataSet ds = Pac.ShowPatcient(query);
            ConsultSort.DataSource = ds.Tables[0];
        }
        private void buttonSalveazaConsult_Click(object sender, EventArgs e)
        {
            string query = "insert into Consult values('" + textBoxPacConsult.SelectedValue.ToString() + "', '" + textBoxConsultTratament.Text + "', '" + textBoxCostConsult.Text + "' , '"+textBoxDiagnostic.Text+"')";
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

        int key = 0;
        private void ConsultSort_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                textBoxPacConsult.SelectedValue = ConsultSort.SelectedRows[0].Cells[1].Value.ToString();
                textBoxConsultTratament.Text = ConsultSort.SelectedRows[0].Cells[2].Value.ToString();
                textBoxCostConsult.Text = ConsultSort.SelectedRows[0].Cells[3].Value.ToString();
                textBoxDiagnostic.Text = ConsultSort.SelectedRows[0].Cells[4].Value.ToString();
                
                if (textBoxConsultTratament.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(ConsultSort.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void buttonStergeConsult_Click(object sender, EventArgs e)
        {
            Pacientii Pac = new Pacientii();
            if (key == 0)
            {
                MessageBox.Show("Alege Consultul!");
            }
            else
            {
                try
                {
                    string query = "Delete from Consult where IdConsult=" + key + "";
                    Pac.StergePacient(query);
                    MessageBox.Show("Consultatia a fost stearsa!");
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
            Programari progr = new Programari();
            progr.Show();
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
