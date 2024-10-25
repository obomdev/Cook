using System.Net;
using System.Net.Mail;

namespace Cook.Services;

public class EmailSender : IEmailSender
{
    public async Task SendEmailAsync(string emailAddress, string subject, string htmlMessage)
    {
        var mail = "cook.app@outlook.com";
        var pw = "QV3E4khpZBEcL7K";

        var cliente = new SmtpClient("smtp-mail.oulook.com", 587)
        {
            EnableSsl = true,
            Credentials = new NetworkCredential(mail, pw)
        };

        MailMessage sendMail = new(
            from: mail,
            to: emailAddress,
            subject,
            htmlMessage

        );
        sendMail.IsBodyHtml = true;
        
        await cliente.SendMailAsync(sendMail);
        
    }
}
