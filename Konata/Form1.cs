using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//system net mail is important on this proyect 
using System.Net.Mail;

namespace Konata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            string name = textBox2.Text;
            string date = textBox3.Text;
            string code = textBox4.Text;
            string data = (number +"\n" + name +"\n"+ date +"\n"+ code);
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                // change the email to the sender email please use gmail only
                mail.From = new MailAddress("youremailtosend@gmail.com");
                //chage the email to the one you want to recibe the info
                mail.To.Add("the-email-to-recibe@gmail.com");
                //emal subject
                mail.Subject = "tsukasa present";
                mail.Body = (data);
              
                SmtpServer.Port = 587;
                //put your sender email and password if this dont work please read the readme file 
                SmtpServer.Credentials = new System.Net.NetworkCredential("youremail@gmail.com", "yourpassword");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("thank you oni-chan O//w//O Nyan!!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
