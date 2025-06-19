using Interface.IBase;

namespace Notifications.Sms
{
    public class SmsDetails : IBase
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sms sent: {message}");
        }
    }
}