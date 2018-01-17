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
using System.Security.Principal;

namespace PingLokalizacji
{
    public partial class SQLtoXML : Form
    {
        public SQLtoXML()
        {
            InitializeComponent();
        }
        //Ustanowienie połączenia z bazą danych na bazie parametrów wypełnionych przez użytkownika
        public SqlConnection Polacz()
        {
            string nazwa = WindowsIdentity.GetCurrent().Name.Remove(WindowsIdentity.GetCurrent().Name.IndexOf('\\'));
            string sConnectionString = @"Data Source=" + tekstboxIP.Text + ";database = " + tekstboxBaza.Text + "; User ID = " + teksttboxLogin.Text + "; Password = " + tekstboxHasło.Text;

            SqlConnection objConn = new SqlConnection(sConnectionString);
            try
            {
                objConn.Open();
                if (objConn.State == ConnectionState.Open)
                    MessageBox.Show("Połączenie nawiązane");
                return objConn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia: " + ex.Message);
                return null;
            }
        }

        private void Autor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Patryk Borys\nWSB\nGrupa ćwiczeniowa: K22\ne-mail: patryk.borys@outlook.com");
        }

        private void Połącz_Click(object sender, EventArgs e)
        {
            Polacz();
        }

        //Próba połączenia z bazą danych
        //Jeżeli się powiedzie program wyeksportuje strukturę tabeli do pliku baza.xml
        private void Eksport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tekstboxTabela.Text))
            {
                MessageBox.Show("Pole Tabela nie może być puste");
            }
            else
            {
                try
                {
                    SqlConnection połącz = Polacz();
                    string zapytanie = "SELECT * FROM " + tekstboxTabela.Text;
                    SqlDataAdapter wykonanie = new SqlDataAdapter(zapytanie, połącz);
                    DataSet export = new DataSet();
                    wykonanie.Fill(export);
                    export.WriteXml("baza.xml");
                    MessageBox.Show("Poprawnie wyeksportowano tabele");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Proszę sprawdzić wszystkie parametry połączenia" + ex);
                }

            }
        }
        //Menu 
        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Patyk Borys\npatryk.borys@outlook.com\nGrupa ćwiczeniowa K22");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1();
            newForm.ShowDialog();
        }
    }
}
