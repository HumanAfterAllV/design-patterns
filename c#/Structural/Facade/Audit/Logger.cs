
namespace Audit.Logger
{
    public class Logger
    {
        public void LoggerAction(string user, string action)
        {
            DateTime now = DateTime.Now;

            string dateFormat = now.ToString("yyyy-MM-dd HH:mm:ss");

            Console.WriteLine($"{dateFormat} Attempted access by: {user} - {action}");
        }
    }
}