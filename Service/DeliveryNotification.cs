using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DeliveryNotification
    {
        SmtpClient smtpClient = new SmtpClient();

        MailMessage message = new MailMessage();
        MailAddress fromAddress = new MailAddress("A@technospine.com", "BALA");
        MailAddress adminAddress = new MailAddress("b@technospine.com");


        smtpClient.Host = "Mail Server Name";
        smtpClient.Port = 25;
        smtpClient.UseDefaultCredentials = true; 

        message.From = fromAddress;
        message.To.Add(_sendTo); //Recipent email
        message.Subject = _subject;
        message.Body = _details;
        message.IsBodyHtml = true;


        message.Headers.Add("Disposition-Notification-To", "b@technospine.com");

        message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;

        message.ReplyTo = adminAddress;

        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtpClient.Send(message);
    }
}
