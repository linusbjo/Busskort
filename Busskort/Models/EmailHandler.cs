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
        private string FromAdress = "@gmail.com", Password = "lösenord", FromName = "Anmälan Busskort", BodyText;


        // Auto generated when user submits a form
        public void CreateRegistrationEmail(string Subject, BusskortServiceReference.Anmälan anmälan)
        {
            try
            {
                string line;
                string filePath = (AppDomain.CurrentDomain.BaseDirectory + "Custom/MailRegistrationTemplate.txt");
                var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                StreamReader file = new StreamReader(filePath);
                while ((line = file.ReadLine()) != null)
                {
                    BodyText += line;
                }
                file.Close();

                BodyText = BodyText.Replace("ReplaceContentSkola", anmälan.Skola);
                BodyText = BodyText.Replace("ReplaceContentBarnNamn", anmälan.barnFörnamn + " " + anmälan.barnEfternamn);
                BodyText = BodyText.Replace("ReplaceContentCaretaker", anmälan.Förnamn + " " + anmälan.Efternamn);

                SendEmail(Subject, anmälan.E_post);
            }
            catch
            {

            }
        }

        // Auto generated when decision has been made by admin
        public void CreateDecisionEmail(string Subject, BusskortServiceReference.Anmälan anmälan)
        {
            try
            {
                string line;
                string filePath = (AppDomain.CurrentDomain.BaseDirectory + "Custom/MailDecisionTemplate.txt");
                var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

                StreamReader file = new StreamReader(filePath);
                while ((line = file.ReadLine()) != null)
                {
                    BodyText += line;
                }
                file.Close();

                BodyText = BodyText.Replace("ReplaceContentSkola", anmälan.Skola);
                BodyText = BodyText.Replace("ReplaceContentBarnNamn", anmälan.barnFörnamn + " " + anmälan.barnEfternamn);
                BodyText = BodyText.Replace("ReplaceContentCaretaker", anmälan.Förnamn + " " + anmälan.Efternamn);

                if (anmälan.Beviljad.ToLower() == "ja")
                {
                    BodyText = BodyText.Replace("ReplaceContentBeviljad", "<span style =\"color: green; font - weight: bold; \">" + anmälan.Beviljad + "</span>");
                }
                else
                {
                    BodyText = BodyText.Replace("ReplaceContentBeviljad", "<span style =\"color: red; font - weight: bold; \">" + anmälan.Beviljad + "</span>");
                }

                BodyText = BodyText.Replace("ReplaceContentMotivering", anmälan.Motivering);

                SendEmail(Subject, anmälan.E_post);
            }
            catch
            {

            }
        }

        // Send the email
        private void SendEmail(string Subject, string ToEmailAdress)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(FromAdress, FromName);
                mail.To.Add(ToEmailAdress);
                mail.Subject = Subject;
                mail.Body = BodyText;
                mail.IsBodyHtml = true;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(FromAdress, Password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch
            {

            }
        }
    }
}