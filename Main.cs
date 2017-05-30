using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMailClient
{
    public partial class MainWindow : Form
    {
        private String username, password;
        private Socket mailServerSocket;

        public string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private bool ConnectToMailServer() {
            try
            {
                this.mailServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                this.mailServerSocket.Connect("217.74.65.23", 587);
                return true;
            }
            catch (SocketException exception)
            {
                MessageBox.Show("Connection failed!" + exception.Message);
                return false;
            }
        }
        private string ReceiveMessage()
        {
            byte[] serverMessage = new byte[1024];
            if (this.mailServerSocket != null)
            {
                this.mailServerSocket.Receive(serverMessage);
                string serverMessageString = ASCIIEncoding.ASCII.GetString(serverMessage);
                return serverMessageString;
            }
            return "";
        }

        private void SendMessage(string message)
        {
            if (this.mailServerSocket != null)
            {
                this.mailServerSocket.Send(ASCIIEncoding.ASCII.GetBytes(message));
            }else MessageBox.Show("Cannot send message: " + message);
        }
        private string convertBytesToStringArray(byte[] bytes)
        {
            return ASCIIEncoding.ASCII.GetString(bytes);
        }

        public void InitializeConnection()
        {
            if (!this.ConnectToMailServer())
                return;

            if (ReceiveMessage().Substring(0,3) == "220")
            {
                this.SendMessage("EHLO Zachary\r\n");
            }
            else return;
       
            if (ReceiveMessage().Substring(0, 3) == "250")
            {
                this.SendMessage("AUTH LOGIN\r\n");
            }
            else return;

            if (ReceiveMessage().Substring(0, 3) == "334")
            {
                this.SendMessage(this.username);
            }
            else return;

            if (ReceiveMessage().Substring(0, 3) == "334")
            {
                this.SendMessage(this.password);
            }
            else return;
            if (ReceiveMessage().Substring(0,3) == "235")
            {
                this.ConnectionStatus.Text += " Connected!";
            }
            else return;
        }

        public MainWindow()
        {
            InitializeComponent();
            this.username = this.Base64Encode("pas2017@interia.pl");
            this.password = this.Base64Encode("P4SInf2017");
            this.username += "\r\n";
            this.password += "\r\n";

            this.InitializeConnection();
        }

        private void SendMailBtn_Click(object sender, EventArgs e)
        {
            string EMAIL_FROM = "pas2017@interia.pl",
            EMAIL_TO , DATA, QUIT = "QUIT\r\n", SUBJECT;

            EMAIL_TO = this.RecipientAddress.Text;
            SUBJECT = this.MessageSubject.Text;
            DATA = this.UserMessage.Text;


            this.SendMessage("MAIL FROM: <" + EMAIL_FROM+ ">\r\n");
            this.SendMessage("RCPT TO: <" + EMAIL_TO + ">\r\n");
            this.SendMessage("SUBJECT: " + SUBJECT + "\r\n\n");
            this.SendMessage("DATA\r\n");
            this.SendMessage(DATA + "\n.\r\n");

            if (this.ReceiveMessage().Contains("250"))
                MessageBox.Show("UDALO SIE");
            this.SendMessage(QUIT);
            MessageBox.Show("Mail sent!");
        }

        private void RecipientAddress_TextChanged(object sender, EventArgs e)
        {

        }     
    }
}
