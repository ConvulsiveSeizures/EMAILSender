using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;

namespace EmailSender
{
    class Program
    {
        static void Main(string[] args)
        {
            //addresses
            MailAddress from = new MailAddress("from@gmail.com", "username");
            MailAddress to = new MailAddress("to@gmail.com");

            //message
            MailMessage message = new MailMessage(from, to);
            message.Body = "Body test message & c# practice";
            message.Subject = "Test subject theme.";

            //settings
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("from@gmail.com", "password");
            smtp.EnableSsl = true;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.UseDefaultCredentials = false;
            smtp.Send(message);
            Console.WriteLine("Message sent!");
            Console.ReadLine();
        }
    }
}
