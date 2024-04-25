using System.Net.Mail;
using System.Net;

namespace InventoryManagementSystem.Methods
{
    public class SendEmailPassword
    {
        public static void Sendpassword(string password, string Email)
        {
            string sender = "sanjairock85@gmail.com";
            string senderPass = "vmrc sKxx ihyK jscu";
            MailMessage mail = new MailMessage(sender, Email);
            mail.Subject = "Password";
            mail.Body = $"This is notification from the Inventory Management System.Your new Password for {Email} account has been generated.\n Please take a moment to update your password\nNew Password:{password}";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential(sender, senderPass);
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);
        }

    }
}
