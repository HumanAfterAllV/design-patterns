namespace Audit.Logger
{
    public class Logger
    {
        public void LogAccess(string user, string fileName)
        {
            DateTime now = DateTime.Now;

            string dateFormat = now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine($"{dateFormat} Attempted access by: {user} - {fileName}");
        }
    }
}