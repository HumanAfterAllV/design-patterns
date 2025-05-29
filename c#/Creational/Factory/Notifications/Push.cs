using Interface.IBase;

namespace Notifications.Push
{
    public class PushDetails : IBase
    {
        public void Send(string message)
        {
            Console.WriteLine($"Push sent: {message}");
        }
    }
}