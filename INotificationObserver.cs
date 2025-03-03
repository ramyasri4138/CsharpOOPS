using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{
    public interface INotificationObserver
    {
        void Update(string message);
    }

    // The Concrete Observers
    public class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Email notification: {message}");
        }
    }

    public class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"SMS notification: {message}");
        }
    }

    // The Subject interface
    public interface INotificationSubject
    {
        void Attach(INotificationObserver observer);
        void Detach(INotificationObserver observer);
        void Notify(string message);
    }

    // The Concrete Subject
    public class NotificationService : INotificationSubject
    {
        private List<INotificationObserver> _observers = new List<INotificationObserver>();

        public void Attach(INotificationObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }

}
