using System.Net.Mail;
using System.Net;
using System.Reflection.Emit;

namespace EmailDIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Creating the Gmail service instance
           IEmailService gmailService = new GmailService();

           // Injecting the Gmail service into the Notification service
           NotificationService notificationService = new NotificationService(gmailService);

           // Sending a notification
           notificationService.SendNotification("recipient@example.com", "This is a test notification message.");

           Console.WriteLine("Notification sent successfully.");

        }
    }

    #region Bad Design 
    //public class GmailService
    //{
    //    public void SendEmail(string to, string subject, string body)
    //    {
    //        Console.WriteLine($"Sending email via Gmail to {to}: {subject}");
    //        // Implementation of sending email via Gmail SMTP
    //    }
    //}

    //public class NotificationService
    //{
    //    private GmailService _gmailService = new GmailService();

    //    public void SendNotification(string to, string message)
    //    {
    //        string subject = "Notification";
    //        _gmailService.SendEmail(to, subject, message);
    //    }
    //}

    ////High-level module(NotificationService) is tightly coupled with the low-level module(GmailService).
    ////If you need to switch from Gmail to another email service provider, 
    ////    you’d have to modify the NotificationService class, which violates the Dependency Inversion Principle.
    #endregion

    #region Good Design 
    //// Abstraction
    //public interface IEmailService
    //{
    //    void SendEmail(string to, string subject, string body);
    //}

    //// Low-level module
    //public class GmailService : IEmailService
    //{
    //    public void SendEmail(string to, string subject, string body)
    //    {
    //        Console.WriteLine($"Sending email via Gmail to {to}: {subject}");
    //        // Implementation of sending email via Gmail SMTP
    //    }
    //}

    //// High-level module
    //public class NotificationService
    //{
    //    private readonly IEmailService _emailService;

    //    public NotificationService(IEmailService emailService)
    //    {
    //        _emailService = emailService;
    //    }

    //    public void SendNotification(string to, string message)
    //    {
    //        string subject = "Notification";
    //        _emailService.SendEmail(to, subject, message);
    //    }
    //}

    ////How we are achieving DIP?
    ////1. Abstraction(IEmailService) : Both NotificationService(high-level module) and
    ////    GmailService(low-level module) depend on the IEmailService interface.
    ////2. Decoupling: NotificationService is no longer dependent directly on GmailService.
    ////    Instead, it depends on the IEmailService interface.
    ////    This makes it easy to replace GmailService with another email service provider(e.g., OutlookService) without changing NotificationService.


    #endregion

    #region Actual Implementation of Email with GMail 
    //    using System.Net;
    //    using System.Net.Mail;

    //public class GmailService : IEmailService
    //    {
    //        public void SendEmail(string to, string subject, string body)
    //        {
    //            var fromAddress = new MailAddress("YourEmail@gmail.com", "Message");
    //            var toAddress = new MailAddress(to);
    //            const string fromPassword = "your-email-password";

    //            var smtp = new SmtpClient
    //            {
    //                Host = "smtp.gmail.com",
    //                Port = 587,//465
    //                EnableSsl = true,
    //                DeliveryMethod = SmtpDeliveryMethod.Network,
    //                UseDefaultCredentials = false,
    //                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
    //            };

    //            using (var message = new MailMessage(fromAddress, toAddress)
    //            {
    //                Subject = subject,
    //                Body = body
    //            })
    //            {
    //                smtp.Send(message);
    //            }

    //            Console.WriteLine($"Email sent via Gmail to {to}: {subject}");
    //        }
    //    }

    #endregion

}
