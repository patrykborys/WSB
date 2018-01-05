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

namespace SQLtoXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection Polacz()
        {
            string nazwa = WindowsIdentity.GetCurrent().Name.Remove(WindowsIdentity.GetCurrent().Name.IndexOf('\\'));
            string sConnectionString = @"Data Source=" + tekstboxIP.Text + ";database = " + tekstboxBaza.Text + "; User ID = " + teksttboxLogin.Text + "; Password = "+ tekstboxHasło.Text;

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
                }catch(Exception ex)
                {
                    MessageBox.Show("Proszę sprawdzić wszystkie parametry połączenia" + ex);
                }
                
            }
            
        }
    }
}
