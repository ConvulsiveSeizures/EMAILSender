using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net;
using System.IO;
using System.Net.Mail;

namespace WpfEmailSender
{
    public partial class MainWindow {
        void Button_Click (object sender, RoutedEventArgs e) {

            MailAddress from = new MailAddress("...@gmail.com", "username");
            MailAddress to = new MailAddress("...@gmail.com", "username");

            MailMessage message = new MailMessage(from, to);
            message.Body = "Body test message & c# practice";
            message.Subject = "Test subject theme.";

            //settings
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("...@gmail.com", "password");
            smtp.EnableSsl = true;
            smtp.Send(message);
            Console.WriteLine("Message sent!");


        }
    }
}
