using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace SendMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.UseDefaultCredentials = false;
            istemci.Host = "smtp.outlook.com"; //sunucu bilgileri //smtp.gmail.com
            istemci.Port = 587;
            istemci.Credentials = new System.Net.NetworkCredential("Theonur212121@hotmail.com", "onur2121"); //kimlik bilgileri 
            istemci.DeliveryMethod = SmtpDeliveryMethod.Network;
            istemci.EnableSsl = true;
            mesajım.To.Add(TxtWho.Text);//maili nereye gönderecez
            mesajım.From = new MailAddress("Theonur212121@hotmail.com"); // mesajı kime göndercez
            mesajım.Subject = txtTitle.Text;//title
            mesajım.Body = txtMessage.Text;
            istemci.Send(mesajım);


        }
    }
}
