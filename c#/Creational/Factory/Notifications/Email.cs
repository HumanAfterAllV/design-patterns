using Interface.IBase;

namespace Notifications.Email
{
    public class EmailDetails : IBase
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}