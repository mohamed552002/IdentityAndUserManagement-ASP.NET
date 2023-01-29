using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System.Net;
using System.Net.Mail;

namespace IdentityAndUserManagement.Services
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromMail = "mozamezo638@gmail.com";
            var fromPassword = "Mmmfiza12";

            var message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = subject;
            message.To.Add(email);
            message.Body = $"<html><body>{htmlMessage}</body></html>";
            message.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.outlook.com")
            {
                
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true
                
            };
            smtpClient.Send(message);
        }
    }
}
