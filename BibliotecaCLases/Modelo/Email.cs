using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Modelo
{
    public static class Email
    {
        public static void SendEmail(string email, string subject, string body)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("email@gmail.com", "password");
            smtpClient.EnableSsl = true;

            var message = new MailMessage();
            message.From = new MailAddress("email@gmail.com");
            message.To.Add(new MailAddress(email));
            message.Subject = subject;
            message.Body = body;


            try
            {
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
