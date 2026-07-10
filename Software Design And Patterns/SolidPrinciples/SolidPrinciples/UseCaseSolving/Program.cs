using System.Diagnostics;
using System.Threading.Tasks;

namespace UseCaseSolving
{
    internal class Program
    {
        //Use Case
        //2.You are tasked with building a notification system for a social media 
        // platform.The system must support sending notifications via email, SMS,
        //and push notifications.Over time, the platform might introduce new channels,
        //like WhatsApp or in-app notifications.


        static void Main(string[] args)
        {
            
        }

        #region SRP, OCP,LSP,ISP and DI

        public interface INotification
        {
            void Send(string Message, string recipient);
        }
        public interface ISchedulableNotification : INotification { 
            void Schedule(string Message, string recipient,DateTime ScheduleTime);
        }
        public class ScheduledSMSNotification : ISchedulableNotification
        {
            public void Schedule(string Message, string recipient, DateTime ScheduleTime)
            {
                throw new NotImplementedException();
            }

            public void Send(string Message, string recipient)
            {
                throw new NotImplementedException();
            }
        }
        public class NotificationService
        {
            private readonly IEnumerable<INotification> _notifications;
            public NotificationService(IEnumerable<INotification> notifications) { 
            _notifications = notifications;
            }
            public void Notify(INotification notification, string Message, string recipient)
            {
                notification.Send(Message, recipient);
            }
            public void NotifyInOneGo(string Message,string Receipients)
            {
                foreach (var notification in _notifications) { 
                    notification.Send(Message, Receipients);
                }
            }
        }

        public class WhatsappNotification : INotification
        {
            public void Send(string Message, string recipient)
            {
                throw new NotImplementedException();
            }
        }

        public class EmailNotification : INotification
        {
            public void Send(string message,string toEmail)
            {

            }
        }
        public class SMSNotification: INotification
        {
            public void Send(string message,string toPhone)
            {

            }
        }
        public class PushNotification: INotification
        {
            public void Send(string message,string toDeviceId)
            {

            }
        }


        #endregion
    }
}
