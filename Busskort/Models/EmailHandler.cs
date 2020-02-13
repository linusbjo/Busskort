using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Busskort.Models
{
    public class EmailHandler
    {
        private string FromAdress = "@gmail.com", Password = "lösenord", FromName = "Anmälan Service";

        public void SendRegisterMail(string ToMailAdress, string Subject)
        {

            string text;
            string filePath = (AppDomain.CurrentDomain.BaseDirectory + "Custom/MailTemplate.txt");
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, System.Text.Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(FromAdress, FromName);
                mail.To.Add(ToMailAdress);
                mail.Subject = Subject;
                mail.Body = text;
                mail.IsBodyHtml = true;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(FromAdress, Password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {

            }
        }

        //TODO: Lägg till message i mail
        public void SendMail(string ToMailAdress, string Subject, string message)
        {

            string text;
            string filePath = (AppDomain.CurrentDomain.BaseDirectory + "Custom/MailTemplate.txt");
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, System.Text.Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(FromAdress, FromName);
                mail.To.Add(ToMailAdress);
                mail.Subject = Subject;
                mail.Body = text;
                mail.IsBodyHtml = true;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(FromAdress, Password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {

            }
        }
    }
}