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

            string[] array = new string[]
            {
                "Theonur212121@hotmail.com",
                "metin.oget@atolla.com.tr",
                 "onur.aslan@atolla.com.tr",
            };

            SendMail(array);

        }
        private static string SendMail(string [] mailAddress)
        {
            try
            {

                foreach (var item in mailAddress)
                {
                    MailMessage mesajım = new MailMessage();
                    SmtpClient istemci = new SmtpClient("smtp.outlook.com", 587);
                    istemci.UseDefaultCredentials = false;
                    istemci.Credentials = new System.Net.NetworkCredential("Theonur212121@hotmail.com", "onur2121");
                    istemci.DeliveryMethod = SmtpDeliveryMethod.Network;
                    istemci.EnableSsl = true;
                    mesajım.To.Add(item);
                    mesajım.From = new MailAddress("Theonur212121@hotmail.com");
                    mesajım.Subject ="Subject";//title
                    mesajım.Body = DateTime.UtcNow.ToString();
                    istemci.Send(mesajım);
                  
                }
            }
            catch (SmtpException e)
            {

                return e.ToString();
            }
            return "Mail gönderme işlemi başarılı";
        }
    }
}
