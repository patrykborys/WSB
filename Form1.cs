using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Web;
using System.Net.Mail;
using System.Net.Security;


namespace Pingowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool nie_odpowiada;

        private void Form1_Load(object sender, EventArgs e)
        {
            nie_odpowiada = false;
            if (PingHost("10.65.130.19"))
                richTextBox1.Text += "Fizyczny HVINF 10.65.130.19 \t\t\todpowiada.\n";
            else
            {
                richTextBox1.Text += "Fizyczny HVINF 10.65.130.19 \t\t\t\tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.130.10"))
                richTextBox1.Text += "      Wirtualny RODC 10.65.130.10 \t\t\todpowiada.\n";
            else
            {
                richTextBox1.Text += "      Wirtualny RODC 10.65.130.10 \t\t\tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.130.11"))
                richTextBox1.Text += "      Wirtualny SRV1 10.65.130.11 \t\t\todpowiada.\n";
            else
            {
                richTextBox1.Text += "      Wirtualny SRV1 10.65.130.11 \t\t\tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.130.12"))
                richTextBox1.Text += "      Wirtualny SRV3 10.65.130.12 \t\t\todpowiada.\n";
            else
            {
                richTextBox1.Text += "      Wirtualny SRV3 10.65.130.12 \t\t\tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.130.18"))
                richTextBox1.Text += "      Wirtualny APPS 10.65.130.18 \t\t\todpowiada.\n\n";
            else
            {
                richTextBox1.Text += "      Wirtualny APPS 10.65.130.18 \t\t\tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.130.16"))
                richTextBox1.Text += "Fizyczny SRV2 10.65.130.16 \t\t\t\todpowiada.\n";
            else
            {
                richTextBox1.Text += "Fizyczny SRV2 10.65.130.16 \t\t\t\tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.121.3"))
                richTextBox1.Text += "      Wirtualny coda_app 10.65.121.3 \t\t\todpowiada.\n";
            else
            {
                richTextBox1.Text += "      Wirtualny coda_app 10.65.121.3 \t\t\tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.121.4"))
                richTextBox1.Text += "      Wirtualny coda_web 10.65.121.4 \t\t\todpowiada.\n";
            else
            {
                richTextBox1.Text += "      Wirtualny coda_web 10.65.121.4 \t\t\tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.121.5"))
                richTextBox1.Text += "      Wirtualny coda_base 10.65.121.5 \t\t\todpowiada.\n";
            else
            {
                richTextBox1.Text += "      Wirtualny coda_base 10.65.121.5 \t\t\tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.121.7"))
                richTextBox1.Text += "      Wirtualny s2k3r2 10.65.121.7 \t\t\todpowiada.\n";
            else
            {
                richTextBox1.Text += "      Wirtualny s2k3r2 10.65.121.7 \t\t\tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.121.8"))
                richTextBox1.Text += "      Wirtualny st2008 10.65.121.8 \t\t\todpowiada.\n";
            else
            {
                richTextBox1.Text += "      Wirtualny st2008 10.65.121.8 \t\t\tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.121.10"))
                richTextBox1.Text += "      Wirtualny dw2008 10.65.121.10 \t\t\todpowiada.\n\n";
            else
            {
                richTextBox1.Text += "      Wirtualny dw2008 10.65.121.10 \t\t\tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.130.17"))
                richTextBox1.Text += "Fizyczny backupowy SRV7 10.65.130.17 \t\todpowiada.\n\n";
            else
            {
                richTextBox1.Text += "Fizyczny backupowy SRV7 10.65.130.17 \t\tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.122.17"))
                richTextBox1.Text += "Fizyczny backupowy w Koszalinie SRV8 10.65.122.17 \todpowiada.\n\n";
            else
            {
                richTextBox1.Text += "Fizyczny backupowy w Koszalinie SRV8 10.65.122.17 \tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n\n";
                nie_odpowiada = true;
            }

            if (PingHost("10.65.123.17"))
                richTextBox1.Text += "Fizyczny backupowy w Złotoryi SRV7 10.65.123.17 \todpowiada.\n\n";
            else
            {
                richTextBox1.Text += "Fizyczny backupowy w Złotoryi SRV7 10.65.123.17 \tnie odpowiada!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n\n";
                nie_odpowiada = true;
            }
            
            if (nie_odpowiada)
            {
                Wyslij_maila(richTextBox1.Text);
                this.Close();
            }
            else
                this.Close();


        }
        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            return pingable;

        }

    

public static void Wyslij_maila(string tresc_maila)
{

	MailMessage message = new MailMessage();

	message.From = new MailAddress("serwery@colas.pl", "Raport działania serwerów");

	message.To.Add(new MailAddress("patryk.borys@colas.pl"));

	message.Subject = "Odpowiedzi z serwerów Colas";

	message.Body = tresc_maila;

	SmtpClient smtp = new SmtpClient("smtpinterne.groupe.sa.colas.com");

	smtp.UseDefaultCredentials = false;

	smtp.Credentials = new NetworkCredential("ricoh-kasa@colas.pl", "....");

	smtp.EnableSsl = false;

	smtp.Port = 25;

	smtp.Send(message);
    }
        
    }
}
