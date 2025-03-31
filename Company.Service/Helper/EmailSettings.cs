using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.Helper
{
    public static class EmailSettings // Responsible for sending the email
    {
        public static void SendEmail(Email input)
        {
            // SMTP => simple mail transfer protocol -> SMTP server responsible for sending emails -> default port is 25 -> port 587 is encrypted and secure.
            var client = new SmtpClient("smtp.gmail.com", 587);

            client.EnableSsl = true;

            client.Credentials = new NetworkCredential("sanada927@gmail.com", "yggtphrcolnnxvsb");

            client.Send("sanada927@gmail.com", input.To, input.Subject, input.Body);
        }
    }
}
