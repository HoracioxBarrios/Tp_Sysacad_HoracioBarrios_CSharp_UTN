using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using MailKit;
using MailKit.Net.Smtp;
using MimeKit;

namespace BibliotecaCLases.Modelo
{
    public static class Email
    {
        public static void SendMessageSmtp(string email)
        {
            // Compose a message
            MimeMessage mail = new MimeMessage();
            mail.From.Add(new MailboxAddress("Excited Admin", "foo@sandboxa624a102f69e45f99032eb56ad582179.mailgun.org"));
            mail.To.Add(new MailboxAddress("Excited User", email));
            mail.Subject = "Registro de alumno";
            mail.Body = new TextPart("plain")
            {
                Text = @"Registro exitoso, bienvenido al nuevo SistemaSysacad",
            };

            // Send it!
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                // XXX - Should this be a little different?
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtp.mailgun.org", 587, false);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate("postmaster@sandboxa624a102f69e45f99032eb56ad582179.mailgun.org", "d5727e5f2d6529b1da2e481d429215a4-77316142-c6d8aaa5");

                client.Send(mail);
                client.Disconnect(true);
            }
        }




        /// <summary>
        /// Se encarga de enviar un email
        /// </summary> ------------ FALTA LA LOGICA --------------
        /// <param name="texto"></param>
        /// <returns>string</returns>
        public static string Enviar(string texto)
        {
            return texto;
        }
    }
}
