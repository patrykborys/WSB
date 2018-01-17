using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Mail;
using System.Configuration;


namespace PingLokalizacji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void autorMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Patyk Borys\npatryk.borys@outlook.com\nGrupa ćwiczeniowa K22");
        }

        public bool nie_odpowiada;

        private void Połącz_Click(object sender, EventArgs e)
        {
            
            //Jeżeli dany serwer jest osiągalny zostaje dodany do pola wynikowego 
            //jeżeli "nie_odpowiada = false" Serwer ... odpowiada
            //Jeżeli "nie_odpowiada = true" Serwer ... nie odpowiada

            if (string.IsNullOrEmpty(ipText.Text))
            {
                MessageBox.Show("Podaj poprawny adres IP lub nazwę hosta.");
            }
            else
            {
                nie_odpowiada = false;
                if (PingHost(ipText.Text))
                    wynik.Text += "Serwer: " + ipText.Text + " odpowiada.\n";
                else
                {
                    wynik.Text += "Serwer: " + ipText.Text + " nie odpowiada.\n";
                    nie_odpowiada = true;
                }
            }

        }
        //Funkcja sprawdza czy podany host jest 
        public static bool PingHost(string nazwaLubAddress)
        {
            bool pingStatus = false;
            Ping pinger = new Ping();
            try
            {
                PingReply status = pinger.Send(nazwaLubAddress);
                pingStatus = status.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                //Zwraca false w przypadku błędu
            }
            return pingStatus;

        }
        //Funkcja zerująca pole wynikowe
        private void Zeruj_Click(object sender, EventArgs e)
        {
            wynik.Clear();
        }
        //Funkcja zerująca pole IP
        private void ZerujIP_Click(object sender, EventArgs e)
        {
            ipText.Clear();
        }

        private void wyślij_Click(object sender, EventArgs e)
        {
            //Wywołanie funkcji Wyślij_maila
            Wyslij_maila(wynik.Text);
        }

        //Funkcja umożliwająca wysłanie wiadomości e-mail z danego serwera.
        public void Wyslij_maila(string tresc_maila)
        {
            MailMessage message = new MailMessage();

            try
            {
                message.From = new MailAddress(ConfigurationManager.AppSettings["email"], ConfigurationManager.AppSettings["subject"]);
                if (string.IsNullOrEmpty(mail.Text))
                {
                    MessageBox.Show("Podaj poprawny adres IP lub nazwę hosta.");
                }
                else
                {
                    message.To.Add(new MailAddress(mail.Text));
                    message.Subject = ConfigurationManager.AppSettings["subject"];
                    message.Body = tresc_maila;
                    SmtpClient smtp = new SmtpClient(ConfigurationManager.AppSettings["smtp_server"]);
                    smtp.UseDefaultCredentials = bool.Parse(ConfigurationManager.AppSettings["autoryzacja"]); 
                    smtp.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["password"]);
                    smtp.EnableSsl = bool.Parse(ConfigurationManager.AppSettings["ssl"]);
                    smtp.Port = int.Parse(ConfigurationManager.AppSettings["smtp_port"]);
                    smtp.Send(message);

                    MessageBox.Show("Wiadomość wysłana poprawnie");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Proszę sprawdzic wszystkie parametry połączenia." + ex);
            }
           
        }

        //Przejście do biblioteki SQLtoXML
        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SQLtoXML newForm = new SQLtoXML();
            newForm.ShowDialog();
        }
    }
}

