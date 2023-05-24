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
    public partial class Laborator : Form
    {
        public Laborator()
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
            PacientiCB.ValueMember = "Pacient";
            PacientiCB.DataSource = dt;
            Con.Close();
        }
        void populate()
        {

            Pacientii Pac = new Pacientii();
            string query = "select * FROM Laborator";
            DataSet ds = Pac.ShowPatcient(query);
            LucrariSort.DataSource = ds.Tables[0];

        }
        void filter()
        {

            Pacientii Pac = new Pacientii();
            string query = "select * FROM Laborator";
            DataSet ds = Pac.ShowPatcient(query);
            LucrariSort.DataSource = ds.Tables[0];

        }


        private void Laborator_Load(object sender, EventArgs e)
        {
           
            populate();
            FillPacienti();
        }


        private void buttonSalveazaLab_Click(object sender, EventArgs e)
        {
            string query = "insert into Laborator values ('" + textBoxLucrare.Text + "', '" + textBoxCuloare.Text + "', '" + textBoxElemente.Text + "','" + PacientiCB.SelectedValue.ToString() + "','" + textBoxObservatii.Text + "', '" + textBoxProba1.Text + "', '"+ OraProba1.Text +"', '"+textBoxProba2.Text+"', '"+ OraProba2.Text +"' )";
            Pacientii Pac = new Pacientii();
            try
            {
                Pac.AddPacient(query);
                MessageBox.Show("Lucrare inregistrata cu succes!!!");
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
            {
                PacientiCB.SelectedValue = LucrariSort.SelectedRows[0].Cells[4].Value.ToString();
                textBoxLucrare.Text = LucrariSort.SelectedRows[0].Cells[1].Value.ToString();
                textBoxCuloare.Text = LucrariSort.SelectedRows[0].Cells[2].Value.ToString();
                textBoxElemente.Text = LucrariSort.SelectedRows[0].Cells[3].Value.ToString();
                textBoxObservatii.Text = LucrariSort.SelectedRows[0].Cells[5].Value.ToString();
                textBoxProba1.Text = LucrariSort.SelectedRows[0].Cells[6].Value.ToString();
                OraProba1.Text = LucrariSort.SelectedRows[0].Cells[7].Value.ToString();
                textBoxProba2.Text = LucrariSort.SelectedRows[0].Cells[8].Value.ToString();
                OraProba2.Text = LucrariSort.SelectedRows[0].Cells[9].Value.ToString();


                if (PacientiCB.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(LucrariSort.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

       private void buttonStergeLaborator_Click(object sender, EventArgs e)
        {
            Pacientii Pac = new Pacientii();
            if (key == 0)
            {
                MessageBox.Show("Alege ce Lucrare va fi stearsa!");
            }
            else
            {
                try
                {
                    string query = "Delete from Laborator where IdLab=" + key + "";
                    Pac.StergePacient(query);
                    MessageBox.Show("Lucrarea a fost stearsa!");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void buttonModificaLaborator_Click(object sender, EventArgs e)
        {
            Pacientii Pac = new Pacientii();
            if (key == 0)
            {
                MessageBox.Show("Alege Lucrarea!");
            }
            else
            {
                try
                {
                    string query = "Update Laborator set Lucrare='" + textBoxLucrare.Text + "', Culoare='" + textBoxCuloare.Text + "', NumarElemente='" + textBoxElemente.Text + "', NumePac='" + PacientiCB.SelectedValue.ToString() + "' , Observatii='" + textBoxObservatii.Text + "', Progr1='" + textBoxProba1.Text + "', Ora1='" + OraProba1.Text + "', Progr2='" + textBoxProba2.Text + "', Ora2='" + OraProba2.Text + "'  where IdLab=" + key + "; ";
                    Pac.StergePacient(query);
                    MessageBox.Show("Lucrarea a fost modificata cu succes!");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
      private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            int height = LucrariSort.Height;
            LucrariSort.Height = LucrariSort.RowCount * LucrariSort.RowTemplate.Height * 2;
            bitmap = new Bitmap(LucrariSort.Width, LucrariSort.Height);
            LucrariSort.DrawToBitmap(bitmap, new Rectangle(0, 10, LucrariSort.Width, LucrariSort.Height));
            LucrariSort.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void labelPacienti_Click(object sender, EventArgs e)
        {
            Pacienti pac = new Pacienti();
            pac.Show();
            this.Hide();
        }

        private void labelProgramareTratament_Click(object sender, EventArgs e)
        {
            Programari prog = new Programari();
            prog.Show();
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

        private void label5_Click(object sender, EventArgs e)
        {
            Tratament trat = new Tratament();
            trat.Show();
            this.Hide();
        }

        private void pictureBoxLogout_Click(object sender, EventArgs e)
        {
            Laborator lab = new Laborator();
            lab.Show();
            this.Hide();
        }

        private int field;
    }
}
